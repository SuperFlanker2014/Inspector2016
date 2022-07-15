using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DBManager
{
    /// <summary>
    /// Класс для ведения лога работы приложения
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Путь к файлу-логу
        /// </summary>
        private string path;

        /// <summary>
        /// Путь к файлу-логу
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
        /// <param name="level">Уровень ведения лога</param>
        /// <param name="path">Путь к файлу-логу</param>
        /// <param name="restrict">Ограничение по строкам. Число 0 для работы без ограничения.</param>
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
        /// Записать сообщение в лог
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        public static void WriteToLog(string message)
        {
            // Текущая дата
            DateTime date = DateTime.Now;

            // Имя файла-лога
            string fileName = instance.path;

            lock (syncLock)
            {
                // Обработка, если уровень ошибок выше, чем уровень по настройкам
                if (true)
                {
                    // Если файл существует
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

                        // Удалить файл
                        File.Delete(fileName);

                        // Записать всё содержимое в файл
                        File.WriteAllLines(fileName, queue.ToArray(), Encoding.Default);

                        // Дописать актуальное сообщение
                        File.AppendAllText(fileName, string.Format("{0} {1}\r\n", date, message),
                            Encoding.Default);

                    }
                    else
                    {
                        // Записать строку в файл
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
