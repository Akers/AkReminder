using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AkReminder.Models.Files.Impl;

namespace AkReminder.Models.Files.Factory
{
    class XmlConfigurationFileLoaderFactory : FileLoaderFactory
    {

        public FileLoader getFileLoader()
        {
            if (loaderMap.ContainsKey("xmlConfLoader") == false)
            {
                loaderMap.Add("xmlConfLoader", new XmlFileLoader());
            }
            return (FileLoader)loaderMap["xmlConfLoader"];
        }

        private static Hashtable loaderMap = new Hashtable();
    }
}
