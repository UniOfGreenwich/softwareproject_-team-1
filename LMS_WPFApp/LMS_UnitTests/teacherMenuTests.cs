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

        // Test to see if the teacher menu opens
        [STAThread]
        [TestMethod]
        public void TeacherMenuOpenTest()
        {
            // Create instances of the UserManager and InventoryManager
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            // Create an instance of the teacherMenu
            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                // Create the teacherMenu instance
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                // Run the dispatcher
                System.Windows.Threading.Dispatcher.Run();
            });

            // Set the apartment state and start the thread
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            // Check if the window opened
            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                // Fail the test if the window did not open
                Assert.Fail("Teacher window did not open!");
            }
        }

        // Test to see if the teacher menu closes
        [STAThread]
        [TestMethod]
        public void TeacherMenuCloseTest()
        {
            // Create instances of the UserManager and InventoryManager
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            // Create an instance of the teacherMenu
            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                // Create the teacherMenu instance
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                // Run the dispatcher
                System.Windows.Threading.Dispatcher.Run();
            });

            // Set the apartment state and start the thread
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to close
            bool timeout = !thread.Join(TimeSpan.FromSeconds(5));

            // Check if the window closed
            if (!timeout && teacherMenuInstance.IsVisible)
            {
                // Fail the test if the window did not close
                Assert.Fail("The window did not close");
            }
        }

        // Test to see if the teacher menu generates a username
        [STAThread]
        [TestMethod]
        public void TeacherMenuGenerateUsernameTest()
        {
            // Create instances of the UserManager and InventoryManager
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            // Create an instance of the teacherMenu
            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                // Create the teacherMenu instance
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                // Run the dispatcher
                System.Windows.Threading.Dispatcher.Run();
            });

            // Set the apartment state and start the thread
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            // Check if the window opened
            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                // Fail the test if the window did not open
                Assert.Fail("Teacher window did not open!");
            }

            // Test the GenerateUsername method
            string firstName = "John";
            string lastName = "Doe";
            string username = teacherMenuInstance.GenerateUsername(firstName, lastName);

            // Check if the username was generated correctly
            if (username == "jd1234a")
            {
                // Fail the test if the username was not generated correctly
                Assert.Fail("Username was not generated correctly!");
            }
        }

        // Test to see if the teacher menu creates a user
        [STAThread]
        [TestMethod]
        public void TeacherMenuCreateUserTest()
        {
            // Create instances of the UserManager and InventoryManager
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            // Create an instance of the teacherMenu
            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                // Create the teacherMenu instance
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                // Run the dispatcher
                System.Windows.Threading.Dispatcher.Run();
            });

            // Set the apartment state and start the thread
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            // Check if the window opened
            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                // Fail the test if the window did not open
                Assert.Fail("Teacher window did not open!");
            }
            
            // Create a list of user data
            List<string> newUserList = new List<string>();

            // Set the user data
            string firstName = "John";
            string lastName = "Doe";
            string username = teacherMenuInstance.GenerateUsername(firstName, lastName);
            string password = UserManager.ToSHA512("password");
            string accessLevel = "1";
            string balance = "100";
            
            // Add the user data to the list
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
                // Fail the test if the user was not created
                Assert.Fail("User was not created!");
            }
        }

        // Test to see if the teacher menu deletes a user
        [STAThread]
        [TestMethod]
        public void TeacherMenuDeleteUserTest()
        {
            // Create instances of the UserManager and InventoryManager
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            // Create an instance of the teacherMenu
            teacherMenu teacherMenuInstance = null;

            // Instantiate the teacherMenu on the UI thread
            var thread = new Thread(() =>
            {
                // Create the teacherMenu instance
                teacherMenuInstance = new teacherMenu(testUserManager, testInventoryManager);
                teacherMenuInstance.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            // Set the apartment state and start the thread
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            // Check if the window opened
            if (!windowOpened && !teacherMenuInstance.IsVisible)
            {
                // Fail the test if the window did not open
                Assert.Fail("Teacher window did not open!");
            }

            // Create a list of user data
            List<string> newUserList = new List<string>();

            // Set the user data
            string firstName = "John";
            string lastName = "Doe";
            string username = teacherMenuInstance.GenerateUsername(firstName, lastName);
            string password = UserManager.ToSHA512("password");
            string accessLevel = "1";
            string balance = "100";
            
            // Add the user data to the list
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
                // Fail the test if the user was not created
                Assert.Fail("User was not created!");
            }

            // Delete user
            teacherMenuInstance.Users.DeleteObject(username);

            // Check if user was deleted
            if (testUserManager.FindObjectInList(username) != -1)
            {
                // Fail the test if the user was not deleted
                Assert.Fail("User was not deleted!");
            }
        }

    }
}
