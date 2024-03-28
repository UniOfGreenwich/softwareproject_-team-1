using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WPFApp
{
    public class UserManager : I_SystemObjectManager
    {
        private static readonly string databasePath = "userDatabase.csv";  //change file path here if needed. Needs to be static in deployment.
        public List<List<string>>? userList;
        public List<string>? tableHeaders { get; set; }

        public void OpenDatabaseFile()
        {
            try
            {
                Console.WriteLine("Opening database file...");
                using (var reader = new StreamReader(databasePath))
                {
                    userList = new List<List<string>>();
                    tableHeaders = new List<string>();

                    if (!reader.EndOfStream)
                    {
                        var headerLine = reader.ReadLine();
                        tableHeaders = headerLine.Split(',').ToList();
                    }

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        userList.Add(values.ToList());
                    }
                }
                Console.WriteLine("Database file opened successfully.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Database file not found: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading the database file: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public void CloseDatabaseFile()
        {
            // Concatenate tableHeaders and userList
            List<string> listToWrite = new List<string>();
            listToWrite.Add(string.Join(",", tableHeaders)); // Add header row
            listToWrite.AddRange(userList.Select(row => string.Join(",", row))); // Add user data rows

            // Write the concatenated list to the file
            using (var writer = new StreamWriter(databasePath))
            {
                foreach (var item in listToWrite)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public void CreateNewField(string fieldName, List<List<string>> userList)
        {
            tableHeaders.Add(fieldName);
            foreach (var row in userList)
            {
                row.Insert((row.Count() + 1), "");
            }
        }

        public void CreateNewObject(List<string> objectItems)
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
                throw new ArgumentException("An object with the same name already exists in the user.");
            }

            // If no issues, add the new object to the userlist
            userList.Add(objectItems);
        }

        public void DeleteField(string fieldName)    //TODO change error handling to argumentexception
        {
            int deletionIndex = tableHeaders.IndexOf(fieldName);

            if (deletionIndex != -1)
            {
                foreach (var row in userList)
                {
                    row.RemoveAt(deletionIndex);
                }
                tableHeaders.RemoveAt(deletionIndex);
            }
            else
            {
                //item does not exist for deletion
            }
        }

        public void DeleteObject(string objectName)
        {
            userList.RemoveAt(FindObjectInList(objectName));
        }

        public void EditObject(string objectName, string editedItem, string fieldName)
        {
            //if (FindObjectInList(objectName) == -1 || objectName != null)
            //{
            //    throw new ArgumentNullException("EditObject", "Object not found in table.");
            //}

            //if (editedItem == null)
            //{
            //    throw new ArgumentNullException("EditObject", "Edited items cannot be null");
            //}

            // do as normal if no errors
            int objectIndex = FindObjectInList(objectName);
            int fieldIndex = FindFieldNameInList(fieldName);
            userList[objectIndex].RemoveAt(fieldIndex);
            userList[objectIndex].Insert(fieldIndex,editedItem);
        }

        public List<string> GetObjectInfo(string objectName)
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
                //throw new ArgumentNullException("FindObjectInList", "Item does not exist!");
                return -1;
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
        public int FindFieldNameInList(string fieldName)
        {
            // Get the first row of userList to represent column names
            List<string> fieldNames = tableHeaders;

            // Find the index of the fieldName in the fieldNames list
            return fieldNames.IndexOf(fieldName);
        }
        public List<string> GetObjectsFromField(string fieldName)
        {
            int fieldIndex = FindFieldNameInList(fieldName);
            List<string> objectsFromField = new List<string>();

            for (int i = 0; i < userList.Count; i++)
            {
                // Add the object from the specified field in the current row to the list
                objectsFromField.Add(userList[i][fieldIndex]);
            }
            return objectsFromField;
        }
        public static string ToSHA512(string s)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                StringBuilder hash = new StringBuilder();
                byte[] hashArray = sha512.ComputeHash(Encoding.UTF8.GetBytes(s));
                foreach (byte b in hashArray)
                {
                    hash.Append(b.ToString("x"));
                }
                return hash.ToString();
            }
        }
    }
}
