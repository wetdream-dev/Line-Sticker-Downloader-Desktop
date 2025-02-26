using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LineStickerDownloader
{
    internal class settings
    {
        public string Path { get; private set; }

        public settings(string iniPath)
        {
            Path = iniPath;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder returnValue, int size, string filePath);

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, Path);
        }

        public string Read(string section, string key, string defaultValue = "")
        {
            var returnValue = new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, returnValue, returnValue.Capacity, Path);
            return returnValue.ToString();
        }
    }
}
