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

        // form load
        private void options_Load(object sender, EventArgs e)
        {
            string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            mainDir = roamingDir + "\\.minecraft\\.cubelauncher";
        }

        // form activate
        private void options_Activated(object sender, EventArgs e)
        {
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
        }

        // buttons

        // close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}