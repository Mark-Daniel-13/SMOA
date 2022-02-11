using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.Business.Helpers
{
    public class AppSettings
    {
        public static bool SetSetting(string key, string value)
        {
            try
            {
                Configuration configuration =
                    ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings[key].Value = value;
                configuration.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");

                return true; ;
            }
            catch(Exception e)
            {
                var err = e.Message;
                return false;
            }
        }

        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
