using LMS_WPFApp;
using System.Windows;

namespace LMS_UnitTests
{
    [TestClass]
    public class LoginScreenTests
    {
        [TestMethod]
        public void LoginUserPass()
        {
            UserManager mockUserManager = new UserManager();
            string username = "jd1234a";
            string password = UserManager.ToSHA512("bed4efa1d4fdbd954bd3705d6a2a7827ec9a52ecfbfb010c61862af5c76af1761ffeb1aef6aca1bf5d02b3781aa854fabd2b69c79de74e17ecfec3cb6ac4bf");

            if (mockUserManager.FindObjectInList(username) == -1)
            {
                Assert.Fail();
            }

            // Checks if password is null or password is not equal to value returned from database.
            if (password == null || password != mockUserManager.GetSpecificObjectData(username, "password"))
            {
                Assert.Fail();
            }

        }
    }
}