using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Aoi_KeyBoardFunction
{
    internal static class Program
    {
        public static string exePath = System.Reflection.Assembly.GetEntryAssembly().Location;
        public static string soundfolderPath = Path.Combine(Path.GetDirectoryName(exePath), "Source");
        public static string iniPath = Path.Combine(Path.GetDirectoryName(exePath), "setting.ini");
        public static Dictionary<string, string> keyValuePairs;

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            keyValuePairs = InitDictionary();
            if (File.Exists(iniPath))
            {
                LoadDictionaryFromIni(ref keyValuePairs, iniPath);
            }
            else
            {
                InitIniFile(iniPath, keyValuePairs);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }

        static Dictionary<string, string> InitDictionary()
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();

            foreach (Keys keyCode in Enum.GetValues(typeof(Keys)))
            {
                string key = keyCode.ToString();
                Debug.WriteLine(key);
                if (!temp.ContainsKey(key))
                {
                    temp.Add(key, string.Empty);
                }
            }

            return temp;
        }

        static void InitIniFile(string filePath, Dictionary<string, string> dict)
        {
            INI ini = new INI(filePath);
            foreach(var key in dict.Keys)
            {
                ini.WriteIni("source", key, "");
            }
        }

        static void LoadDictionaryFromIni(ref Dictionary<string, string> dict, string filePath)
        {
            INI ini = new INI(filePath);
            foreach (var key in dict.Keys.ToArray())
            {
                dict[key] = ini.ReadIni("source", key);
            }
        }
    }
}
