using System;
using System.IO;
using System.Configuration;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace DBManager
{
    public static class SettingsLoader
    {
        private const String name = "Inspector.My.MySettings.DBConnectionString";
        private const String conStringPattern = "Data Source={0};Initial Catalog=InspectorDB;Persist Security Info=True;User ID={1};Password={2}";
        
        private static Regex reg_server = new Regex(@"Data Source=(?<server>\S+);");
        private static Regex reg_user = new Regex(@"User ID=(?<user>\S+);Password");
        private static Regex reg_password = new Regex(@"Password=(?<password>\S+$|\S+(?=;))");

        private static String filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Inspector.exe";
        private static Configuration configFile;
        private static ConnectionStringSettings conStringSettings;
        private static ConnectionStringsSection conStringsSection;
        private static DBConnection con;        

        public struct DBConnection
        {
            public String server, user, password;
        }

        static SettingsLoader()
        {
            if (ConfigFileExist)
            {
                configFile = ConfigurationManager.OpenExeConfiguration(filePath);
                conStringsSection = configFile.ConnectionStrings;
                conStringSettings = conStringsSection.ConnectionStrings[name];
                String conString = conStringSettings.ConnectionString;

                con.server = reg_server.Match(conString).Groups["server"].Value;
                con.user = reg_user.Match(conString).Groups["user"].Value;
                con.password = reg_password.Match(conString).Groups["password"].Value;
            }
        }

        public static bool ConfigFileExist
        {
            get
            {
                return File.Exists(filePath) && File.Exists(filePath + ".config");
            }
        }
               
        public static DBConnection Connection
        {
            get
            {
                return con;
            }
        }

        public static String CheckConnectionString(DBConnection cn)
        {
            try
            {
                String s = GetConnectionString(cn);
                SqlConnection c = new SqlConnection(s);
                c.Open();
                c.Close();
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            return "";
        }

        public static void SaveConnectionString(DBConnection cn)
        {
            String s = GetConnectionString(cn);
            ConnectionStringSettings css = new ConnectionStringSettings(name, s);
            conStringsSection.ConnectionStrings.Clear();
            conStringsSection.ConnectionStrings.Add(css);
            configFile.Save(ConfigurationSaveMode.Full);
        }

        public static String GetConnectionString(DBConnection cn)
        {
            return String.Format(conStringPattern, cn.server, cn.user, cn.password);
        }

        public static bool askUser
        {
            get
            {
                ClientSettingsSection inspectorSettings = (ClientSettingsSection)configFile.SectionGroups["applicationSettings"].Sections["Inspector.My.MySettings"];
                SettingElement se = inspectorSettings.Settings.Get("askUser");
				return se?.Value.ValueXml.InnerXml == "True";
			}
            set
            {
                ClientSettingsSection inspectorSettings = (ClientSettingsSection)configFile.SectionGroups["applicationSettings"].Sections["Inspector.My.MySettings"];
                SettingElement se = inspectorSettings.Settings.Get("askUser");
				se.Value.ValueXml.InnerXml = value ? "True" : "False";
				inspectorSettings.Settings.Clear();
				inspectorSettings.Settings.Add(se);
				configFile.Save(ConfigurationSaveMode.Full);
			}
        }

		public static bool allowEditUnits
		{
			get
			{
				ClientSettingsSection inspectorSettings = (ClientSettingsSection)configFile.SectionGroups["applicationSettings"].Sections["Inspector.My.MySettings"];
				SettingElement se = inspectorSettings.Settings.Get("allowEditUnits");
				return se?.Value.ValueXml.InnerXml == "True";
			}
			set
			{
				ClientSettingsSection inspectorSettings = (ClientSettingsSection)configFile.SectionGroups["applicationSettings"].Sections["Inspector.My.MySettings"];
				SettingElement se = inspectorSettings.Settings.Get("allowEditUnits");
				se.Value.ValueXml.InnerXml = value ? "True" : "False";
				inspectorSettings.Settings.Clear();
				inspectorSettings.Settings.Add(se);
				configFile.Save(ConfigurationSaveMode.Full);
			}
		}
	}
}
