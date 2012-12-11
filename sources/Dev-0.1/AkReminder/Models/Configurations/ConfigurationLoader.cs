using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AkReminder.Models.Configurations.po;

namespace AkReminder.Models
{
    interface ConfigurationLoader
    {
        Configuration getConfiguration();
    }
}
