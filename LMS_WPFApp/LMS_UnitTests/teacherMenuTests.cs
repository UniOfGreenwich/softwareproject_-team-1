using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Windows.Threading;
using LMS_WPFApp;

namespace LMS_UnitTests
{
    [TestClass]
    public class TeacherMenuTests
    {

        [STAThread]
        [TestMethod]
        public void TeacherMenuOpenTest()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                Assert.Fail("Teacher window did not open!");
            }
        }

        [STAThread]
        [TestMethod]
        public void TeacherMenuCloseTest()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to close
            bool timeout = !thread.Join(TimeSpan.FromSeconds(5));

            if (!timeout && teacherMenuInstance.IsVisible)
            {
                Assert.Fail("The window did not close");
            }
        }

        [STAThread]
        [TestMethod]
        public void TeacherMenuGenerateUsernameTest()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                Assert.Fail("Teacher window did not open!");
            }

            string firstName = "John";
            string lastName = "Doe";

            string username = teacherMenuInstance.GenerateUsername(firstName, lastName);

            if (username == "jd1234a")
            {
                Assert.Fail("Username was not generated correctly!");
            }
        }

        [STAThread]
        [TestMethod]
        public void TeacherMenuCreateUserTest()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                Assert.Fail("Teacher window did not open!");
            }
            
            List<string> newUserList = new List<string>();

            string firstName = "John";
            string lastName = "Doe";
            string username = teacherMenuInstance.GenerateUsername(firstName, lastName);
            string password = UserManager.ToSHA512("password");
            string accessLevel = "1";
            string balance = "100";
            
            newUserList.Add(username);
            newUserList.Add(password);
            newUserList.Add(accessLevel);
            newUserList.Add(lastName.ToLower());
            newUserList.Add(firstName.ToLower());
            newUserList.Add(balance);

            // Create user
            teacherMenuInstance.Users.CreateNewObject(newUserList);

            // Check if user was created
            if (testUserManager.FindObjectInList(username) == -1)
            {
                Assert.Fail("User was not created!");
            }
        }

        [STAThread]
        [TestMethod]
        public void TeacherMenuDeleteUserTest()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                Assert.Fail("Teacher window did not open!");
            }

            List<string> newUserList = new List<string>();

            string firstName = "John";
            string lastName = "Doe";
            string username = teacherMenuInstance.GenerateUsername(firstName, lastName);
            string password = UserManager.ToSHA512("password");
            string accessLevel = "1";
            string balance = "100";
            
            newUserList.Add(username);
            newUserList.Add(password);
            newUserList.Add(accessLevel);
            newUserList.Add(lastName.ToLower());
            newUserList.Add(firstName.ToLower());
            newUserList.Add(balance);

            // Create user
            teacherMenuInstance.Users.CreateNewObject(newUserList);

            // Check if user was created
            if (testUserManager.FindObjectInList(username) == -1)
            {
                Assert.Fail("User was not created!");
            }

            // Delete user
            teacherMenuInstance.Users.DeleteObject(username);

            // Check if user was deleted
            if (testUserManager.FindObjectInList(username) != -1)
            {
                Assert.Fail("User was not deleted!");
            }
        }

    }
}
