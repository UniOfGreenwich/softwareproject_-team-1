using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WPFApp
{
    internal interface I_SystemObjectManager
    {
        void OpenDatabaseFile();                                                    // Opens the database file based on the static path set in the class itself.
        void CloseDatabaseFile();                                                   // Writes the data from the object list in memory to the database file then throws away the reference after writing and closing file.
        public void CreateNewObject(List<string> objectItems);                      // Creates new object based on parameters passed into the method. Item order must be strict with the database file standard.
        void EditObject(string objectName, string editedItem, string fieldName);    // Removes and replaces the field item based on objectName and fieldName provided. editedItem is item to be inserted.
        void DeleteObject(string objectName);                                       // Deletes the object based on the objectName passed into the method.
        void CreateNewField(string fieldName);                                      // Creates a new field in the database file. Needed in case a new field is wanted by the customer eg. book location
        void DeleteField(string fieldName);                                         // Deletes a field in database based on fieldName parameter.
        List<string> GetObjectInfo(string objectName);                              // Gets all object info from database as a List<string> from objectName. (Row data)
        string GetSpecificObjectData(string objectName, string fieldName);          // Gets a specific field from object info in database and returns as string.
        List<string> GetObjectsFromField(string fieldName);                         // Gets all field data as List<string> from database. (Column data)
    }
}
