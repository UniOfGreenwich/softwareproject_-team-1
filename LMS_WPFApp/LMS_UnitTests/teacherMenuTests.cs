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
    }
}
