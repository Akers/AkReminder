using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AkReminder.Models.Configurations.po;

namespace AkReminder.Models.Configurations
{
    class XMLConfigurationLoaderFactory : ConfigurationLoaderFactory
    {
        //private static List<ConfigurationLoader> confLoaders = new List<ConfigurationLoader>();
        //private static ConfigurationLoader confLoader = null;
        private static Hashtable loaderMap = new Hashtable();
        public ConfigurationLoader getConfigurationLoader()
        {
            if (loaderMap.ContainsKey("confLoader") == false)
            {
                loaderMap.Add("confLoader", new XmlConfigurationLoader());
            }

            return (XmlConfigurationLoader)loaderMap["confLoader"];
        }

    }
}
