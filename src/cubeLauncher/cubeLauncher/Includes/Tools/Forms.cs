using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace cubeLauncher.Tools
{
    public static class Forms
    {
        // constants for mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // import the SendMessage and ReleaseCapture functions from user32.dll
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // method to move the form when the mouse is clicked and dragged
        public static void MoveForm(IntPtr handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static void PlaySFX(string soundPath)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            Stream s = a.GetManifestResourceStream(soundPath);
            SoundPlayer p = new SoundPlayer(s);
            p.Play();
        }

        public static void ShowMessage(Label label, string msg)
        {
            label.Text = msg;
            label.Update();
        }

        // highlight dropbox function
        public static void HighlightPanelColor(Panel panel)
        {
            panel.BackColor = System.Drawing.Color.FromArgb(255, 30, 45, 30);
        }

        // reset highlight dropbox function
        public static void ResetPanelColor(Panel panel)
        {
            panel.BackColor = System.Drawing.Color.FromArgb(255, 20, 35, 20);
        }
    }
}