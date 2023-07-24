using System;

namespace cubeLauncher.Data
{
    public static class Constants
    {
        public const string VERSION = "v2.0.0";
        public static string MINECRAFT_ROOT = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";
        public static string CUBELAUNCHER_ROOT = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\.cubelauncher";
    }
}