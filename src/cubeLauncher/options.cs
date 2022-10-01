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

        // path for sfx
        string sndPth;
        const string srtSndPth = "cubeLauncher.Resources.sculk";

        // create refresh bool
        bool refresh = true;

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
            try { installName = File.ReadAllText(mainDir + "\\cfg_instname"); } catch { }

            // do not update on window refresh
            if (refresh == true)
            {
                // load config.cube
                if (File.Exists(mainDir + "\\" + installName + "\\.cube\\config.cube"))
                {
                    string[] componentObj = new string[5];
                    string[] componentTxt = { "name: ", "version: ", "width: ", "height: ", "arguments: " };
                    for (int i = 0; i < 5; i++)
                    {
                        try { componentObj[i] = File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(i + 1).Replace(componentTxt[i], ""); } catch { }
                    }
                    customNameBox.Text = componentObj[0];
                    customVersionBox.Text = componentObj[1];
                    customWidthBox.Text = componentObj[2];
                    customHeightBox.Text = componentObj[3];
                    customArgsBox.Text = componentObj[4];
                }
                else
                {
                    customNameBox.Text = "";
                    customVersionBox.Text = "";
                    customWidthBox.Text = "";
                    customHeightBox.Text = "";
                    customArgsBox.Text = "";
                }

                refresh = false;
            }

            // show install name if it is configured
            configNameLabel.Text = installName != "" && File.Exists(mainDir + "\\cfg_instname") ? "Config for \"" + installName + "\"" : "No installation is selected";

            // show launcher path if it is configured
            try { launcherPathLabel.Text = File.Exists(mainDir + "\\cfg_lchrpth") ? File.ReadAllText(mainDir + "\\cfg_lchrpth") : "Using the default path"; } catch { }

            #region tooltipDictionary

            // configure variables
            string nTT = "Specify the name for the client";
            string vTT = "Specify the version for the client";
            string aTT = "Specify the arguments for the client";
            string pTT = "Specify an alternative path for the Minecraft Launcher";

            // components
            var component = new Control[]
            {
                closeButton,
                namePicture,
                customNameBox,
                versionPicture,
                customVersionBox,
                resolutionPicture,
                customWidthBox,
                customHeightBox,
                argumentsPicture,
                customArgsBox,
                launcherPathPicture,
                selectPathButton,
                clearPathButton
            };

            // tooltips
            string[] tooltip =
            {
                "Close",
                nTT,
                nTT,
                vTT,
                vTT,
                "Specify the resolution for the client",
                "Specify the resolution width for the client",
                "Specify the resolution height for the client",
                aTT,
                aTT,
                pTT,
                pTT,
                "Reset the selected Minecraft Launcher path"
            };

            #endregion

            // configure tooltips
            for (int i = 0; i < 13; i++) optionsToolTip.SetToolTip(component[i], tooltip[i]);
            lchrPthTT();

            // configure tooltip draw
            optionsToolTip.AutoPopDelay = 10000;
            optionsToolTip.OwnerDraw = true;
            optionsToolTip.BackColor = System.Drawing.Color.FromArgb(20, 35, 35);
            optionsToolTip.ForeColor = System.Drawing.Color.FromArgb(93, 183, 159);
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
            // save config.cube
            customName = customNameBox.Text == "" ? installName : customNameBox.Text;
            customVersion = customVersionBox.Text == "" ? "latest-release" : customVersionBox.Text;
            customWidth = customWidthBox.Text == "" ? "1280" : customWidthBox.Text;
            customHeight = customHeightBox.Text == "" ? "720" : customHeightBox.Text;
            customArgs = customArgsBox.Text == "" ? "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M" : customArgsBox.Text;

            try
            {
                string cubeConfig = "# CUBELAUNCHER CONFIG\nname: " + customName + "\nversion: " + customVersion + "\nwidth: " + customWidth + "\nheight: " + customHeight + "\narguments: " + customArgs + "\nmodloader: " + File.ReadLines(mainDir + "\\" + installName + "\\.cube\\config.cube").ElementAt(6).Replace("modloader: ", "");
                if (File.Exists(mainDir + "\\cfg_instname") && installName != "")
                {
                    Directory.CreateDirectory(mainDir + "\\" + installName + "\\.cube");
                    File.WriteAllText(mainDir + "\\" + installName + "\\.cube\\config.cube", cubeConfig);
                }
            }
            catch { }

            Close();
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
                launcherPathLabel.Text = launcherDiag.FileName;
                try { File.WriteAllText(mainDir + "\\cfg_lchrpth", launcherDiag.FileName); } catch { }

                lchrPthTT();
            }
        }

        // clear selected path
        private void clearPathButton_Click(object sender, EventArgs e)
        {
            try { File.Delete(mainDir + "\\cfg_lchrpth"); } catch { }

            launcherPathLabel.Text = "Using the default path";
            optionsToolTip.SetToolTip(launcherPathLabel, "");
        }

        // play sculk sounds on doubleclick
        private void grass2Picture_DoubleClick(object sender, EventArgs e)
        {
            switch (new Random().Next(1, 4))
            {
                case 1:
                    sndPth = srtSndPth + "1.wav";
                    break;
                case 2:
                    sndPth = srtSndPth + "2.wav";
                    break;
                case 3:
                    sndPth = srtSndPth + "3.wav";
                    break;
            }
            playSfx();
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
            if (File.Exists(mainDir + "\\cfg_lchrpth")) optionsToolTip.SetToolTip(launcherPathLabel, File.ReadAllText(mainDir + "\\cfg_lchrpth"));
        }

        // play sound function
        private void playSfx()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            Stream s = a.GetManifestResourceStream(sndPth);
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