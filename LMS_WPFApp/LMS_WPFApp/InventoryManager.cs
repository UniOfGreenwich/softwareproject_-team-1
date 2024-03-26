using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LMS_WPFApp
{
    public class InventoryManager : I_SystemObjectManager
    {
        public List<List<string>>? inventoryList;
        private static readonly string databasePath = "../inventoryDatabase.csv";  //change file path here if needed. Needs to be static in deployment.
        public List<string>? tableHeaders { get; set; }
        public string? title { get; set; }
        public string? author { get; set; }
        public string? description { get; set; }
        public string? iSBN { get; set; }
        public string? totalQuantity { get; set; }
        public string? rentedQuantity { get; set; }

        public void OpenDatabaseFile()
        {
            try
            {
                Console.WriteLine("Opening database file...");
                using (var reader = new StreamReader(databasePath))
                {
                    inventoryList = new List<List<string>>();
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
                        inventoryList.Add(values.ToList());
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
            listToWrite.AddRange(inventoryList.Select(row => string.Join(",", row))); // Add user data rows

            // Write the concatenated list to the file
            using (var writer = new StreamWriter(databasePath))
            {
                foreach (var item in listToWrite)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public void CreateNewField(string fieldName, List<List<string>> inventoryList)
        {
            tableHeaders.Add(fieldName);
            foreach (var row in inventoryList)
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
            if (inventoryList.Any(item => item.Count > 0 && item[0] == objectName))
            {
                throw new ArgumentException("An object with the same name already exists in the inventory.");
            }

            // If no issues, add the new object to the inventory
            inventoryList.Add(objectItems);
        }

        public void DeleteField(string fieldName)
        {
            int deletionIndex = tableHeaders.IndexOf(fieldName);

            if (deletionIndex != -1)
            {
                foreach (var row in inventoryList)
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

        public void DeleteObject(string objectName)
        {
            inventoryList.RemoveAt(FindObjectInList(objectName));
        }

        public List<string> GetObjectInfo(string objectName)
        {
            return inventoryList[FindObjectInList(objectName)];    
        }

        public void EditObject(string objectName, string editedItem, string fieldName)
        {
            //if(FindObjectInList(objectName) == -1 || objectName != null)
            //{
            //    throw new ArgumentNullException("EditObject", "Object not found in table.");
            //}

            //if(editedItem == null)
            //{
            //    throw new ArgumentNullException("EditObject", "Edited items cannot be null");
            //}

            // do as normal if no errors
            int objectIndex = FindObjectInList(objectName);
            int fieldIndex = FindFieldNameInList(fieldName);
            inventoryList[objectIndex].RemoveAt(fieldIndex);
            inventoryList[objectIndex].Insert(fieldIndex, editedItem);
        }

        private int FindObjectInList(string objectName)
        {
            List<string> objectNameColumn = new List<string>();
            for (int i = 0; i < inventoryList.Count; i++)
            {
                objectNameColumn.Add(inventoryList[i][0]);
            }
            return objectNameColumn.FindIndex(name => name == objectName);
        }

        public string GetSpecificObjectData(string objectName, string fieldName)
        {
            int specificIndex = tableHeaders.IndexOf(fieldName);
            return inventoryList[FindObjectInList(objectName)][specificIndex];
        }
        public List<string> GetObjectsFromField(string fieldName)
        {
            return inventoryList[FindFieldNameInList(fieldName)];
        }
        public int FindFieldNameInList(string fieldName)
        {
            List<string> fieldNameColumn = new List<string>();
            for (int i = 0; i < inventoryList.Count; i++)
            {
                fieldNameColumn.Add(inventoryList[0][i]);
            }

            if (fieldNameColumn.FindIndex(name => name == fieldName) == -1)
            {
                //throw new ArgumentNullException("FindObjectInList", "Item does not exist!");
                return -1;
            }

            return fieldNameColumn.FindIndex(name => name == fieldName);
        }
    }
}
