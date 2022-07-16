using System;
using System.IO;
using System.Linq;
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

        // configure path variables
        string mainDir;
        string mcDir;
        string installName;
        string installPath;
        string destDir;

        // configure static json parser variables
        string path;
        string icon;

        // configure dynamic json parser variables
        string name;
        string version;
        int width;
        int height;
        string args;

        // configure dynamic .cube file parser variables
        string line1_name_format;
        string line2_version_format;
        string line3_width_format;
        string line4_height_format;
        string line5_arguments_format;
        string line6_modloader_format;

        // form events

        // form initialize component
        public program()
        {
            InitializeComponent();
        }

        // form load
        private void program_Load(object sender, EventArgs e)
        {
            // configure appdata path
            string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            mainDir = roamingDir + "\\.minecraft\\.cubelauncher";
            mcDir = roamingDir + "\\.minecraft";

            // try to create main directory
            try
            {
                Directory.CreateDirectory(mainDir);
            }
            catch
            {
                // skip
            }

            // try to make a backup of launcher profiles
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

            // update install list
            updInstLst();

            // enable folder dropping
            this.dropBoxPanel.AllowDrop = true;
            this.dropBoxInfoPicture.AllowDrop = true;

            // clear drop box label test
            dropBoxLabel.Text = "";
            dropBoxLabel.Update();

            // try to create config for remembering last session
            try
            {
                string instidx_string = File.ReadAllText(mainDir + "\\config_instidx");
                installList.SelectedIndex = int.Parse(instidx_string);
            }
            catch
            {
                // skip
            }
        }

        // form close
        private void program_FormClosing(object sender, FormClosingEventArgs e)
        {
            // try to restore launcher profiles
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

        // buttons

        // minimize button
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // install list combobox
        private void installList_DropDown(object sender, EventArgs e)
        {
            clrDrpBxLbl();
        }

        // install list combobox (indexchanged)
        private void installList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(mainDir + "\\config_instidx", installList.SelectedIndex.ToString());
            }
            catch
            {
                // skip
            }
        }

        // open install path directory button
        private void openPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", mainDir + "\\" + installList.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error: Unable to open \"" + installList.Text + "\"!\n\nFull Error:\n" + ex);
            }
        }

        // delete button
        private void deleteInstallButton_Click(object sender, EventArgs e)
        {
            if (installList.Text != "")
            {
                clrDrpBxLbl();

                // prompt user when removing installation
                DialogResult prompt = MessageBox.Show("Are you sure you want to remove " + installList.Text + "?\nAll data will be removed for that installation.", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    if (Directory.Exists(mainDir + "\\" + installList.Text))
                    {
                        // try to delete installation and update labels
                        try
                        {
                            string delName = installList.Text;
                            Directory.Delete(mainDir + "\\" + installList.Text, true);

                            dropBoxLabel.Text = "Removed " + delName + " successfully";
                            dropBoxLabel.Update();

                            updInstLst();

                            try
                            {
                                installList.SelectedIndex = 0;
                            }
                            catch
                            {
                                // skip
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unknown Error: Unable to delete \"" + installList.Text + "\"!\n\nFull Error:\n" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Directory does not exist.");
                    }
                }
            }
            else
            {
                dropBoxLabel.Text = "No installation is selected";
                dropBoxLabel.Update();
            }
        }

        // options button
        private void optionsButton_Click(object sender, EventArgs e)
        {
            // open options form
            options options_form = new options();
            options_form.ShowDialog();
        }

        // launch button
        private void launchButton_Click(object sender, EventArgs e)
        {
            if (installList.Text != "")
            {
                clrDrpBxLbl();

                // load from config.cube if it exists
                if (File.Exists(mainDir + "\\" + installList.Text + "\\.cube\\config.cube"))
                {
                    if (!File.Exists(mainDir + "\\" + "config_ovrcube"))
                    {
                        try
                        {
                            string line1_name = File.ReadLines(mainDir + "\\" + installList.Text + "\\.cube\\config.cube").ElementAt(1);
                            line1_name_format = line1_name.Replace("name: ", "");
                            name = line1_name_format;
                        }
                        catch
                        {
                            // skip
                        }

                        try
                        {
                            string line2_version = File.ReadLines(mainDir + "\\" + installList.Text + "\\.cube\\config.cube").ElementAt(2);
                            line2_version_format = line2_version.Replace("version: ", "");
                            version = line2_version_format;
                        }
                        catch
                        {
                            // skip
                        }

                        try
                        {
                            string line3_width = File.ReadLines(mainDir + "\\" + installList.Text + "\\.cube\\config.cube").ElementAt(3);
                            line3_width_format = line3_width.Replace("width: ", "");
                            width = int.Parse(line3_width_format);
                        }
                        catch
                        {
                            // skip
                        }

                        try
                        {
                            string line4_height = File.ReadLines(mainDir + "\\" + installList.Text + "\\.cube\\config.cube").ElementAt(4);
                            line4_height_format = line4_height.Replace("height: ", "");
                            height = int.Parse(line4_height_format);
                        }
                        catch
                        {
                            // skip
                        }

                        try
                        {
                            string line5_arguments = File.ReadLines(mainDir + "\\" + installList.Text + "\\.cube\\config.cube").ElementAt(5);
                            line5_arguments_format = line5_arguments.Replace("arguments: ", "");
                            args = line5_arguments_format;
                        }
                        catch
                        {
                            // skip
                        }
                    }
                    else
                    {
                        readFrmOp();
                    }
                }
                else
                {
                    readFrmOp();
                }

                // configure static variables
                path = mainDir + "\\" + installList.Text;
                string path2 = Path.GetFullPath(path);
                path2 = path2.Replace("\\", "\\\\");
                icon = cubeLauncher.Properties.Resources.iconSerialized;

                string launchProfile = "{\"profiles\":{\"\":{\"gameDir\":\"" + path2 + "\",\"icon\":\"" + icon + "\",\"javaArgs\":\"" + args + "\",\"lastVersionId\":\"" + version + "\",\"name\":\"" + name + "\",\"resolution\":{\"height\":" + height + ",\"width\":" + width + "}}}}";

                // write launcher profile data
                File.WriteAllText(mcDir + "\\" + "launcher_profiles.json", launchProfile);

                // attempt to launch the minecraft launcher
                if (File.Exists(@"C:\Program Files (x86)\Minecraft Launcher\MinecraftLauncher.exe"))
                {
                    try
                    {
                        Process.Start(@"C:\Program Files (x86)\Minecraft Launcher\MinecraftLauncher.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown Error: Unable to start \"MinecraftLauncher.exe\"!\n\nFull Error:\n" + ex);
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

        // functions

        // install function
        private void install(DragEventArgs e)
        {
            drpBxRstClr();

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in file)
            {
                installPath = path;
            }

            installName = new DirectoryInfo(installPath).Name;
            destDir = mainDir + "\\" + installName;

            // prompt user before overwriting installation
            if (Directory.Exists(mainDir + "\\" + installName))
            {
                drpBxRstClr();
                DialogResult prompt = MessageBox.Show("Are you sure you want to install " + installName + "?\nAn installation with that name already exists and it will be overwritten.", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    Directory.Delete(mainDir + "\\" + installName, true);
                    dropBoxLabel.Text = "Overwrote " + installName + " successfully";
                    instFiles();

                    installList.Text = installName;
                }
            }
            else
            {
                instFiles();
            }
        }

        // install files function
        private void instFiles()
        {
            // try to execute install script
            try
            {
                dropBoxLabel.Text = "Installing " + installName;
                dropBoxLabel.Update();

                Parallel.ForEach(Directory.GetFileSystemEntries(installPath, "*", SearchOption.AllDirectories), (fileDir) =>
                {
                    string outputDir = Regex.Replace(fileDir, "^" + Regex.Escape(installPath), destDir);
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

            srtModLdr();

            installList.Text = installName;
            dropBoxLabel.Text = "Installed " + installName + " successfully";
            dropBoxLabel.Update();
        }

        // update install list function
        private void updInstLst()
        {
            installList.Items.Clear();
            installList.Text = "";
            installList.Update();

            string[] files = Directory.GetDirectories(mainDir);
            foreach (string file in files)
            {
                installList.Items.Add(Path.GetFileNameWithoutExtension(file));
            }    
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

        // highlight dropbox function
        private void drpBxHiClr()
        {
            dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
        }

        // reset highlight dropbox function
        private void drpBxRstClr()
        {
            dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
        }

        // clear dropbox label text function
        private void clrDrpBxLbl()
        {
            dropBoxLabel.Text = "";
            dropBoxLabel.Update();
        }

        // modloader installer function
        private void srtModLdr()
        {
            // check if config.cube exists, if it does, prompt the user if they want to install the available modloader
            if (File.Exists(mainDir + "\\" + installName + "\\.cube\\config.cube"))
            {
                DialogResult prompt = MessageBox.Show("Found a modloader for " + installName + ".\nDo you want to install it?", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    try
                    {
                        string line6_modloader = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(6);
                        line6_modloader_format = line6_modloader.Replace("modloader: ", "");
                        Process.Start(mainDir + "\\" + installName + "\\.cube\\" + line6_modloader_format);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown Error: Unable to start \"" + line6_modloader_format + "\"!\n\nFull Error:\n" + ex);
                    }
                }
            }
        }

        // drag drop events

        // dropbox drop
        private void dropBoxPanel_DragDrop(object sender, DragEventArgs e)
        {
            install(e);
        }

        // dropboxpicture drop
        private void dropBoxInfoPicture_DragDrop(object sender, DragEventArgs e)
        {
            install(e);
        }

        // dropbox enter
        private void dropBoxPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }

            drpBxHiClr();
        }

        // dropboxpicture enter
        private void dropBoxInfoPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }

            drpBxHiClr();
        }

        // dropbox leave
        private void dropBoxPanel_DragLeave(object sender, EventArgs e)
        {
            drpBxRstClr();
        }

        // dropboxpicture leave
        private void dropBoxInfoPicture_DragLeave(object sender, EventArgs e)
        {
            drpBxRstClr();
        }

        // move form senders

        // panel sender
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        // panel banner sender
        private void panelBanner_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        // panel version sender
        private void panelBannerVersion_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        // panel credit sender
        private void panelByO7q_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        private void readFrmOp()
        {
            // if config.cube doesn't exist then read text from config overrides
            if (File.Exists(mainDir + "\\config_name"))
            {
                name = File.ReadAllText(mainDir + "\\config_name");
            }
            else
            {
                name = installList.Text;
            }

            if (File.Exists(mainDir + "\\config_ver"))
            {
                version = File.ReadAllText(mainDir + "\\config_ver");
            }
            else
            {
                version = "latest-release";
            }

            if (File.Exists(mainDir + "\\config_x"))
            {
                try
                {
                    string width_string = File.ReadAllText(mainDir + "\\config_x");
                    width = int.Parse(width_string);
                }
                catch
                {
                    width = 1280;
                }
            }
            else
            {
                width = 1280;
            }

            if (File.Exists(mainDir + "\\config_y"))
            {
                try
                {
                    string height_string = File.ReadAllText(mainDir + "\\config_y");
                    height = int.Parse(height_string);
                }
                catch
                {
                    height = 720;
                }
            }
            else
            {
                height = 720;
            }

            if (File.Exists(mainDir + "\\config_args"))
            {
                args = File.ReadAllText(mainDir + "\\config_args");
            }
            else
            {
                args = "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M";
            }
        }
    }
}