using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cubeLauncher
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }

        string mainDir;

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

        private void options_Load(object sender, EventArgs e)
        {
            string roamingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            mainDir = roamingDir + "\\.minecraft\\.cubelauncher";
        }
    }
}