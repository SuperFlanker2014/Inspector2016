using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DBManager.Properties;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;

namespace DBManager
{
    static class Program
    {
        public static bool autoStart = false;

        [STAThread]
        static void Main(string[] args)
        {
            String path = Path.GetDirectoryName(Application.ExecutablePath);
            Log log = Log.Instance(path + @"\Log.txt", 0);

            if ((args.Length > 0) && (args[0] == "update"))
                autoStart = true;

            if ((args.Length > 0) && (args[0] == "updateFiles"))
            {
                //���, ���� ��������� �������� ���������
                try
                {
                    int pid = Convert.ToInt32(args[1]);

                    while (true)
                    {
                        Process p = Process.GetProcessById(pid);

                        if (p == null)
                        {
                            break;
                        }

                        Thread.Sleep(50);
                    }
                }
                catch (Exception ex)
                {
                }

                CopyFiles();
                Process.Start(String.Format("{0}\\Inspector.exe", Application.StartupPath));                
                return;
            }

            if (!SettingsLoader.ConfigFileExist)
            {
                MessageBox.Show("���� Inspector.exe.config �� ������ � ������� �����. \n��������� ����� �������. \n��������� �� ���������.",
                    "���������-������������ ��������� �� � ��� �����");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        
        public static bool CheckConnection(SettingsLoader.DBConnection cn)
        {
            Cursor.Current = Cursors.WaitCursor;
            String res = SettingsLoader.CheckConnectionString(cn);
            Cursor.Current = Cursors.Default;

            if (res != "")
            {
                MessageBox.Show("������ �����������: " + res, "���������", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        public static void SaveConnection(SettingsLoader.DBConnection cn)
        {
            SettingsLoader.SaveConnectionString(cn);
        }

        public static bool UpdateDB()
        {
            Log.WriteToLog("������ ���������� ���������");

            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\update.sql";
            if (!File.Exists(path))
            {
                Log.WriteToLog("�� ������ ���� update.sql");
                return false;
            }
            string newFileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\inspector_new.exe";
            string oldFileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\inspector.exe";
            //string destFileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\inspector_old.exe";
            if (!File.Exists(newFileName))
            {
                Log.WriteToLog("�� ������ ���� inspector_new.exe");
                return false;
            }
            string script = File.ReadAllText(path, Encoding.UTF8);
            SqlScriptHelper.ExecuteScript(new SqlConnection(SettingsLoader.GetConnectionString(SettingsLoader.Connection)), script);
            if (SqlScriptHelper.Errors.Count > 0)
            {
                foreach (string s in SqlScriptHelper.Errors)
                {
                    Log.WriteToLog(s);
                    Log.WriteToLog("; ");
                }
                Log.WriteToLog("������ ��� ���������� ������� � ��");
                SqlScriptHelper.Errors.Clear();
                return false;
            }

            try
            {
                File.Copy(newFileName, oldFileName, true);
                File.Delete(newFileName);
                File.Delete(path);
            }
            catch (Exception exception)
            {
                Log.WriteToLog(exception.Message);
                Log.WriteToLog("������ ��� ������ ����� ��������� �� �����. �������� ��� �������� ���������� ���������.");
                return false;
            }

            Log.WriteToLog(string.Format("��������� ������� ��������� �� ������ {0}", Version()));
            return true;
        }

        public static bool RollbackDB()
        {
            Log.WriteToLog("������ ���������� ���������");
            string destFileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\inspector.exe";
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\inspector_old.exe";
            if (!File.Exists(path))
            {
                Log.WriteToLog("�� ������ ���� inspector_old.exe");
                return false;
            }
            if (!CBackup.Get.RestoreDatabase(Settings.Default.LastBackupPath))
            {
                Log.WriteToLog("������ ��� �������������� ���� ������ �� ��������� �����.");
                return false;
            }
            try
            {
                File.Copy(path, destFileName, true);
                File.Delete(path);
            }
            catch (Exception exception)
            {
                Log.WriteToLog(exception.Message);
                Log.WriteToLog("������ ��� ������ ����� ��������� �� ������. �������� ��� �������� ���������� ���������.");
                return false;
            }
			
            Log.WriteToLog(string.Format("��������� ������� ������������� �� ������ {0}", Version()));
            return true;
        }

        public static String Version()
        {
            return DBManager.Properties.Settings.Default.Version;
        }

        public static void CopyFiles()
        {
            string dir  = String.Format("{0}\\_\\", Application.StartupPath);
            string dirProgram = String.Format("{0}\\", Application.StartupPath);

            if (Directory.Exists(dir))
            {
                string[] files = Directory.GetFiles(dir, "*", SearchOption.AllDirectories);
                string[] filesSql = Directory.GetFiles(dir, "*.sql", SearchOption.AllDirectories);

                //�������� try, ������� � ��������

                foreach (string f in files)
                {
                    if (Path.GetExtension(f) != ".sql")
                    {
                        string newFileName = string.Format("{0}\\{1}", Application.StartupPath, f.Replace(Application.StartupPath, string.Empty).Substring(3));
                        
                        try
                        {
                            File.Copy(f, newFileName, true);
                            File.Delete(f);
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                }

                foreach (string f in filesSql)
                {
                    string script = File.ReadAllText(f, Encoding.UTF8);

                    try
                    {
                        SqlScriptHelper.ExecuteScript(new SqlConnection(SettingsLoader.GetConnectionString(SettingsLoader.Connection)), script);
                        File.Delete(f);
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
            }            
        }
    }
}