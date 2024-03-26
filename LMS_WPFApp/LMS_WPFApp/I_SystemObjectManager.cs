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
        void CloseDatabaseFile();
        public void CreateNewObject(List<string> objectItems);
        void EditObject(string objectName, string editedItem, string fieldName);
        void DeleteObject(string objectName);
        void CreateNewField(string fieldName, List<List<string>> objectList);
        void DeleteField(string fieldName);
        List<string> GetObjectInfo(string objectName);
        string GetSpecificObjectData(string objectName, string fieldName);
        List<string> GetObjectsFromField(string fieldName);
    }
}
