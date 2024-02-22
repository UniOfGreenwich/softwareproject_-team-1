using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WPFApp
{
    internal class InventoryManager : ISystemObjectManager
    {
        void ISystemObjectManager.CreateNewField(string fieldName, object fieldValue)
        {
            throw new NotImplementedException();
        }

        void ISystemObjectManager.CreateNewObject(string objectName)
        {
            throw new NotImplementedException();
        }

        void ISystemObjectManager.DeleteField(string fieldName)
        {
            throw new NotImplementedException();
        }

        void ISystemObjectManager.DeleteObject(string objectName)
        {
            throw new NotImplementedException();
        }

        object ISystemObjectManager.GetFieldContents(string fieldName)
        {
            throw new NotImplementedException();
        }

        string ISystemObjectManager.GetObjectName()
        {
            throw new NotImplementedException();
        }

        void ISystemObjectManager.SetObjectName(string objectName)
        {
            throw new NotImplementedException();
        }
    }
}
