using System;
using System.IO;
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

        // configure path variables
        string mainDir;

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

            launcherPathLabel.Text = "";

            if (File.Exists(mainDir + "\\" + "config_ovrcube"))
            {
                overrideCubeCheckbox.Checked = true;
            }

            // load configs into memory
            if (File.Exists(mainDir + "\\config_name"))
            {
                string config_name = File.ReadAllText(mainDir + "\\config_name");
                customNameBox.Text = config_name;
            }

            if (File.Exists(mainDir + "\\config_ver"))
            {
                string config_ver = File.ReadAllText(mainDir + "\\config_ver");
                customVersionBox.Text = config_ver;
            }

            if (File.Exists(mainDir + "\\config_x"))
            {
                string config_x = File.ReadAllText(mainDir + "\\config_x");
                customWidthBox.Text = config_x;
            }

            if (File.Exists(mainDir + "\\config_y"))
            {
                string config_y = File.ReadAllText(mainDir + "\\config_y");
                customHeightBox.Text = config_y;
            }

            if (File.Exists(mainDir + "\\config_args"))
            {
                string config_args = File.ReadAllText(mainDir + "\\config_args");
                customArgsBox.Text = config_args;
            }

            if (File.Exists(mainDir + "\\config_lchrpth"))
            {
                string config_lchrpth = File.ReadAllText(mainDir + "\\config_lchrpth");
                launcherPathLabel.Text = config_lchrpth;
            }

            // configure tooltips
            optionsToolTip.SetToolTip(closeButton, "Close");
            optionsToolTip.SetToolTip(customNameBox, "Specify the name override for the launcher");
            optionsToolTip.SetToolTip(customVersionBox, "Specify the version override for the launcher");
            optionsToolTip.SetToolTip(customWidthBox, "Specify the resolution width override for the launcher");
            optionsToolTip.SetToolTip(customHeightBox, "Specify the resolution height version override for the launcher");
            optionsToolTip.SetToolTip(customArgsBox, "Specify the argument override for the launcher");
            string ovrCubeChkTT = "Override the .cube override config";
            optionsToolTip.SetToolTip(overrideCubeCheckbox, ovrCubeChkTT);
            optionsToolTip.SetToolTip(overrideCubePicture, ovrCubeChkTT);
            optionsToolTip.SetToolTip(createConfigButton, "Create a blank .cube file and directory next to \"cubeLauncher.exe\"");
            optionsToolTip.SetToolTip(selectPathButton, "Select an alternative path for the Minecraft Launcher");
            optionsToolTip.SetToolTip(clearPathButton, "Reset the selected Minecraft Launcher path");
            optionsToolTip.SetToolTip(launcherPathLabel, "Currently selected Minecraft Launcher path");
        }

        // buttons

        // close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ignore .cube file checkbox
        private void overrideCubeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (overrideCubeCheckbox.Checked == true)
            {
                File.WriteAllText(mainDir + "\\" + "config_ovrcube", "");
            }
            else
            {
                File.Delete(mainDir + "\\" + "config_ovrcube");
            }
        }

        // change checkbox state on click
        private void overrideCubePicture_Click(object sender, EventArgs e)
        {
            if (!overrideCubeCheckbox.Checked == true)
            {
                overrideCubeCheckbox.Checked = true;
            }
            else
            {
                overrideCubeCheckbox.Checked = false;
            }
        }

        // create config button
        private void createConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cubeConfig = "# CUBELAUNCHER OVERRIDE CONFIG\nname: \nversion: \nwidth: \nheight: \narguments: \nmodloader: ";
                Directory.CreateDirectory(".cube");
                File.WriteAllText(".cube\\config.cube", cubeConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error: Unable to create \".cube Config\"!\n\nFull Error:\n" + ex);
            }
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
                    File.WriteAllText(mainDir + "\\config_lchrpth", launcherPath);
                }
                catch
                {
                    // skip
                }
            }
        }

        // clear selected path
        private void clearPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(mainDir + "\\config_lchrpth");
            }
            catch
            {
                // skip
            }

            launcherPathLabel.Text = "";
        }

        // config textboxes

        // name textbox
        private void customNameBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(mainDir + "\\config_name", customNameBox.Text);

            if (customNameBox.Text == "")
            {
                try
                {
                    File.Delete(mainDir + "\\config_name");
                }
                catch
                {
                    // skip
                }
            }
        }

        // version textbox
        private void customVersionBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(mainDir + "\\config_ver", customVersionBox.Text);

            if (customVersionBox.Text == "")
            {
                try
                {
                    File.Delete(mainDir + "\\config_ver");
                }
                catch
                {
                    // skip
                }
            }
        }

        // width textbox
        private void customWidthBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(mainDir + "\\config_x", customWidthBox.Text);

            if (customWidthBox.Text == "")
            {
                try
                {
                    File.Delete(mainDir + "\\config_x");
                }
                catch
                {
                    // skip
                }
            }
        }

        // height textbox
        private void customHeightBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(mainDir + "\\config_y", customHeightBox.Text);

            if (customHeightBox.Text == "")
            {
                try
                {
                    File.Delete(mainDir + "\\config_y");
                }
                catch
                {
                    // skip
                }
            }
        }

        // arguments textbox
        private void customArgsBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(mainDir + "\\config_args", customArgsBox.Text);

            if(customArgsBox.Text == "")
            {
                try
                {
                    File.Delete(mainDir + "\\config_args");
                }
                catch
                {
                    // skip
                }
            }
        }

        //functions

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

        // panel sender
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }

        // icon sender
        private void iconPicture_MouseDown(object sender, MouseEventArgs e)
        {
            mvFrm(e);
        }
    }
}