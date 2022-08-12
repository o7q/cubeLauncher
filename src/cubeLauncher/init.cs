using System;
using System.Windows.Forms;

namespace cubeLauncher
{
    internal static class init
    {
        [STAThread]
        static void Main()
        {
            // start program.cs
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new program());
        }
    }
}