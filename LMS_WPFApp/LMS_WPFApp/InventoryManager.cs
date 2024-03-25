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
        private List<List<string>>? inventoryList;
        private static readonly string databasePath = "C:/Data/InventoryDatabase.csv";  //change file path here if needed. Needs to be static in deployment.
        private List<string>? tableHeaders { get; set; }
        public string? title { get; set; }
        public string? author { get; set; }
        public string? description { get; set; }
        public string? iSBN { get; set; }
        public string? totalQuantity { get; set; }
        public string? rentedQuantity { get; set; }

        void I_SystemObjectManager.OpenDatabaseFile()
        {
            // open file using StreamReader class
            using (var reader = new StreamReader(databasePath))
            {
                // create string list for storing file data
                this.inventoryList = new List<List<string>>();
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
                    this.inventoryList.Add(rowValues);
                }
                reader.Close();
            }
            this.tableHeaders = inventoryList[0];
            inventoryList.RemoveAt(0);
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
            if (inventoryList.Any(item => item.Count > 0 && item[0] == objectName))
            {
                throw new ArgumentException("An object with the same name already exists in the inventory.");
            }

            // If no issues, add the new object to the inventory
            inventoryList.Add(objectItems);
        }

        void I_SystemObjectManager.DeleteField(string fieldName)
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

        void I_SystemObjectManager.DeleteObject(string objectName)
        {
            inventoryList.RemoveAt(FindObjectInList(objectName));
        }

        List<string> I_SystemObjectManager.GetObjectInfo(string objectName)
        {
            return inventoryList[FindObjectInList(objectName)];    
        }

        void I_SystemObjectManager.EditObject(string objectName, List<string> editedItems)
        {
            if(FindObjectInList(objectName) == -1 || objectName != null)
            {
                throw new ArgumentNullException("EditObject", "Object not found in table.");
            }

            if(editedItems == null)
            {
                throw new ArgumentNullException("EditObject", "Edited items cannot be null");
            }

            // do as normal if no errors
            int foundIndex = FindObjectInList(objectName);
            inventoryList.RemoveAt(foundIndex);
            inventoryList.Insert(foundIndex, editedItems);

        }
        int FindObjectInList(string objectName)
        {
            List<string> objectNameColumn = new List<string>();
            for (int i = 0; i < inventoryList.Count; i++)
            {
                objectNameColumn.Add(inventoryList[i][0]);
            }
            return objectNameColumn.FindIndex(name => name == objectName);
        }
    }
}
