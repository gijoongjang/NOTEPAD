using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEPAD.Lib.Util
{
    public static class FileUtil
    {
        public static string GetFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return string.Empty;

            return Path.GetFileNameWithoutExtension(fileName);
        }
    }
}
