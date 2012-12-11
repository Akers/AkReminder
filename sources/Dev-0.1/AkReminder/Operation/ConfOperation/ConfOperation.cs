using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AkReminder.Models;
using AkReminder.Models.Configurations;
using AkReminder.Models.Configurations.po;

namespace AkReminder.Operation.ConfOperation
{
    class ConfOperation
    {
        public bool ReadIsAutoRun()
        {
            if (this.conf == null)
            {
                this.loadConfiguration();
            }
            return this.conf.AutoRun;
        }

        private void loadConfiguration()
        {
            if (this.conf == null)
            {
                ConfigurationLoaderFactory clf = new XMLConfigurationLoaderFactory();
                ConfigurationLoader confLoader = clf.getConfigurationLoader();
                this.conf = confLoader.getConfiguration();
            }
        }

        private Configuration conf = null;
    }
}
