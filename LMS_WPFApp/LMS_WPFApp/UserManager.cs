using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WPFApp
{
    internal class UserManager : I_SystemObjectManager
    {
        private static readonly string databasePath = "C:/Data/UserDatabase.csv";  //change file path here if needed. Needs to be static in deployment.
        private List<List<string>>? userList;
        private List<string>? tableHeaders { get; set; }

        void I_SystemObjectManager.OpenDatabaseFile()
        {
            // open file using StreamReader class
            using (var reader = new StreamReader(databasePath))
            {
                // create string list for storing file data
                this.userList = new List<List<string>>();
                // create header list for column headers
                this.tableHeaders = new List<string>();
                while (!reader.EndOfStream)
                {
                    // splits values from file by commas
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    List<string> rowValues = new List<string>();

                    foreach (var value in values)
                    {
                        rowValues.Add(value);
                    }
                    this.userList.Add(rowValues);
                }
                reader.Close();
            }
            this.tableHeaders = userList[0];
            userList.RemoveAt(0);
        }
        void I_SystemObjectManager.CloseDatabaseFile(List<List<string>> inventoryList)
        {
            List<string> rowStringList = new List<string>();
            using (var writer = new StreamWriter(databasePath))
            {
                foreach (var row in inventoryList)
                {
                    string rowCommaString = String.Join(",", row);
                    rowStringList.Add(rowCommaString);
                }
                string inventoryString = String.Join("\n", rowStringList);
                writer.Write(inventoryString);
                writer.Close();
            }
        }

        void I_SystemObjectManager.CreateNewField(string fieldName, List<List<string>> inventoryList)
        {
            tableHeaders.Add(fieldName);
            foreach (var row in inventoryList)
            {
                row.Insert((row.Count() + 1), "");
            }
        }

        void I_SystemObjectManager.CreateNewObject(List<string> objectItems)
        {
            // check if objectItems list is empty or values are null
            if (objectItems == null || objectItems.Count == 0 || objectItems[0] == null)
            {
                throw new ArgumentNullException("CreateNewObject", "Object item list cannot be null");
            }
            string objectName = objectItems[0];

            // Check if an object with the same name already exists
            if (userList.Any(item => item.Count > 0 && item[0] == objectName))
            {
                throw new ArgumentException("An object with the same name already exists in the inventory.");
            }

            // If no issues, add the new object to the inventory
            userList.Add(objectItems);
        }

        void I_SystemObjectManager.DeleteField(string fieldName)    //TODO change error handling to argumentexception
        {
            int deletionIndex = tableHeaders.IndexOf(fieldName);

            if (deletionIndex != -1)
            {
                foreach (var row in userList)
                {
                    row.RemoveAt(deletionIndex);
                    //this.inventoryList.Insert(inventoryList.IndexOf(row), row);
                }
                tableHeaders.RemoveAt(deletionIndex);
            }
            else
            {
                //item does not exist for deletion
            }
        }

        void I_SystemObjectManager.DeleteObject(string objectName)
        {
            userList.RemoveAt(FindObjectInList(objectName));
        }

        void I_SystemObjectManager.EditObject(string objectName, List<string> editedItems)
        {
            if (FindObjectInList(objectName) == -1 || objectName != null)
            {
                throw new ArgumentNullException("EditObject", "Object not found in table.");
            }

            if (editedItems == null)
            {
                throw new ArgumentNullException("EditObject", "Edited items cannot be null");
            }

            // do as normal if no errors
            int foundIndex = FindObjectInList(objectName);
            userList.RemoveAt(foundIndex);
            userList.Insert(foundIndex, editedItems);
        }

        List<string> I_SystemObjectManager.GetObjectInfo(string objectName)
        {
            return userList[FindObjectInList(objectName)];
        }

        public int FindObjectInList(string objectName)
        {
            List<string> objectNameColumn = new List<string>();
            for (int i = 0; i < userList.Count; i++)
            {
                objectNameColumn.Add(userList[i][0]);
            }

            if (objectNameColumn.FindIndex(name => name == objectName) == -1)
            {
                throw new ArgumentNullException("FindObjectInList", "Item does not exist!");
            }

            return objectNameColumn.FindIndex(name => name == objectName);
        }

        public string GetSpecificObjectData(string objectName, string fieldName)
        {
            int specificIndex = tableHeaders.IndexOf(fieldName);
            if (specificIndex == -1)
            {
                throw new ArgumentNullException("GetSpecificObjectData", "Field name does not exist!");
            }

            return userList[FindObjectInList(objectName)][specificIndex];
        }
    }
}
