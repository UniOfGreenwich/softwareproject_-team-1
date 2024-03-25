using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WPFApp
{
    internal class UserManager : I_SystemObjectManager
    {
        void I_SystemObjectManager.CloseDatabaseFile(List<List<string>> inventoryList)
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.CreateNewField(string fieldName, List<List<string>> inventoryList)
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.CreateNewObject(List<string> objectItems)
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.DeleteField(string fieldName)
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.DeleteObject(string objectName)
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.EditObject(string objectName, List<string> editedItems)
        {
            throw new NotImplementedException();
        }

        List<string> I_SystemObjectManager.GetObjectInfo(string objectName)
        {
            throw new NotImplementedException();
        }

        void I_SystemObjectManager.OpenDatabaseFile()
        {
            throw new NotImplementedException();
        }
    }
}
