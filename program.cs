using System;
using System.IO;
using System.Diagnostics;
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

        string name;
        string path;
        string icon;
        string version;
        string args;
        int width;
        int height;

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
                dropBoxLabel.Text = "Please provide a folder";
                dropBoxLabel.Update();
                return;
            }

            updInstLst();

            dropBoxLabel.Text = "";
            dropBoxLabel.Update();
        }

        private void program_Load(object sender, EventArgs e)
        {
            string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            mainDir = roamingDir + "\\.minecraft\\.cubelauncher";
            mcDir = roamingDir + "\\.minecraft";

            try
            {
                Directory.CreateDirectory(mainDir);
            }
            catch
            {
                // skip
            }

            if (!File.Exists(mainDir + "\\" + "launcher_profiles_bak.json"))
            {
                try
                {
                    File.Copy(mcDir + "\\" + "launcher_profiles.json", mainDir + "\\" + "launcher_profiles_bak.json");
                }
                catch
                {
                    // skip
                }
            }
            else
            {
                // skip
            }

            updInstLst();

            // enable folder dropping
            this.dropBoxPanel.AllowDrop = true;
            this.dropBoxInfoPicture.AllowDrop = true;

            dropBoxLabel.Text = "";
            dropBoxLabel.Update();
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

            drpBxHiClr();
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

            drpBxHiClr();
        }

        private void updInstLst ()
        {
            installList.Items.Clear();
            installList.Text = "";
            installList.Update();

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
                name = installList.Text;
                path = mainDir + "\\" + installList.Text;
                string path2 = Path.GetFullPath(path);
                path2 = path2.Replace("\\", "\\\\");
                icon = cubeLauncher.Properties.Resources.iconSerialized;
                version = "VERSION_TEMP";
                args = "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M";
                width = 1280;
                height = 720;

                string launchProfile = "{\"profiles\":{\"\":{\"gameDir\":\"" + path2 + "\",\"icon\":\"" + icon + "\",\"javaArgs\":\"" + args + "\",\"lastVersionId\":\"" + version + "\",\"name\":\"" + name + "\",\"resolution\":{\"height\":" + height + ",\"width\":" + width + "}}}}";

                File.WriteAllText("test.txt", launchProfile);
                File.WriteAllText(mcDir + "\\" + "launcher_profiles.json", launchProfile);

                if (File.Exists(@"C:\Program Files (x86)\Minecraft Launcher\MinecraftLauncher.exe"))
                {
                    try
                    {
                        Process.Start(@"C:\Program Files (x86)\Minecraft Launcher\MinecraftLauncher.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown Error: Unable to start \"MinecraftLauncher.exe\"\n\nFull Error:\n" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Error: \"MinecraftLauncher.exe\" was not found.\nBy default it is installed to \"C:\\Program Files (x86)\\Minecraft Launcher\\MinecraftLauncher.exe\"");
                }
            }
            else
            {
                dropBoxLabel.Text = "No installation is selected";
                dropBoxLabel.Update();
            }
        }

        private void program_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(mainDir + "\\" + "launcher_profiles_bak.json"))
            {
                try
                {
                    string profileContent = File.ReadAllText(mainDir + "\\launcher_profiles_bak.json");
                    File.WriteAllText(mcDir + "\\launcher_profiles.json", profileContent);
                }
                catch
                {
                    // skip
                }

                try
                {
                    File.Delete(mainDir + "\\launcher_profiles_bak.json");
                }
                catch
                {
                    // skip
                }
            }
        }

        private void dropBoxPanel_DragLeave(object sender, EventArgs e)
        {
            drpBxRstClr();
        }

        private void dropBoxInfoPicture_DragLeave(object sender, EventArgs e)
        {
            drpBxRstClr();
        }

        private void drpBxHiClr()
        {
            dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
        }

        private void drpBxRstClr()
        {
            dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
        }

        private void installList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropBoxLabel.Text = "";
            dropBoxLabel.Update();
        }

        private void deleteInstall_Click(object sender, EventArgs e)
        {
            if (installList.Text != "")
            {
                dropBoxLabel.Text = "";
                dropBoxLabel.Update();

                DialogResult prompt = MessageBox.Show("Are you sure you want to remove " + installList.Text + "?\nAll data will be removed for that installation.", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {                   
                    if (Directory.Exists(mainDir + "\\" + installList.Text))
                    {
                        try
                        {
                            Directory.Delete(mainDir + "\\" + installList.Text, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unknown Error: Unable to delete \"" + installList.Text + "\"\n\nFull Error:\n" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Directory does not exist");
                    }

                    updInstLst();
                }
            }
            else
            {
                dropBoxLabel.Text = "No installation is selected";
                dropBoxLabel.Update();
            }
        }
    }
}