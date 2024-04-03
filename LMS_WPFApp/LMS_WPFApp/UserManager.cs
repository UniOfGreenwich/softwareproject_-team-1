using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LMS_WPFApp
{
    public class UserManager : I_SystemObjectManager
    {
        private static readonly string databasePath = "userDatabase.csv";   // change file path here if needed. Needs to be static in deployment
        public List<List<string>>? userList;                                // 2D List of user data populated from database
        public List<string>? tableHeaders;                                  // Database table headers.

        public void OpenDatabaseFile()
        {
            try
            {
                //Console.WriteLine("Opening database file..."); debug 
                using (var reader = new StreamReader(databasePath))
                {
                    userList = new List<List<string>>();
                    tableHeaders = new List<string>();

                    // Reads first line of data into headerLine and splits by ',' to create 1D List<string>
                    if (!reader.EndOfStream)
                    {
                        var headerLine = reader.ReadLine();
                        tableHeaders = headerLine.Split(',').ToList();
                    }

                    // Reads rest of data until end of stream and splits each line into seperate lists. Concatenates values to 2D userList
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        userList.Add(values.ToList());
                    }
                }
                //Console.WriteLine("Database file opened successfully."); debug
            }

            // Error handling! Should probs do some more of this :4head
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("OpenDatabaseFile: Database file not found: " + ex.Message);
                Console.WriteLine("Database file not found: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("OpenDatabaseFile: Error reading the database file: " + ex.Message);
                Console.WriteLine("Error reading the database file: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("OpenDatabaseFile: An error occurred: " + ex.Message);
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public void CloseDatabaseFile()
        {
            // More error handling?! If userList or tableHeaders is empty, nothing to write to database file
            if (userList == null || tableHeaders == null)
            {
                MessageBox.Show("CloseDatabaseFile: No data?");
                return;
            }

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

            //Garbaggio colleczione
            userList = null;
            tableHeaders = null;
        }

        public void CreateNewField(string fieldName)
        {
            // More error handling?! If userList or tableHeaders is empty, nothing to write to database file
            if (userList == null || tableHeaders == null)
            {
                MessageBox.Show("CreateNewField: No data?");
                return;
            }

            // Adds new field to end of table headers and populates userList with empty values in the column at index of new fieldName.
            tableHeaders.Add(fieldName);
            int newFieldIndex = tableHeaders.IndexOf(fieldName);

            foreach (var row in userList)
            {
                row.Insert(newFieldIndex, "");
            }
        }


        public void CreateNewObject(List<string> objectItems)
        {
            // check if objectItems list is empty or values are null. Holy mole i'm on a roll here!
            if (objectItems == null || objectItems.Count == 0 || objectItems[0] == null)
            {
                MessageBox.Show("CreateNewObject: Object item list cannot be null.");
                return;
            }
            string objectName = objectItems[0];

            // Check if an object with the same name already exists
            if (userList.Any(item => item.Count > 0 && item[0] == objectName))
            {
                MessageBox.Show("CreateNewObject: An object with the same name already exists in the user.");
                return;
            }

            // If no issues, add the new object to the userlist
            userList.Add(objectItems);
        }

        public void DeleteField(string fieldName)    //TODO change error handling to argumentexception
        {
            if (tableHeaders == null || userList == null)
            {
                MessageBox.Show("DeleteField: No data?");
                return;
            }

            int deletionIndex = tableHeaders.IndexOf(fieldName);

            if (deletionIndex == -1)
            {
                MessageBox.Show("DeleteField: This field does not exist.");
                return;
            }
            foreach (var row in userList)
            {
                row.RemoveAt(deletionIndex);
            }
            tableHeaders.RemoveAt(deletionIndex);

        }

        public void DeleteObject(string objectName)
        {
            int deletionIndex = FindObjectInList(objectName);
            if (deletionIndex == -1)
            {
                MessageBox.Show("DeleteObject: This object does not exist.");
                return;
            }
            else if (userList == null)
            {
                MessageBox.Show("DeleteObject: No data?");
                return;
            }
            userList.RemoveAt(deletionIndex);
        }

        public void EditObject(string objectName, string editedItem, string fieldName)
        {
            if (FindObjectInList(objectName) == -1 || objectName == null)
            {
                MessageBox.Show("EditObject: does not exist.");
                return;
            }

            if (editedItem == null)
            {
                MessageBox.Show("EditObject: Edited items cannot be null.");
                return;
            }

            if (userList == null)
            {
                MessageBox.Show("EditObject: No data?");
                return;
            }

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

        // Hashing function for password encryption
        public static string ToSHA512(string s)
        {
            // Create a SHA512 hash from the input string
            using (SHA512 sha512 = SHA512.Create())
            {
                // Convert the byte array to a hexadecimal string
                StringBuilder hash = new StringBuilder();
                // Convert the input string to a byte array and compute the hash
                byte[] hashArray = sha512.ComputeHash(Encoding.UTF8.GetBytes(s));
                // Convert the byte array to a hexadecimal string
                foreach (byte b in hashArray)
                {
                    // Append the byte value to the hash string in hexadecimal format
                    hash.Append(b.ToString("x"));
                }
                // Return the hexadecimal string
                return hash.ToString();
            }
        }
    }
}

