using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Windows.Threading;
using LMS_WPFApp;

namespace LMS_UnitTests
{
    [TestClass]
    public class StudentMenuTests
    {
        private const string DatabasePath = "inventoryDatabase.csv";

        [STAThread]
        [TestMethod]
        public void StudentMenuOpenTest()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();
            string username = "jd1234a";

            studentMenu studentMenuInstance = null;

            // Instantiate the studentMenu on the UI thread
            var thread = new Thread(() =>
            {
                studentMenuInstance = new studentMenu(testUserManager, testInventoryManager, username);
                studentMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !studentMenuInstance.IsVisible)
            {
                Assert.Fail("Student window did not open!");
            }
        }

        [STAThread]
        [TestMethod]
        public void StudentMenuCloseTest()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();
            string username = "jd1234a";

            studentMenu studentMenuInstance = null;

            // Instantiate the studentMenu on the UI thread
            var thread = new Thread(() =>
            {
                studentMenuInstance = new studentMenu(testUserManager, testInventoryManager, username);
                studentMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to close
            bool timeout = !thread.Join(TimeSpan.FromSeconds(5));

            if (!timeout && studentMenuInstance.IsVisible)
            {
                Assert.Fail("The window did not close");
            }
        }
    }
}
