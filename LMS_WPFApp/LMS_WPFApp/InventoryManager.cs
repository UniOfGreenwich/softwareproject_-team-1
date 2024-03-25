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
            using (var reader = new StreamReader(databasePath))
            {
                this.inventoryList = new List<List<string>>();
                this.tableHeaders = new List<string>();
                while (!reader.EndOfStream)
                {
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
        }
        void I_SystemObjectManager.CloseDatabaseFile(List<List<string>> inventoryList)
        {
            string inventoryString;
            string rowString;

            using (var writer = new StreamWriter(databasePath))
            {
                foreach (var row in inventoryList)
                {
                    foreach (var value in row)
                    {
                        string valueString = value.ToString();
                        rowString += (',' + valueString);
                    }
                    inventoryString += rowString + '\n';
                }
                writer.Write(inventoryString);
                writer.Close();
            }
        }

        void I_SystemObjectManager.CreateNewField(string fieldName, List<List<string>> inventoryList)
        {
            tableHeaders.Add(fieldName);
            foreach (var row in inventoryList)
            {
                row.Add("");
            }
        }

        void I_SystemObjectManager.CreateNewObject(string objectName)
        {
            tableHeaders.ForEach(tableHeaders.Add();

        }

        void I_SystemObjectManager.DeleteField(string fieldName)
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.DeleteObject(string objectName)
        {
            throw new NotImplementedException();
        }

        object I_SystemObjectManager.GetFieldContents(string fieldName)
        {
            inventoryList.Find(fieldName);
        }

        void I_SystemObjectManager.EditObject(string objectName, List<string> editedItems)
        {
            try
            {
                int foundIndex = inventoryList.FindIndex(objectName);
                inventoryList.RemoveAt(foundIndex);
                inventoryList.Insert(foundIndex, editedItems);
            }
            catch
            {
                throw new Exception("Object not found!");
            }
        }
    }
}
