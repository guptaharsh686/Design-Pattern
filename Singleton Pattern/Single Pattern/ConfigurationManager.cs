using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Pattern
{
    public class ConfigurationManager
    {
        private Dictionary<string, Object> settings = new Dictionary<string, object>();

        //Requirements
        // Private Constructor
        // private static property which stores instance
        // public static method to get the instance

        private ConfigurationManager()
        {

        }

        private static ConfigurationManager instance = new ConfigurationManager();

        public static ConfigurationManager getInstance()
        {
            return instance;
        }

        public void set(string key,Object value)
        {
            settings.Add(key, value);
        }

        public Object get(string key)
        {
            Object value;
            settings.TryGetValue(key, out value);
            return value;
        }
    }
}
