using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace cubeLauncher
{
    public partial class program : Form
    {
        // mousedown stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // configure public strings
        string installName;
        string installDir;

        public program()
        {
            InitializeComponent();
        }

        // form load
        private void program_Load(object sender, EventArgs e)
        {
            string[] installationFiles = Directory.GetDirectories("cubelauncher\\installations");
            foreach (string file in installationFiles)
            selectInstall.Items.Add(Path.GetFileNameWithoutExtension(file));
            selectInstall.SelectedIndex = 0;
            statusLabel.Text = "";

            string envDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string dir = envDir + "\\.minecraft\\cubelauncher";

            if (!Directory.Exists(dir))
            {
                try
                {
                    Directory.CreateDirectory(dir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't create directory: \n" + dir + "\n\n" + ex);
                }
            }
        }

        // move form function
        private void moveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // move form senders
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }

        private void panelBanner_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }

        // buttons
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectInstall_SelectedIndexChanged(object sender, EventArgs e)
        {
            installName = (string)selectInstall.SelectedItem;
            installDir = Path.Combine("cubelauncher\\installations", installName);
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            if(installName != "")
            {
                string envDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string dir = envDir + "\\.minecraft\\cubelauncher";

                if (!Directory.Exists(dir))
                {
                    try
                    {
                        Directory.CreateDirectory(dir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not create directory: \n" + dir + "\n\n" + ex);
                    }
                }

                installDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, installDir);
                string srcDir = installDir;
                string trgDir = envDir + "\\.minecraft\\cubelauncher\\" + installName;
                Copy(srcDir, trgDir);

                /*try
                {
                    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, trgDir + "\\forge.exe");
                    Process process = new Process();
                    process.StartInfo.FileName = path;
                    process.Start();
                    process.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("forge.exe not found. (this is required for the modpack to function!)");
                }

                MessageBox.Show("Press OK when forge installation is complete");
                System.Diagnostics.Process.Start(@"vega_installer\minecraft\minecraft.exe");*/
            }
            else
            {
                MessageBox.Show("No installation is selected");
            }
        }

        // copy functions
        public void Copy(string srcDir, string targDir)
        {
            var dirSrc = new DirectoryInfo(srcDir);
            var dirTarg = new DirectoryInfo(targDir);

            CopyAll(dirSrc, dirTarg);
            statusLabel.Text = "";
            installName = "";
        }

        private void CopyAll(DirectoryInfo src, DirectoryInfo targ)
        {
            Directory.CreateDirectory(targ.FullName);

            try
            {
                foreach (FileInfo file in src.GetFiles())
                {
                    statusLabel.Text = file.Name;
                    statusLabel.Update();
                    file.CopyTo(Path.Combine(targ.FullName, file.Name), true);
                    Application.DoEvents();
                }
            }
            catch
            {
                // ignore
            }

            foreach (DirectoryInfo srcSubDir in src.GetDirectories())
            {
                DirectoryInfo nxtSrcSubDir = targ.CreateSubdirectory(srcSubDir.Name);
                CopyAll(srcSubDir, nxtSrcSubDir);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            selectInstall.Items.Clear();
            selectInstall.ResetText();
            string[] installationFiles = Directory.GetDirectories("cubelauncher\\installations");
            foreach (string file in installationFiles)
            selectInstall.Items.Add(Path.GetFileNameWithoutExtension(file));
        }
    }
}