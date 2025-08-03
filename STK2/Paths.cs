using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STK2
{
    internal static class Paths
    {
        public static readonly string AppFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "STKApp");

        public static string Img => Path.Combine(AppFolder, "img");
        public static string Users => Path.Combine(AppFolder, "users");
        public static string Config => Path.Combine(AppFolder, "config.json");

        public static string Seen => Path.Combine(AppFolder, "seen.ini");
        public static string ReminderExe => Path.Combine(AppFolder, "STKreminder.exe");

        public static void EnsureFoldersExist()
        {
            Directory.CreateDirectory(AppFolder);
            Directory.CreateDirectory(Img);
            Directory.CreateDirectory(Users);
        }
    }
}
