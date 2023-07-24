using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static cubeLauncher.Tools.Forms;
using static cubeLauncher.Data.Constants;
using static cubeLauncher.Managers.ConfigManager;
using static cubeLauncher.Data.Structure.ConfigStructure;

namespace cubeLauncher
{
    public partial class Program : Form
    {
        // create global variables

        // path variables
        string installName;
        string installPath;
        string creationPath;

        // dynamic json parser variables
        string jsonName;
        string jsonVersion;
        int jsonWidth;
        int jsonHeight;
        string jsonArguments;

        ConfigBase config = new ConfigBase();

        public Program()
        {
            InitializeComponent();
        }

        private void Program_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                DialogResult prompt = MessageBox.Show("An instance of cubeLauncher is already running.\nHaving two or more instances of cubeLauncher running simultaneously can cause issues (file corruption, malfunctioning).\n\nAre you sure you want to continue?", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.No)
                    Environment.Exit(0);
            }

            // create the main directory
            Directory.CreateDirectory(CUBELAUNCHER_ROOT);

            // try to make a backup of launcher profiles
            try
            {
                File.Copy(MINECRAFT_ROOT + "\\launcher_profiles.json", CUBELAUNCHER_ROOT + "\\launcher_profiles_bak.json");
            }
            catch { }

            // try to make a second backup of launcher profiles
            if (!File.Exists(CUBELAUNCHER_ROOT + "\\launcher_profiles_bak2.json"))
            {
                try
                {
                    File.Copy(MINECRAFT_ROOT + "\\launcher_profiles.json", CUBELAUNCHER_ROOT + "\\launcher_profiles_bak2.json");
                }
                catch { }
            }

            // update install list
            UpdateInstallList();

            // enable folder dropping
            DropBoxPanel.AllowDrop = true;
            DropBoxInfoPictureBox.AllowDrop = true;

            // configure drop box label
            DropBoxLabel.BringToFront();
            ShowMessage(DropBoxLabel, "");
            DropBoxLabel.Update();

            if (File.Exists(CUBELAUNCHER_ROOT + "\\config.cubefig"))
                config = ReadConfig(CUBELAUNCHER_ROOT + "\\config.cubefig");

            // load last client session
            InstallListBox.Text = config.INSTALL_NAME;

            #region loadTooltips
            // bind tooltips
            string[] tooltipMap = {
                "TitlebarPanel", "cubeLauncher by o7q",
                "TitlebarVersionPictureBox", "Running " + VERSION,
                "MinimizeButton", "Minimize",
                "CloseButton", "Close",
                "DropBoxPanel", "Drag and drop a folder to install",
                "DropBoxInfoPictureBox", "Drag and drop a folder to install",
                "GrassPictureBox", "Drag and drop a folder to install",
                "DropBoxLabel", "Output message",
                "InstallListBox", "Currently selected installation - Clicking the arrow will show a list of all installations",
                "CreateInstallButton", "Create a blank installation - Specify the name in the textbox to the left",
                "DeleteInstallButton", "Remove the selected installation",
                "OpenPathButton", "Open the folder path of the selected installation",
                "OpenOptionsButton", "Open the options window",
                "LaunchButton", "Launch the selected installation with the specified options"
            };

            // load tooltips
            for (int i = 0; i < tooltipMap.Length; i += 2)
                ProgramToolTip.SetToolTip(Controls.Find(tooltipMap[i], true)[0], tooltipMap[i + 1]);

