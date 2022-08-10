using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace cubeLauncher
{
    public partial class options : Form
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

        // .cube file launcher variables
        string installName;
        string customName;
        string customVersion;
        string customWidth;
        string customHeight;
        string customArgs;

        // dynamic .cube file parser variables
        string line1_name_format;
        string line2_version_format;
        string line3_width_format;
        string line4_height_format;
        string line5_arguments_format;

        // path for sfx
        string sndPth;
        string srtSndPth = "cubeLauncher.Resources.sculk";

        // form events

        // form initialize component
        public options()
        {
            InitializeComponent();
        }

        // form activate
        private void options_Activated(object sender, EventArgs e)
        {
            // configure appdata path
            string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            mainDir = roamingDir + "\\.minecraft\\.cubelauncher";

            // configure installname
            try
            {
                installName = File.ReadAllText(mainDir + "\\conf_instname");
            }
            catch
            {
                // skip
            }

            // do not update on window refresh
            if (!File.Exists(mainDir + "\\conf_norfrsh"))
            {
                // load config.cube
                if (File.Exists(mainDir + "\\" + installName + "\\.cube\\config.cube"))
                {
                    try
                    {
                        string line1_name = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(1);
                        line1_name_format = line1_name.Replace("name: ", "");
                        customNameBox.Text = line1_name_format;
                    }
                    catch
                    {
                        // skip
                    }

                    try
                    {
                        string line2_version = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(2);
                        line2_version_format = line2_version.Replace("version: ", "");
                        customVersionBox.Text = line2_version_format;
                    }
                    catch
                    {
                        // skip
                    }

                    try
                    {
                        string line3_width = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(3);
                        line3_width_format = line3_width.Replace("width: ", "");
                        customWidthBox.Text = line3_width_format;
                    }
                    catch
                    {
                        // skip
                    }

                    try
                    {
                        string line4_height = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(4);
                        line4_height_format = line4_height.Replace("height: ", "");
                        customHeightBox.Text = line4_height_format;
                    }
                    catch
                    {
                        // skip
                    }

                    try
                    {
                        string line5_arguments = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(5);
                        line5_arguments_format = line5_arguments.Replace("arguments: ", "");
                        customArgsBox.Text = line5_arguments_format;
                    }
                    catch
                    {
                        // skip
                    }
                }
                else
                {
                    customNameBox.Text = "";
                    customVersionBox.Text = "";
                    customWidthBox.Text = "";
                    customHeightBox.Text = "";
                    customArgsBox.Text = "";
                }
            }

            // create no refresh config
            File.WriteAllText(mainDir + "\\conf_norfrsh", "");

            // show install name if it is configured
            configNameLabel.Text = installName != "" && File.Exists(mainDir + "\\conf_instname") ? "Config for \"" + installName + "\"" : "No installation is selected";

            // show launcher path if it is configured
            launcherPathLabel.Text = File.Exists(mainDir + "\\conf_lchrpth") ? File.ReadAllText(mainDir + "\\conf_lchrpth") : "Using the default path";

            // configure tooltips
            optionsToolTip.SetToolTip(closeButton, "Close");
            optionsToolTip.SetToolTip(customNameBox, "Specify the name for the launcher");
            optionsToolTip.SetToolTip(customVersionBox, "Specify the version for the launcher");
            optionsToolTip.SetToolTip(customWidthBox, "Specify the resolution width for the launcher");
            optionsToolTip.SetToolTip(customHeightBox, "Specify the resolution height for the launcher");
            optionsToolTip.SetToolTip(customArgsBox, "Specify the arguments for the launcher");
            optionsToolTip.SetToolTip(selectPathButton, "Select an alternative path for the Minecraft Launcher");
            optionsToolTip.SetToolTip(clearPathButton, "Reset the selected Minecraft Launcher path");
            lchrPthTT();

            // configure tooltip draw
            optionsToolTip.OwnerDraw = true;
            optionsToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            optionsToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(159)))));
        }

        // draw tooltips
        private void optionsToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        // buttons

        // close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(mainDir + "\\conf_norfrsh");
            }
            catch
            {
                // skip
            }

            // save config.cube

            // name
            customName = customNameBox.Text == "" ? installName : customNameBox.Text;

            // version
            customVersion = customVersionBox.Text == "" ? "latest-release" : customVersionBox.Text;

            // width
            customWidth = customWidthBox.Text == "" ? "1280" : customWidthBox.Text;

            // height
            customHeight = customHeightBox.Text == "" ? "720" : customHeightBox.Text;

            // arguments
            customArgs = customArgsBox.Text == "" ? "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M" : customArgsBox.Text;

            try
            {
                string modloader = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(6);
                string modloader_format = modloader.Replace("modloader: ", "");
                string cubeConfig = "# CUBELAUNCHER CONFIG\nname: " + customName + "\nversion: " + customVersion + "\nwidth: " + customWidth + "\nheight: " + customHeight + "\narguments: " + customArgs + "\nmodloader: " + modloader_format;
                if (File.Exists(mainDir + "\\conf_instname") && installName != "")
                {
                    Directory.CreateDirectory(mainDir + "\\" + installName + "\\.cube");
                    File.WriteAllText(mainDir + "\\" + installName + "\\.cube\\config.cube", cubeConfig);
                }
            }
            catch
            {
                // skip
            }

            this.Close();
        }

        // open path selection dialog
        private void selectPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog launcherDiag = new OpenFileDialog();
            launcherDiag.Filter = "Executable Files (*.exe)|*.exe";
            launcherDiag.FilterIndex = 1;
            launcherDiag.Multiselect = true;

            if (launcherDiag.ShowDialog() == DialogResult.OK)
            {
                string launcherPath = launcherDiag.FileName;

                launcherPathLabel.Text = launcherPath;

                try
                {
                    File.WriteAllText(mainDir + "\\conf_lchrpth", launcherPath);
                }
                catch
                {
                    // skip
                }

                lchrPthTT();
            }
        }

        // clear selected path
        private void clearPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(mainDir + "\\conf_lchrpth");
            }
            catch
            {
                // skip
            }

            optionsToolTip.SetToolTip(launcherPathLabel, "");

            launcherPathLabel.Text = "Using the default path";
        }

        // play sculk sounds on doubleclick
        private void grass2Picture_DoubleClick(object sender, EventArgs e)
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

        // move form function
        private void mvFrm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // set options tooltip function
        private void lchrPthTT()
        {
            if (File.Exists(mainDir + "\\conf_lchrpth"))
            {
                string lchrpth = File.ReadAllText(mainDir + "\\conf_lchrpth");
                optionsToolTip.SetToolTip(launcherPathLabel, lchrpth);
            }
        }

        // play sound function
        private void playSfx()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream(sndPth);
            SoundPlayer p = new SoundPlayer(s);
            p.Play();
        }

        // move form senders

        // panel sender
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        // panel icon sender
        private void iconPicture_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        // panel banner sender
        private void optionsPicture_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }
    }
}