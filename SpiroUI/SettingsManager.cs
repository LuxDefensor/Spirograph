using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Spirograph
{
    static class SettingsManager
    {
        private static string fileName = "Settings.ini";

        public static string GetSetting(string key)
        {
            string result;
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                Dictionary<string, string> settings = lines.ToDictionary<string, string, string>(
                                                    (string left) => left.Split('=')[0].Trim(),
                                                    (string right) => right.Split('=')[1].Trim());
                if (!settings.ContainsKey(key))
                    throw new Exception("No such key in settings dictionary: " + key);
                result = settings[key];
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка чтения файла настроек", ex);
            }
            return result;
        }
    }
}
