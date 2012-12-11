using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using AkReminder.Models.Files;
using AkReminder.Models.Files.Factory;

namespace AkReminder.Models
{
    class XmlConfigurationLoader : ConfigurationLoader
    {
        public XmlConfigurationLoader()
        {
            FileLoaderFactory ff = new XmlConfigurationFileLoaderFactory();
            FileLoader fileLoader = ff.getFileLoader();
            this.xmlDoc = (XmlDocument)fileLoader.setFilePath(this.confFilePath).getFile();
            this.configuration = new Configurations.po.Configuration();
        }

        public Configurations.po.Configuration getConfiguration()
        {
            //read autorun node an get value of the property named 'value'
            XmlNode node = xmlDoc.SelectSingleNode("AkReminderConfiguration/AutoRun");
            bool autoRunVal = false;
            //当转换成功且AutoRun节点值为1时configuration.AutoRun的值才为true，否则都为false
            this.configuration.AutoRun = Boolean.TryParse(node.InnerText, out autoRunVal) && autoRunVal;
            return this.configuration;
        }

        private Configurations.po.Configuration configuration = null;
        private String confFilePath = "conf.xml";
        private XmlDocument xmlDoc = null;
    }
}
