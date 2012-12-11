using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml;

namespace AkReminder.Models.Files.Impl
{
    class XmlFileLoader : FileLoader
    {
        public XmlFileLoader()
        {
            this.xmlDoc = new XmlDocument();
        }

        public FileLoader setFilePath(String path)
        {
            Console.WriteLine(path);
            if (File.Exists(path) == false)
            {
                //ToDo: Operation.Message.Error
                MessageBox.Show(String.Format("文件{0}不存在", path));
                this.status = FileLoaderStatus.FileNotFoundError;
            }
            else
                this.filePath = path;
            return this;
        }

        public object getFile()
        {
            if (this.status != FileLoaderStatus.FileNotFoundError)
                this.xmlDoc.Load(this.filePath);
            else
                this.xmlDoc.LoadXml(this.defaultConf);
            return this.xmlDoc;
        }

        private String defaultConf = "<AkReminderConfiguration><AutoRun>false</AutoRun></AkReminderConfiguration>";
        private FileLoaderStatus status = FileLoaderStatus.NoError;
        private XmlDocument xmlDoc = null;
        private String filePath = "";
    }
}
