using LMS_WPFApp;
using System.Windows;

namespace LMS_UnitTests
{
    [TestClass]
    public class LoginScreenTests
    {
        private const string DatabasePath = "userDatabase.csv";

        [TestMethod]
        public void LoginUserPass()
        {
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            string username = "jd1234a";
            string password = UserManager.ToSHA512("password123");

            if (testUserManager.FindObjectInList(username) == -1)
            {
                Assert.Fail();
            }

            // Checks if password is null or password is not equal to value returned from database.
            if (password == null || password != testUserManager.GetSpecificObjectData(username, "password"))
            {
                Assert.Fail();
            }

        }
    }
}