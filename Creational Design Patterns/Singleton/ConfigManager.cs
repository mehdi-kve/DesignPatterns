using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigManager
    {
        private Dictionary<string, object> settings = new Dictionary<string, object>();
        private static ConfigManager instance = new ConfigManager();
                
        private ConfigManager(){}

        public static ConfigManager getInstance() 
        {
            return instance;
        }

        public void set(string key, object value) 
        {
            settings.Add(key, value);
        }

        public object get(string key)
        {
            return settings[key];
        }
         
    }
} 
