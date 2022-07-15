using System;
using System.Reflection;
using System.IO;

namespace DBManager
{
    public class InspectorLoader
    {
        private String filePath;
        private PropertyInfo connectionInfo;
        private object connectionInstance;

        public InspectorLoader(String path)
        {
            filePath = path;
            Assembly inspector = Assembly.LoadFile(filePath);
            connectionInstance = inspector.CreateInstance("Inspector.settings");
            connectionInfo = inspector.GetType("Inspector.settings").GetProperty("DBConnectionString");
        }

        public String DBConnectionString
        {
            get
            {
                return (String)connectionInfo.GetValue(connectionInstance, new object[] { });
            }
        }
        
    }
}
