using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spirograph
{
    static class Localization
    {
        private static string currentLanguage = SettingsManager.GetSetting("Language");

        public static string GetString(string key)
        {
            string result;
            XDocument xml = XDocument.Load("Strings.xml");
            if (xml.Descendants(key).Descendants(currentLanguage).Count() == 0)
                result = xml.Descendants(key).Descendants("English").First().Value;
            else
                result = xml.Descendants(key).Descendants(currentLanguage).First().Value;
            return result;
        }
    }
}
