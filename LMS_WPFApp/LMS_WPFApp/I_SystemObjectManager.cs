using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WPFApp
{
    internal interface I_SystemObjectManager
    {
        void OpenDatabaseFile();
        void CloseDatabaseFile(List<List<string>> inventoryList);
        void CreateNewObject(List<string> objectItems);
        void EditObject(string objectName, List<string> editedItems);
        void DeleteObject(string objectName);
        void CreateNewField(string fieldName, List<List<string>> inventoryList);
        void DeleteField(string fieldName);
        List<string> GetObjectInfo(string objectName);
    }
}
