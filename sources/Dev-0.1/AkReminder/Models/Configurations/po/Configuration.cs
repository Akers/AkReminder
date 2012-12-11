using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AkReminder.Models.Configurations.po
{
    class Configuration
    {
        public bool AutoRun
        {
            get { return this.autoRun; }
            set { this.autoRun = value; }
        }
        private bool autoRun;
    }
}
