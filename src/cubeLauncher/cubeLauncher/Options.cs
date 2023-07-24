using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using static cubeLauncher.Data.Constants;
using static cubeLauncher.Data.Structure.ConfigStructure;
using static cubeLauncher.Tools.Forms;
using static cubeLauncher.Managers.ConfigManager;

namespace cubeLauncher
{
    public partial class Options : Form
    {
        // create global variables

        // .cube file launcher variables
        string customName;
        string customVersion;
        string customWidth;
        string customHeight;
        string customArgs;

        ConfigBase config;

        public Options(ConfigBase config_)
        {
            InitializeComponent();

            config = config_;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            // load config.cube
            if (File.Exists(CUBELAUNCHER_ROOT + "\\" + config.INSTALL_NAME + "\\.cube\\config.cube"))
            {
                string[] configValue = new string[5];
                string[] configType = { "name: ", "version: ", "width: ", "height: ", "arguments: " };
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        configValue[i] = File.ReadLines(CUBELAUNCHER_ROOT + "\\" + config.INSTALL_NAME + "\\.cube\\config.cube").ElementAt(i + 1).Replace(configType[i], "");
                    }
                    catch { }
                }
                NameTextBox.Text = configValue[0];
                VersionTextBox.Text = configValue[1];
                WidthTextBox.Text = configValue[2];
                HeightTextBox.Text = configValue[3];
                ArgumentsTextBox.Text = configValue[4];
            }
            else
            {
                NameTextBox.Text = "";
                VersionTextBox.Text = "";
                WidthTextBox.Text = "";
                HeightTextBox.Text = "";
                ArgumentsTextBox.Text = "";
            }

            // show install name if it is configured
            ConfigNameLabel.Text = config.INSTALL_NAME != "" ? "Config for \"" + config.INSTALL_NAME + "\"" : "No installation is selected";

            // show launcher path if it is configured
            LauncherPathLabel.Text = config.LAUNCHER_PATH != "" ? config.LAUNCHER_PATH : "Using the default path";

            #region loadTooltips
            // bind tooltips
            string[] tooltipMap = {
                "CloseButton", "Close",
                "NamePictureBox", "Specify the name for the client",
                "NameTextBox", "Specify the name for the client",
                "VersionPictureBox", "Specify the version for the client",
                "VersionTextBox", "Specify the version for the client",
                "ResolutionPictureBox", "Specify the resolution for the client",
                "WidthTextBox", "Specify the resolution width for the client",
                "HeightTextBox", "Specify the resolution height for the client",
                "ArgumentsPictureBox", "Specify the arguments for the client",
                "ArgumentsTextBox", "Specify the arguments for the client",
                "LauncherPathPictureBox", "Specify an alternative path for the Minecraft Launcher",
                "SelectLauncherPathButton", "Specify an alternative path for the Minecraft Launcher",
                "ClearLauncherPathButton", "Reset the selected Minecraft Launcher path"
            };

            // load tooltips
            for (int i = 0; i < tooltipMap.Length; i += 2)
                OptionsToolTip.SetToolTip(Controls.Find(tooltipMap[i], true)[0], tooltipMap[i + 1]);
            UpdateLauncherPathToolTip();

            // configure tooltip draw
            OptionsToolTip.AutoPopDelay = 10000;
            OptionsToolTip.InitialDelay = 500;
            OptionsToolTip.ReshowDelay = 100;
            OptionsToolTip.OwnerDraw = true;
            OptionsToolTip.BackColor = Color.FromArgb(20, 35, 35);
            OptionsToolTip.ForeColor = Color.FromArgb(93, 183, 159);
            #endregion
        }

        private void OptionsToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // save config.cube
            customName = NameTextBox.Text == "" ? config.INSTALL_NAME : NameTextBox.Text;
            customVersion = VersionTextBox.Text == "" ? "latest-release" : VersionTextBox.Text;
            customWidth = WidthTextBox.Text == "" ? "1280" : WidthTextBox.Text;
            customHeight = HeightTextBox.Text == "" ? "720" : HeightTextBox.Text;
            customArgs = ArgumentsTextBox.Text == "" ? "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M" : ArgumentsTextBox.Text;

            try
            {
                string cubeConfig = "# CUBELAUNCHER CONFIG\nname: " + customName + "\nversion: " + customVersion + "\nwidth: " + customWidth + "\nheight: " + customHeight + "\narguments: " + customArgs + "\nmodloader: " + File.ReadLines(CUBELAUNCHER_ROOT + "\\" + config.INSTALL_NAME + "\\.cube\\config.cube").ElementAt(6).Replace("modloader: ", "");
                if (config.INSTALL_NAME != "")
                {
                    Directory.CreateDirectory(CUBELAUNCHER_ROOT + "\\" + config.INSTALL_NAME + "\\.cube");
                    File.WriteAllText(CUBELAUNCHER_ROOT + "\\" + config.INSTALL_NAME + "\\.cube\\config.cube", cubeConfig);
                }
            }
            catch { }

            WriteConfig(config, CUBELAUNCHER_ROOT + "\\config.cubefig");

            Close();
        }

        private void SelectLauncherPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog launcherDiag = new OpenFileDialog();
            launcherDiag.Filter = "Executable Files (*.exe)|*.exe";
            launcherDiag.FilterIndex = 1;
            launcherDiag.Multiselect = true;
            if (launcherDiag.ShowDialog() == DialogResult.OK)
            {
                LauncherPathLabel.Text = launcherDiag.FileName;
                config.LAUNCHER_PATH = launcherDiag.FileName;

                UpdateLauncherPathToolTip();
            }
        }

        private void ClearLauncherPathButton_Click(object sender, EventArgs e)
        {
            config.LAUNCHER_PATH = "";

            LauncherPathLabel.Text = "Using the default path";
            OptionsToolTip.SetToolTip(LauncherPathLabel, "");
        }

        private void SculkPictureBox_DoubleClick(object sender, EventArgs e)
        {
            string soundPath = "";
            const string soundPathDirectory = "cubeLauncher.Resources.sculk";

            switch (new Random().Next(1, 4))
            {
                case 1: soundPath = soundPathDirectory + "1.wav"; break;
                case 2: soundPath = soundPathDirectory + "2.wav"; break;
                case 3: soundPath = soundPathDirectory + "3.wav"; break;
            }
            PlaySFX(soundPath);
        }

        private void UpdateLauncherPathToolTip()
        {
            OptionsToolTip.SetToolTip(LauncherPathLabel, config.LAUNCHER_PATH);
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void IconPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void OptionsPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }
    }
}