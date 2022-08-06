﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;

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
        // dynamic .cube file parser variables
        string installName;
        string customName;
        string customVersion;
        string customWidth;
        string customHeight;
        string customArgs;

        string line1_name_format;
        string line2_version_format;
        string line3_width_format;
        string line4_height_format;
        string line5_arguments_format;
        string line6_modloader_format;

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

            installName = File.ReadAllText(mainDir + "\\config_instname");

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
            if (File.Exists(mainDir + "\\config_lchrpth"))
            {
                string lchrpth = File.ReadAllText(mainDir + "\\config_lchrpth");
                optionsToolTip.SetToolTip(launcherPathLabel, lchrpth);
            }
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
            if (customNameBox.Text == "")
            {
                customName = "UNNAMED";
            }
            else
            {
                customName = customNameBox.Text;
            }

            if (customVersionBox.Text == "")
            {
                customVersion = "latest-release";
            }
            else
            {
                customVersion = customVersionBox.Text;
            }

            if (customWidthBox.Text == "")
            {
                customWidth = "1280";
            }
            else
            {
                customWidth = customWidthBox.Text;
            }

            if (customHeightBox.Text == "")
            {
                customHeight = "720";
            }
            else
            {
                customHeight = customHeightBox.Text;
            }

            if (customArgsBox.Text == "")
            {
                customArgs = "-Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M";
            }
            else
            {
                customArgs = customArgsBox.Text;
            }

            try
            {
                string cubeConfig = "# CUBELAUNCHER OVERRIDE CONFIG\nname: " + customName + "\nversion: " + customVersion + "\nwidth: " + customWidth + "\nheight: " + customHeight + "\narguments: " + customArgs + "\nmodloader: ";
                if (installName != "")
                {
                    Directory.CreateDirectory(mainDir + "\\" + installName + "\\.cube");
                    File.WriteAllText(mainDir + "\\" + installName + "\\.cube\\config.cube", cubeConfig);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error: Unable to save \"config.cube\"!\n\nFull Error:\n" + ex);
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

                if (File.Exists(mainDir + "\\config_lchrpth"))
                {
                    string lchrpth = File.ReadAllText(mainDir + "\\config_lchrpth");
                    optionsToolTip.SetToolTip(launcherPathLabel, lchrpth);
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

            if (customArgsBox.Text == "")
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

        private void loadConfigButton_Click(object sender, EventArgs e)
        {
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
        }
    }
}