using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AkReminder.Models.Files
{
    public enum FileLoaderStatus : int
    {
        NoError = 0,
        FileLoadSucceed = 1,
        FileNotFoundError = -1
    };
    interface FileLoader
    {

        Object getFile();
        FileLoader setFilePath(String path);
    }
}
