using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AkReminder.Models.Files.Factory
{
    interface FileLoaderFactory
    {
        FileLoader getFileLoader();
    }
}
