using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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

        string mainDir;
        string mcDir;
        string instPath;

        public program()
        {
            InitializeComponent();
        }

        // move form function
        private void mvFrm(MouseEventArgs e)
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
            mvFrm(e);
        }

        private void panelBanner_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void panelBannerVersion_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
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

        private void install(DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in file)
            instPath = path;

            string installName = new DirectoryInfo(instPath).Name;
            string destDir = mainDir + "\\" + installName;

            try
            {
                dropBoxLabel.Text = "Installing - Please Wait...";
                dropBoxLabel.Update();

                Parallel.ForEach(Directory.GetFileSystemEntries(instPath, "*", SearchOption.AllDirectories), (fileDir) =>
                {
                    string outputDir = Regex.Replace(fileDir, "^" + Regex.Escape(instPath), destDir);
                    if (File.Exists(fileDir))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(outputDir));
                        File.Copy(fileDir, outputDir, true);
                    }
                    else
                    {
                        Directory.CreateDirectory(outputDir);
                    }
                }
                );
            }
            catch
            {
                dropBoxLabel.Text = "Error: Please provide a folder";
                dropBoxLabel.Update();
                return;
            }

            updInstLst();

            dropBoxLabel.Text = "";
        }

        private void program_Load(object sender, EventArgs e)
        {
            string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            mainDir = roamingDir + "\\.minecraft\\.cubelauncher";
            mcDir = roamingDir + "\\.minecraft";

            if (!File.Exists(mainDir + "\\" + "launcher_profiles_bak.json"))
            {
                try
                {
                    File.Copy(mcDir + "\\" + "launcher_profiles.json", mainDir + "\\" + "launcher_profiles_bak.json");
                }
                catch
                {
                    // ignore
                }
            }
            else
            {
                // skip
            }

            try
            {
                Directory.CreateDirectory(mainDir);
            }
            catch
            {
                // ignore
            }

            updInstLst();

            // enable folder dropping
            this.dropBoxPanel.AllowDrop = true;
            this.dropBoxInfoPicture.AllowDrop = true;

            dropBoxLabel.Text = "";
        }

        private void dropBoxInfoPicture_DragDrop(object sender, DragEventArgs e)
        {
            install(e);
        }

        private void dropBoxInfoPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void dropBoxPanel_DragDrop(object sender, DragEventArgs e)
        {
            install(e);
        }

        private void dropBoxPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void updInstLst ()
        {
            installList.Items.Clear();

            string[] files = Directory.GetDirectories(mainDir);
            foreach (string file in files)
            installList.Items.Add(Path.GetFileNameWithoutExtension(file));
        }

        private void updateInstallList_Click(object sender, EventArgs e)
        {
            updInstLst();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (installList.Text != "")
            {
                string name = installList.Text;
                string path = mainDir + "\\" + installList.Text;
                string icon = cubeLauncher.Properties.Resources.iconSerialized;
                string args = "";

                string launchProfile = "";


                //File.WriteAllText(mcDir + "\\" + "launcher_profiles.json", );
            }
            else
            {
                dropBoxLabel.Text = "Error: Please select an installation";
                dropBoxLabel.Update();
            }
        }
    }
}