using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace STK2
{
    internal class IniFile
    {
        private string path;

        public IniFile(string path)
        {
            this.path = path;

        }

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);

        public string Read(string section, string key, string defaultValue = "") { 
            var value = new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, value, 255, path);
            return value.ToString();
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }
    }

}

