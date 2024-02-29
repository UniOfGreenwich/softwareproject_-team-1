using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WPFApp
{
    public class InventoryManager : I_SystemObjectManager
    {
        private List<List<string>>? inventoryList;
        private static string databasePath = "C:/Data/InventoryDatabase.csv";  //change file path here if needed. Needs to be static in deployment.
        private List<string> headers { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public string? ISBN {  get; set; }
        public string? TotalQuantity { get; set; }
        public string? RentedQuantity { get; set; }

        void I_SystemObjectManager.OpenDatabaseFile()
        {
            using(var reader = new StreamReader(databasePath))
            {
                this.inventoryList = new List<List<string>>();
                this.headers = new List<string>();
                while(!reader.EndOfStream)
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
            this.headers = inventoryList[0];
        }
        void I_SystemObjectManager.CloseDatabaseFile(List<List<string>> inventoryList)
        {
            string inventoryString = '';
            string rowString = '';
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
            
            headers.Add(fieldName);
            foreach (var row in inventoryList)
            {
                row.Add(null);
            }
        }

        void I_SystemObjectManager.CreateNewObject(string objectName)
        {
            List<string> headers = 
            
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
            throw new NotImplementedException();
        }

        string I_SystemObjectManager.GetObjectName()
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.SetObjectName(string objectName)
        {
            throw new NotImplementedException();
        }
    }
}
