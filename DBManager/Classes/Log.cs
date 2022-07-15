using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DBManager
{
    /// <summary>
    /// ����� ��� ������� ���� ������ ����������
    /// </summary>
    public class Log
    {
        /// <summary>
        /// ���� � �����-����
        /// </summary>
        private string path;

        /// <summary>
        /// ���� � �����-����
        /// </summary>
        public static string LogPath
        {
            get { return instance.path; }
        }

        // Lock object
        private static object syncLock = new object();

        private static Log instance;
        protected Log(string path, int restrict)
        {
            this.path = path;
        }
        /// <param name="level">������� ������� ����</param>
        /// <param name="path">���� � �����-����</param>
        /// <param name="restrict">����������� �� �������. ����� 0 ��� ������ ��� �����������.</param>
        public static Log Instance(string logPath, int logRestrict)
        {
            // Use 'Lazy initialization' 
            if (instance == null)
            {
                instance = new Log(logPath, logRestrict);
            }

            return instance;
        }

        /// <summary>
        /// �������� ��������� � ���
        /// </summary>
        /// <param name="message">����� ���������</param>
        public static void WriteToLog(string message)
        {
            // ������� ����
            DateTime date = DateTime.Now;

            // ��� �����-����
            string fileName = instance.path;

            lock (syncLock)
            {
                // ���������, ���� ������� ������ ����, ��� ������� �� ����������
                if (true)
                {
                    // ���� ���� ����������
                    if (File.Exists(fileName))
                    {
                        // FIFO
                        Queue<string> queue = new Queue<string>();
                        using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                queue.Enqueue(line);
                            }
                        }

                        // ������� ����
                        File.Delete(fileName);

                        // �������� �� ���������� � ����
                        File.WriteAllLines(fileName, queue.ToArray(), Encoding.Default);

                        // �������� ���������� ���������
                        File.AppendAllText(fileName, string.Format("{0} {1}\r\n", date, message),
                            Encoding.Default);

                    }
                    else
                    {
                        // �������� ������ � ����
                        File.WriteAllText(fileName, string.Format("{0} {1}\r\n", date, message), Encoding.Default);
                    }
                }
            }
        }

        public static String GetWholeText()
        {
            if (File.Exists(instance.path))
            {
                Queue<string> queue = new Queue<string>();
                using (StreamReader sr = new StreamReader(instance.path, Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        queue.Enqueue(line);
                    }
                }
                String result = "";
                foreach (String str in queue.ToArray())
                {
                    result += str + '\n';
                }
                return result;
            }
            else
            {
                return "";
            }
        }
    }
}
