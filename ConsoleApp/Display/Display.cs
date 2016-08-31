using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Display
{
    public class Display : IDisplay
    {
        public bool isWrite { get; set; }
        public Display(string type)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
          
            if (settings[type].Value == "true")
            {
                isWrite = true;
            }
 
        }

        public void Write() { }
        
    }
}
