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
        void CloseDatabaseFile(string databaseName);
        void CreateNewObject(string objectName);
        void DeleteObject(string objectName);
        void CreateNewField(string fieldName, object fieldValue);
        void DeleteField(string fieldName);
        string GetObjectName();
        void SetObjectName(string objectName);
        object GetFieldContents(string fieldName);
    }
}