            // configure tooltip draw
            ProgramToolTip.AutoPopDelay = 10000;
            ProgramToolTip.InitialDelay = 500;
            ProgramToolTip.ReshowDelay = 100;
            ProgramToolTip.OwnerDraw = true;
            ProgramToolTip.BackColor = Color.FromArgb(30, 45, 30);
            ProgramToolTip.ForeColor = Color.FromArgb(123, 183, 93);
            #endregion
        }

        private void ProgramToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void Program_FormClosing(object sender, FormClosingEventArgs e)
        {
            // try to restore launcher profiles
            if (File.Exists(CUBELAUNCHER_ROOT + "\\" + "launcher_profiles_bak.json"))
            {
                try
                {
                    File.WriteAllText(MINECRAFT_ROOT + "\\launcher_profiles.json", File.ReadAllText(CUBELAUNCHER_ROOT + "\\launcher_profiles_bak.json"));
                    File.Delete(CUBELAUNCHER_ROOT + "\\launcher_profiles_bak.json");
                }
                catch { }
            }
        }

        private void CreateInstallButton_Click(object sender, EventArgs e)
        {
            if (InstallListBox.Text != "")
            {
                if (!Directory.Exists(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text))
                {
                    try
                    {
                        Directory.CreateDirectory(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text);

                        ShowMessage(DropBoxLabel, "Created \"" + InstallListBox.Text + "\" successfully");
                        UpdateInstallList();
                    }
                    catch (Exception ex) { MessageBox.Show("Unknown Error: Unable to create \"" + InstallListBox.Text + "\"!\n\nFull Error:\n" + ex); }
                }
                else ShowMessage(DropBoxLabel, "\"" + InstallListBox.Text + "\" already exists");
            }
            else ShowMessage(DropBoxLabel, "Please specify a name");
        }

        private void DeleteInstallButton_Click(object sender, EventArgs e)
        {
            if (InstallListBox.Text != "")
            {
                ShowMessage(DropBoxLabel, "");

                // prompt user when removing installation
                DialogResult prompt = MessageBox.Show("Are you sure you want to remove \"" + InstallListBox.Text + "\"?\nAll data (worlds, options, etc.) will be removed for that installation.", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    if (Directory.Exists(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text))
                    {
                        // try to delete installation and update labels
                        try
                        {
                            Directory.Delete(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text, true);

                            ShowMessage(DropBoxLabel, "Removed \"" + InstallListBox.Text + "\" successfully");
                            UpdateInstallList();
                            try
                            {
                                InstallListBox.SelectedIndex = 0;
                            }
                            catch { }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unknown Error: Unable to remove \"" + InstallListBox.Text + "\"!\n\nFull Error:\n" + ex);
                            UpdateInstallList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Directory does not exist.");
                        UpdateInstallList();
                    }
                }
            }
            else
            {
                ShowMessage(DropBoxLabel, "No installation is selected");
            }
        }

        private void OpenPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error: Unable to open \"" + InstallListBox.Text + "\"!\n\nFull Error:\n" + ex);
            }
        }

        private void OpenOptionsButton_Click(object sender, EventArgs e)
        {
            if (InstallListBox.Text == "")
            {
                ShowMessage(DropBoxLabel, "No installation is selected");
                return;
            }

            if (!File.Exists(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text + "\\.cube\\config.cube") && InstallListBox.Text != "")
            {
                try
                {
                    Directory.CreateDirectory(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text + "\\.cube");
                    File.WriteAllText(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text + "\\.cube\\config.cube", "# CUBELAUNCHER CONFIG\nname: " + InstallListBox.Text + "\nversion: latest-release\nwidth: 1280\nheight: 720\narguments: -Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M\nmodloader: ");
                }
                catch { }
            }

            // open options form
            Options options_form = new Options(config);
            options_form.ShowDialog();

            config = ReadConfig(CUBELAUNCHER_ROOT + "\\config.cubefig");
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            bool isProgramOpen = false;
            foreach (Process isProgramOpenCheck in Process.GetProcesses())
                if (isProgramOpenCheck.ProcessName.Contains("Minecraft"))
                    isProgramOpen = true;
            if (isProgramOpen == false)
            {
                if (InstallListBox.Text != "")
                {
                    ShowMessage(DropBoxLabel, "");

                    // load from config.cube if it exists
                    if (File.Exists(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text + "\\.cube\\config.cube"))
                    {
                        string[] configValue = new string[5];
                        string[] configType = { "name: ", "version: ", "width: ", "height: ", "arguments: " };
                        for (int i = 0; i <= 4; i++)
                        {
                            try
                            {
                                configValue[i] = File.ReadLines(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text + "\\.cube\\config.cube").ElementAt(i + 1).Replace(configType[i], "");
                            }
                            catch { }
                        }
                        jsonName = configValue[0];
                        jsonVersion = configValue[1];
                        jsonWidth = int.Parse(configValue[2]);
                        jsonHeight = int.Parse(configValue[3]);
                        jsonArguments = configValue[4];
                    }
                    else
                    {
                        jsonName = InstallListBox.Text;
                        jsonVersion = "latest-release";
                        jsonWidth = 1280;
                        jsonHeight = 720;
                        jsonArguments = "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M";
                    }

                    // configure launch variables
                    string path = Path.GetFullPath(CUBELAUNCHER_ROOT + "\\" + InstallListBox.Text).Replace("\\", "\\\\");
                    string launchProfile = Properties.Resources.launchProfileBase;
                    launchProfile = launchProfile.Replace("__PATH__", path);
                    launchProfile = launchProfile.Replace("__ARGUMENTS__", jsonArguments);
                    launchProfile = launchProfile.Replace("__VERSION__", jsonVersion);
                    launchProfile = launchProfile.Replace("__NAME__", jsonName);
                    launchProfile = launchProfile.Replace("__HEIGHT__", jsonHeight.ToString());
                    launchProfile = launchProfile.Replace("__WIDTH__", jsonWidth.ToString());

                    // write launcher profile data
                    try { File.WriteAllText(MINECRAFT_ROOT + "\\" + "launcher_profiles.json", launchProfile); } catch { }

                    // attempt to launch the minecraft launcher
                    if (config.LAUNCHER_PATH != "" && config.LAUNCHER_PATH != null)
                    {
                        try
                        {
                            Process.Start(config.LAUNCHER_PATH);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unknown Error: Unable to start the specified launcher!\n\nFull Error:\n" + ex);
                        }
                    }
                    else if (File.Exists(@"C:\Program Files (x86)\Minecraft Launcher\MinecraftLauncher.exe"))
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
                    else if (File.Exists(@"C:\XboxGames\Minecraft Launcher\Content\Minecraft.exe"))
                    {
                        try
                        {
                            Process.Start(@"C:\XboxGames\Minecraft Launcher\Content\Minecraft.exe");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unknown Error: Unable to start \"MinecraftLauncher.exe\"!\n\nFull Error:\n" + ex);
                        }
                    }
                    else
                        MessageBox.Show("Error: \"MinecraftLauncher.exe\" was not found.\nBy default it is installed to \"C:\\Program Files (x86)\\Minecraft Launcher\\MinecraftLauncher.exe\"\nOR\n\"C:\\XboxGames\\Minecraft Launcher\\Content\\Minecraft.exe\"\n\n* In the options menu you can specify a new launcher path if your launcher is not in the standard directory.");
                }
                else ShowMessage(DropBoxLabel, "No installation is selected");
            }
            else ShowMessage(DropBoxLabel, "Minecraft is already running");
        }

        private void InstallModpack(DragEventArgs e)
        {
            ResetPanelColor(DropBoxPanel);

            foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop, false)) installPath = path;

            installName = new DirectoryInfo(installPath).Name;
            creationPath = CUBELAUNCHER_ROOT + "\\" + installName;

            // prompt user before overwriting installation
            if (Directory.Exists(CUBELAUNCHER_ROOT + "\\" + installName))
            {
                ResetPanelColor(DropBoxPanel);
                DialogResult prompt = MessageBox.Show("Are you sure you want to reinstall \"" + installName + "\"?\n\nAn installation with that name already exists and it will be reinstalled resulting in all data (worlds, options, etc.) being removed.\n\nOtherwise you can merge the installation which will preserve unchanged data.\n\nYes = Reinstall\nNo = Merge\nCancel = Do nothing", "", MessageBoxButtons.YesNoCancel);
                if (prompt == DialogResult.Yes)
                {
                    try { Directory.Delete(CUBELAUNCHER_ROOT + "\\" + installName, true); } catch (Exception ex) { MessageBox.Show("Unknown Error: Unable to remove \"" + installName + "\"!\n\nFull Error:\n" + ex); }

                    CopyFiles();

                    ShowMessage(DropBoxLabel, "Reinstalled \"" + installName + "\" successfully");
                }
                else if (prompt == DialogResult.No)
                    ShowMessage(DropBoxLabel, "Merged \"" + installName + "\" successfully");
            }
            else CopyFiles();
        }

        private void CopyFiles()
        {
            // try to execute install script
            try
            {
                ShowMessage(DropBoxLabel, "Installing \"" + installName + "\"");

                Parallel.ForEach(Directory.GetFileSystemEntries(installPath, "*", SearchOption.AllDirectories), (fileDir) =>
                {
                    string outputDir = Regex.Replace(fileDir, "^" + Regex.Escape(installPath), creationPath);
                    if (File.Exists(fileDir))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(outputDir));
                        File.Copy(fileDir, outputDir, true);
                    }
                    else Directory.CreateDirectory(outputDir);
                }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error: Unable to install \"" + installName + "\"!\n\nFull Error:\n" + ex);
                ShowMessage(DropBoxLabel, "");
                UpdateInstallList();
                InstallListBox.Text = "";

                return;
            }

            UpdateInstallList();

            StartModLoader();

            InstallListBox.Text = installName;
            ShowMessage(DropBoxLabel, "Installed \"" + installName + "\" successfully");
        }

        private void StartModLoader()
        {
            // check if config.cube exists, if it does, prompt the user if they want to install the available modloader
            if (File.Exists(CUBELAUNCHER_ROOT + "\\" + installName + "\\.cube\\config.cube"))
            {
                DialogResult prompt = MessageBox.Show("Found a modloader for \"" + installName + "\".\nDo you want to install it?", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    try
                    {
                        Process.Start(CUBELAUNCHER_ROOT + "\\" + installName + "\\.cube\\" + File.ReadLines(CUBELAUNCHER_ROOT + "\\" + installName + "\\.cube\\config.cube").ElementAt(6).Replace("modloader: ", ""));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown Error: Unable to start \"" + File.ReadLines(CUBELAUNCHER_ROOT + "\\" + installName + "\\.cube\\config.cube").ElementAt(6).Replace("modloader: ", "") + "\"!\n\nFull Error:\n" + ex);
                    }
                }
            }
        }

        private void UpdateInstallList()
        {
            InstallListBox.Items.Clear();
            InstallListBox.Text = "";
            InstallListBox.Update();

            foreach (string file in Directory.GetDirectories(CUBELAUNCHER_ROOT))
                InstallListBox.Items.Add(Path.GetFileName(file));
        }

        private void InstallListBox_DropDown(object sender, EventArgs e)
        {
            ShowMessage(DropBoxLabel, "");
        }

        private void InstallListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.INSTALL_NAME = InstallListBox.Text;
        }

        // drag drop events

        // dropbox drop
        private void DropBoxPanel_DragDrop(object sender, DragEventArgs e)
        {
            InstallModpack(e);
        }

        // dropbox enter
        private void DropBoxPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
            HighlightPanelColor(DropBoxPanel);
        }
        // dropbox leave
        private void DropBoxPanel_DragLeave(object sender, EventArgs e)
        {
            ResetPanelColor(DropBoxPanel);
        }

        // dropboxpicture drop
        private void DropBoxInfoPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            InstallModpack(e);
        }

        // dropboxpicture enter
        private void DropBoxInfoPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
            HighlightPanelColor(DropBoxPanel);
        }

        // dropboxpicture leave
        private void DropBoxInfoPictureBox_DragLeave(object sender, EventArgs e)
        {
            ResetPanelColor(DropBoxPanel);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            WriteConfig(config, CUBELAUNCHER_ROOT + "\\config.cubefig");
            Close();
        }

        private void GrassPictureBox_DoubleClick(object sender, EventArgs e)
        {
            string soundPath = "";
            const string soundPathDirectory = "cubeLauncher.Resources.grass";
            switch (new Random().Next(1, 4))
            {
                case 1: soundPath = soundPathDirectory + "1.wav"; break;
                case 2: soundPath = soundPathDirectory + "2.wav"; break;
                case 3: soundPath = soundPathDirectory + "3.wav"; break;
            }
            PlaySFX(soundPath);
        }

        int toggle;
        private void TitlebarPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2 && toggle == 0)
            {
                MessageBox.Show(Properties.Resources.infoText);
                toggle = 1;
            }
            else if (e.Button == MouseButtons.Left && e.Clicks == 2 && toggle == 1)
            {
                Process.Start("https://github.com/o7q/cubeLauncher");
                toggle = 0;
            }

            MoveForm(Handle, e);
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void TitlebarVersionPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void TitlebarCreditPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }
    }
}