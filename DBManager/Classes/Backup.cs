using System;
using System.Data;
using System.Data.SqlClient;
using DBManager.Properties;

namespace DBManager
{
    class CBackup
    {
        private static CBackup instance;
        public static CBackup Get
        {
            get
            {
                if (instance == null)
                {
                    instance = new CBackup();
                }
                return instance;
            }
        }

        public bool BackupDatabase()
        {
            string backupPath = Settings.Default.BackupPath;
            return this.BackupDatabase(backupPath);
        }

        public bool BackupDatabase(string BackupPath)
        {
            string commandText = "BACKUP DATABASE [InspectorDB] TO DISK = @file_name WITH FORMAT;";
            return this.ExecCommand(commandText, BackupPath);
        }

        public bool RestoreDatabase()
        {
            string backupPath = Settings.Default.BackupPath;
            return this.RestoreDatabase(backupPath);
        }

        public bool RestoreDatabase(string BackupPath)
        {
            string commandText = "BACKUP LOG [InspectorDB] TO DISK = @file_name WITH NORECOVERY; RESTORE DATABASE [InspectorDB] FROM DISK = @file_name WITH RECOVERY;";
            return this.ExecCommand(commandText, BackupPath);
        }

        private bool ExecCommand(string commandText, string BackupPath)
        {
            using (SqlConnection connection = new SqlConnection(SettingsLoader.GetConnectionString(SettingsLoader.Connection).Replace("InspectorDB", "master")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = commandText;
                command.Parameters.Add("file_name", SqlDbType.NVarChar).Value = BackupPath;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException exception)
                {
                    Log.WriteToLog(exception.Message);
                    return false;
                }
                catch (Exception exception2)
                {
                    Log.WriteToLog(exception2.Message);
                    return false;
                }
                return true;
            }
        }
    }
}