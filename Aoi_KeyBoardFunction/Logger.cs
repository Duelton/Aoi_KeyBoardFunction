using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class Logger
    {
        private static readonly string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{AppDomain.CurrentDomain.FriendlyName}.log");
        private static readonly object lockObject = new object();

        public static void DelLog()
        {
            try
            {
                if (File.Exists(logPath)) File.Delete(logPath);
            }
            catch(Exception exp)
            {
                throw exp;
            }
        }

        public static void WriteLog(bool status, string message)
        {
            string logStatus = status ? "Pass" : "False";
            string logEntry = $"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")},{logStatus},{message}";
            lock (lockObject)
            {
                using (StreamWriter writer = File.AppendText(logPath))
                {
                    writer.WriteLine(logEntry);
                }
            }
        }
    }
}
