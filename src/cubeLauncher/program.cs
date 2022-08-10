using System;
using System.IO;
using System.Linq;
using System.Media;
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

        // create global variables

        // path variables
        string mainDir;
        string mcDir;
        string installPath;
        string installName;
        string destDir;

        // static json parser variables
        string path;

        // dynamic json parser variables
        string name;
        string version;
        int width;
        int height;
        string args;

        // dynamic .cube file parser variables
        string line1_name_format;
        string line2_version_format;
        string line3_width_format;
        string line4_height_format;
        string line5_arguments_format;
        string line6_modloader_format;

        // path for sfx
        string sndPth;
        string srtSndPth = "cubeLauncher.Resources.grass";

        // form events

        // form initialize component
        public program()
        {
            InitializeComponent();
        }

        // form load
        private void program_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                DialogResult prompt = MessageBox.Show("An instance of cubeLauncher is already running.\nHaving two or more instances of cubeLauncher running simultaneously can cause issues (file corruption, malfunctioning).\n\nAre you sure you want to continue?", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    // continue
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            // configure appdata path
            string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            mainDir = roamingDir + "\\.minecraft\\.cubelauncher";
            mcDir = roamingDir + "\\.minecraft";

            // try to create the main directory
            try
            {
                Directory.CreateDirectory(mainDir);
            }
            catch
            {
                // skip
            }

            // try to make a backup of launcher profiles
            try
            {
                File.Copy(mcDir + "\\" + "launcher_profiles.json", mainDir + "\\" + "launcher_profiles_bak.json");
            }
            catch
            {
                // skip
            }

            // try to make a second backup of launcher profiles
            if (!File.Exists(mainDir + "\\" + "launcher_profiles_bak2.json"))
            {
                try
                {
                    File.Copy(mcDir + "\\" + "launcher_profiles.json", mainDir + "\\" + "launcher_profiles_bak2.json");
                }
                catch
                {
                    // skip
                }
            }

            // update install list
            updInstLst();

            // enable folder dropping
            this.dropBoxPanel.AllowDrop = true;
            this.dropBoxInfoPicture.AllowDrop = true;

            // configure drop box label
            dropBoxLabel.BringToFront();
            dropBoxLabel.Text = "";
            dropBoxLabel.Update();

            // load last client session
            try
            {
                string instidx_string = File.ReadAllText(mainDir + "\\conf_instindx");
                installList.SelectedIndex = int.Parse(instidx_string);
            }
            catch
            {
                // skip
            }

            // configure tooltips
            programToolTip.SetToolTip(minimizeButton, "Minimize");
            programToolTip.SetToolTip(closeButton, "Close");
            string drgDrpTT = "Drag and drop a folder to install";
            programToolTip.SetToolTip(dropBoxPanel, drgDrpTT);
            programToolTip.SetToolTip(dropBoxInfoPicture, drgDrpTT);
            programToolTip.SetToolTip(grassBanner, drgDrpTT);
            programToolTip.SetToolTip(dropBoxLabel, "Output message");
            programToolTip.SetToolTip(installList, "Currently selected installation - Clicking the arrow will show a list of all installations");
            programToolTip.SetToolTip(createInstallButton, "Create a blank installation - Specify the name in the textbox to the left");
            programToolTip.SetToolTip(deleteInstallButton, "Remove the selected installation");
            programToolTip.SetToolTip(openPathButton, "Open the folder path of the selected installation");
            programToolTip.SetToolTip(optionsButton, "Open the options window");
            programToolTip.SetToolTip(launchButton, "Launch the selected installation with the specified options");

            // configure tooltip draw
            programToolTip.OwnerDraw = true;
            programToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            programToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(183)))), ((int)(((byte)(93)))));
        }

        // draw tooltips
        private void programToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
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
                File.WriteAllText(mainDir + "\\conf_instindx", installList.SelectedIndex.ToString());
                File.WriteAllText(mainDir + "\\conf_instname", installList.Text);
            }
            catch
            {
                // skip
            }
        }

        // create button
        private void createInstallButton_Click(object sender, EventArgs e)
        {
            if (installList.Text != "")
            {
                if (!Directory.Exists(mainDir + "\\" + installList.Text))
                {
                    try
                    {
                        Directory.CreateDirectory(mainDir + "\\" + installList.Text);
                        dropBoxLabel.Text = "Created \"" + installList.Text + "\" successfully";
                        updInstLst();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown Error: Unable to create \"" + installList.Text + "\"!\n\nFull Error:\n" + ex);
                    }
                }
                else
                {
                    dropBoxLabel.Text = "\"" + installList.Text + "\" already exists";
                }
            }
            else
            {
                dropBoxLabel.Text = "Please specify a name";
            }
        }

        // delete button
        private void deleteInstallButton_Click(object sender, EventArgs e)
        {
            if (installList.Text != "")
            {
                clrDrpBxLbl();

                // prompt user when removing installation
                DialogResult prompt = MessageBox.Show("Are you sure you want to remove \"" + installList.Text + "\"?\nAll data (worlds, options, etc.) will be removed for that installation.", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    if (Directory.Exists(mainDir + "\\" + installList.Text))
                    {
                        // try to delete installation and update labels
                        try
                        {
                            Directory.Delete(mainDir + "\\" + installList.Text, true);

                            string delName = installList.Text;
                            dropBoxLabel.Text = "Removed \"" + delName + "\" successfully";
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

                            try
                            {
                                if (installList.Text != "")
                                {
                                    File.WriteAllText(mainDir + "\\conf_instname", installList.Text);
                                }
                                else
                                {
                                    File.WriteAllText(mainDir + "\\conf_instname", "");
                                }
                            }
                            catch
                            {
                                //skip
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unknown Error: Unable to remove \"" + installList.Text + "\"!\n\nFull Error:\n" + ex);

                            updInstLst();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Directory does not exist.");

                        updInstLst();
                    }
                }
            }
            else
            {
                dropBoxLabel.Text = "No installation is selected";
                dropBoxLabel.Update();
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

        // options button
        private void optionsButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(mainDir + "\\" + installList.Text + "\\.cube\\config.cube") && installList.Text != "")
            {
                try
                {
                    Directory.CreateDirectory(mainDir + "\\" + installList.Text + "\\.cube");
                    File.WriteAllText(mainDir + "\\" + installList.Text + "\\.cube\\config.cube", "# CUBELAUNCHER CONFIG\nname: " + installList.Text + "\nversion: latest-release\nwidth: 1280\nheight: 720\narguments: -Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M\nmodloader: ");
                }
                catch
                {
                    // skip
                }
            }

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
                    name = installList.Text;
                    version = "latest-release";
                    width = 1280;
                    height = 720;
                    args = "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M";
                }

                // configure static variables
                path = mainDir + "\\" + installList.Text;
                string path2 = Path.GetFullPath(path);
                path2 = path2.Replace("\\", "\\\\");

                string launchProfile = "{\"profiles\":{\"\":{\"gameDir\":\"" + path2 + "\",\"javaArgs\":\"" + args + "\",\"lastVersionId\":\"" + version + "\",\"name\":\"" + name + "\",\"resolution\":{\"height\":" + height + ",\"width\":" + width + "}}}}";

                // write launcher profile data
                File.WriteAllText(mcDir + "\\" + "launcher_profiles.json", launchProfile);

                // attempt to launch the minecraft launcher
                if (File.Exists(mainDir + "\\conf_lchrpth"))
                {
                    // try to launch from the custom directory
                    string launcherPath = File.ReadAllText(mainDir + "\\conf_lchrpth");
                    try
                    {
                        Process.Start(launcherPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown Error: Unable to start the specified launcher!\n\nFull Error:\n" + ex);
                    }
                }
                else
                {
                    // try to launch from the standard directory
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
                        MessageBox.Show("Error: \"MinecraftLauncher.exe\" was not found.\nBy default it is installed to \"C:\\Program Files (x86)\\Minecraft Launcher\\MinecraftLauncher.exe\"\n\n* In the options menu you can specify a new launcher path if your launcher is not in the standard directory.");
                    }
                }
            }
            else
            {
                dropBoxLabel.Text = "No installation is selected";
                dropBoxLabel.Update();
            }
        }

        // play grass sounds on doubleclick
        private void grassBanner_DoubleClick(object sender, EventArgs e)
        {
            switch (new Random().Next(1, 4))
            {
                case 1:
                    sndPth = srtSndPth + "1.wav";
                    playSfx();

                    break;
                case 2:
                    sndPth = srtSndPth + "2.wav";
                    playSfx();

                    break;
                case 3:
                    sndPth = srtSndPth + "3.wav";
                    playSfx();

                    break;
            }
        }

        // functions

        // install function
        private void install(DragEventArgs e)
        {
            drpBxRstColr();

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
                drpBxRstColr();
                DialogResult prompt = MessageBox.Show("Are you sure you want to reinstall \"" + installName + "\"?\n\nAn installation with that name already exists and it will be reinstalled resulting in all data (worlds, options, etc.) being removed.\n\nOtherwise you can merge the installation which will preserve unchanged data.\n\nYes = Reinstall\nNo = Merge\nCancel = Do nothing", "", MessageBoxButtons.YesNoCancel);
                if (prompt == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(mainDir + "\\" + installName, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown Error: Unable to remove \"" + installList.Text + "\"!\n\nFull Error:\n" + ex);
                    }

                    instFiles();

                    installList.Text = installName;
                    dropBoxLabel.Text = "Reinstalled \"" + installName + "\" successfully";
                }
                else
                {
                    if (prompt == DialogResult.No)
                    {
                        instFiles();

                        installList.Text = installName;
                        dropBoxLabel.Text = "Merged \"" + installName + "\" successfully";
                    }
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
                dropBoxLabel.Text = "Installing \"" + installName + "\"";
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
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error: Unable to install \"" + installName + "\"!\n\nFull Error:\n" + ex);

                dropBoxLabel.Text = "";
                dropBoxLabel.Update();

                updInstLst();

                installList.Text = "";

                return;
            }

            updInstLst();

            srtModLdr();

            installList.Text = installName;
            dropBoxLabel.Text = "Installed \"" + installName + "\" successfully";
            dropBoxLabel.Update();
        }

        // modloader installer function
        private void srtModLdr()
        {
            // check if config.cube exists, if it does, prompt the user if they want to install the available modloader
            if (File.Exists(mainDir + "\\" + installName + "\\.cube\\config.cube"))
            {
                DialogResult prompt = MessageBox.Show("Found a modloader for \"" + installName + "\".\nDo you want to install it?", "", MessageBoxButtons.YesNo);
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

        // update install list function
        private void updInstLst()
        {
            installList.Items.Clear();
            installList.Text = "";
            installList.Update();

            string[] files = Directory.GetDirectories(mainDir);
            foreach (string file in files)
            {
                installList.Items.Add(Path.GetFileName(file));
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
        private void drpBxHiColr()
        {
            dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
        }

        // reset highlight dropbox function
        private void drpBxRstColr()
        {
            dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
        }

        // clear dropbox label text function
        private void clrDrpBxLbl()
        {
            dropBoxLabel.Text = "";
            dropBoxLabel.Update();
        }

        // play sound function
        private void playSfx()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream(sndPth);
            SoundPlayer p = new SoundPlayer(s);
            p.Play();
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

            drpBxHiColr();
        }

        // dropboxpicture enter
        private void dropBoxInfoPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }

            drpBxHiColr();
        }

        // dropbox leave
        private void dropBoxPanel_DragLeave(object sender, EventArgs e)
        {
            drpBxRstColr();
        }

        // dropboxpicture leave
        private void dropBoxInfoPicture_DragLeave(object sender, EventArgs e)
        {
            drpBxRstColr();
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
    }
}