using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SBWikiSettings
{
    public class SettingsManager
    {
        public Settings Default { get; set; }
        public Settings Settings { get; set; }
        public SettingsManager() 
        {
            if (File.Exists("settings.conf"))
            {
                Settings = LoadSettings();
                Default = LoadDefaults();
            }
            else 
            {
                var settings = LoadDefaults();
                Settings = settings;
                Default = settings;
                SaveSettings();
            }
        }
        public Settings LoadSettings() 
        {
            string data;
            using (StreamReader sr = new StreamReader("settings.conf"))
            {
                data=sr.ReadToEnd();
            }
            Settings settings=JsonConvert.DeserializeObject<Settings>(data);
            return settings;
        }
        public void SaveSettings() 
        {
            string data=JsonConvert.SerializeObject(Settings);
            using (StreamWriter sw = new StreamWriter("settings.conf")) 
            {
                sw.Write(data);
            }
        }
        public Settings LoadDefaults() 
        {
            string data;
            using (StreamReader sr = new StreamReader("defaults.conf"))
            {
                data = sr.ReadToEnd();
            }
            Settings settings = JsonConvert.DeserializeObject<Settings>(data);
            return settings;
        }
    }
}
