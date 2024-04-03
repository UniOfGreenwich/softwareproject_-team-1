using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMS_WPFApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Security.AccessControl;

namespace LMS_UnitTests
{
    [TestClass()]
    public class UserManagerTests
    {
        //public List<List<string>>? userList;
       // public List<string>? tableHeaders { get; set; }

        [TestMethod()]
        public void OpenDatabaseFileTest()
        {

            // Arrange: Create an instance of UserManager
            UserManager userManager = new UserManager();

            // Act: Open the test database file
            userManager.OpenDatabaseFile();

            // Assert: Check if userList and tableHeaders are not null
            Assert.IsNotNull(userManager.userList, "User list should not be null after opening the database file");
            Assert.IsNotNull(userManager.tableHeaders, "Table headers should not be null after opening the database file");


        }

        [TestMethod()]
        public void CloseDatabaseFileTest()
        {
            UserManager userManager = new UserManager();

            userManager.OpenDatabaseFile();

            //Act: Close the database file 
            userManager.CloseDatabaseFile();

            // Assert: Check if userList and tableHeaders are null after closing the database file
            Assert.IsNull(userManager.userList, "User list should be null after closing the database file");
            Assert.IsNull(userManager.tableHeaders, "Table headers should be null after closing the database file");
        }

        [TestMethod()]
        public void CreateNewFieldTest()
        {

            // Arrange: Create an instance of UserManager
            UserManager userManager = new UserManager();

            userManager.OpenDatabaseFile();

            // Act: Create a new field
            userManager.CreateNewField("email");

            // Assert: Check if the new field has been added to tableHeaders
            CollectionAssert.Contains(userManager.tableHeaders, "email", "New field should be added to tableHeaders");

            // Assert: Check if each user in userList has an empty value for the new field
            foreach (var user in userManager.userList)
            {
                Assert.AreEqual("", user.Last(), "New field should have an empty value for each user");
            }

            userManager.CloseDatabaseFile();

        }

        [TestMethod()]
        public void CreateNewObjectTest()
        {

            // Arrange: Create an instance of UserManager
            UserManager userManager = new UserManager();

           userManager.OpenDatabaseFile();

           userManager.DeleteObject("xy1234z");

            // Scenario 1: Adding an object to an existing userList
            List<string> newObject = new List<string>() { "xy1234z", "newpassword1", "1", "Dev", "John", "2.0" };
            // Act: Add the new object
            userManager.CreateNewObject(newObject);

            // Assert: Check if the new object has been added to userList
            CollectionAssert.Contains(userManager.userList, newObject, "New object should be added to userList");

            userManager.CloseDatabaseFile();
        }

        [TestMethod()]
        public void EditObjectTest()
        {
            // Arrange: Create an instance of UserManager
            UserManager userManager = new UserManager();

            userManager.OpenDatabaseFile();

            string username = "xy1234z";
            string hashedPassword = UserManager.ToSHA512("newpassword1");

            //Act
            if(userManager.FindObjectInList(username) == -1)
            {
                Assert.Inconclusive("Object not found in list. Aborting test.");
            }
          
            userManager.EditObject(username,hashedPassword, "password");

            if(userManager.GetSpecificObjectData(username, "password") != hashedPassword)
            {
                Assert.Fail("Object was not edited correctly");
            }

            userManager.CloseDatabaseFile();
        }

    }
}