﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Windows.Threading;
using LMS_WPFApp;

namespace LMS_UnitTests
{
    [TestClass()]
    public class bookRentalTests
    {
        [STAThread]
        [TestMethod()]
        public void bookRentalopenTest()
        {

            // Arrange
            var testUserManager = new UserManager();
            var testInventoryManager = new InventoryManager();
            var username = "jd1234a";
            testUserManager.OpenDatabaseFile();
            testInventoryManager.OpenDatabaseFile();

            bookRental bookRentalInstance = null;

            // Act: Instantiate the bookRental on the UI thread
            var thread = new Thread(() =>
            {
                bookRentalInstance = new bookRental(testUserManager, testInventoryManager, username);
                bookRentalInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !bookRentalInstance.IsVisible)
            {
                Assert.Fail("Book rental window did not open!");
            }
        }

        [STAThread]
        [TestMethod()]
        public void BookRentalCloseTest()
        {
            // Arrange
            var testUserManager = new UserManager();
            var testInventoryManager = new InventoryManager();
            var username = "jd1234a";
            testUserManager.OpenDatabaseFile();
            testInventoryManager.OpenDatabaseFile();

            bookRental bookRentalInstance = null;

            // Act: Instantiate the bookRental on the UI thread
            var thread = new Thread(() =>
            {
                bookRentalInstance = new bookRental(testUserManager, testInventoryManager, username);
                bookRentalInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to close
            bool timeout = !thread.Join(TimeSpan.FromSeconds(5));

            // Assert
            Assert.IsTrue(!timeout || bookRentalInstance.IsVisible, "The window did not close");
        }

    }

}