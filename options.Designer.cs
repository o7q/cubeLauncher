namespace cubeLauncher
{
    partial class options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(options));
            this.customArgsBox = new System.Windows.Forms.RichTextBox();
            this.customWidthBox = new System.Windows.Forms.TextBox();
            this.customHeightBox = new System.Windows.Forms.TextBox();
            this.customNameBox = new System.Windows.Forms.TextBox();
            this.customVersionBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.namePicture = new System.Windows.Forms.PictureBox();
            this.versionPicture = new System.Windows.Forms.PictureBox();
            this.resolutionPicture = new System.Windows.Forms.PictureBox();
            this.argumentsPicture = new System.Windows.Forms.PictureBox();
            this.xPicture = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // customArgsBox
            // 
            this.customArgsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.customArgsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customArgsBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.customArgsBox.Location = new System.Drawing.Point(11, 158);
            this.customArgsBox.Name = "customArgsBox";
            this.customArgsBox.Size = new System.Drawing.Size(120, 72);
            this.customArgsBox.TabIndex = 5;
            this.customArgsBox.Text = "";
            this.customArgsBox.TextChanged += new System.EventHandler(this.customArgsBox_TextChanged);
            // 
            // customWidthBox
            // 
            this.customWidthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.customWidthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customWidthBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.customWidthBox.Location = new System.Drawing.Point(11, 126);
            this.customWidthBox.Name = "customWidthBox";
            this.customWidthBox.Size = new System.Drawing.Size(52, 13);
            this.customWidthBox.TabIndex = 3;
            this.customWidthBox.TextChanged += new System.EventHandler(this.customWidthBox_TextChanged);
            // 
            // customHeightBox
            // 
            this.customHeightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.customHeightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customHeightBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.customHeightBox.Location = new System.Drawing.Point(79, 126);
            this.customHeightBox.Name = "customHeightBox";
            this.customHeightBox.Size = new System.Drawing.Size(52, 13);
            this.customHeightBox.TabIndex = 4;
            this.customHeightBox.TextChanged += new System.EventHandler(this.customHeightBox_TextChanged);
            // 
            // customNameBox
            // 
            this.customNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.customNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customNameBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.customNameBox.Location = new System.Drawing.Point(11, 55);
            this.customNameBox.Name = "customNameBox";
            this.customNameBox.Size = new System.Drawing.Size(120, 13);
            this.customNameBox.TabIndex = 1;
            this.customNameBox.TextChanged += new System.EventHandler(this.customNameBox_TextChanged);
            // 
            // customVersionBox
            // 
            this.customVersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.customVersionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customVersionBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.customVersionBox.Location = new System.Drawing.Point(11, 90);
            this.customVersionBox.Name = "customVersionBox";
            this.customVersionBox.Size = new System.Drawing.Size(120, 13);
            this.customVersionBox.TabIndex = 2;
            this.customVersionBox.TextChanged += new System.EventHandler(this.customVersionBox_TextChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(25)))));
            this.panel.Controls.Add(this.iconPicture);
            this.panel.Controls.Add(this.closeButton);
            this.panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(25)))));
            this.panel.Location = new System.Drawing.Point(-1, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(146, 33);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // iconPicture
            // 
            this.iconPicture.BackColor = System.Drawing.Color.Transparent;
            this.iconPicture.Image = global::cubeLauncher.Properties.Resources.logo;
            this.iconPicture.Location = new System.Drawing.Point(2, 5);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(29, 27);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicture.TabIndex = 0;
            this.iconPicture.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.closeButton.Image = global::cubeLauncher.Properties.Resources.close_x;
            this.closeButton.Location = new System.Drawing.Point(117, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // namePicture
            // 
            this.namePicture.Image = global::cubeLauncher.Properties.Resources.name;
            this.namePicture.Location = new System.Drawing.Point(11, 42);
            this.namePicture.Name = "namePicture";
            this.namePicture.Size = new System.Drawing.Size(35, 10);
            this.namePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namePicture.TabIndex = 0;
            this.namePicture.TabStop = false;
            // 
            // versionPicture
            // 
            this.versionPicture.Image = global::cubeLauncher.Properties.Resources.version;
            this.versionPicture.Location = new System.Drawing.Point(11, 75);
            this.versionPicture.Name = "versionPicture";
            this.versionPicture.Size = new System.Drawing.Size(49, 13);
            this.versionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.versionPicture.TabIndex = 12;
            this.versionPicture.TabStop = false;
            // 
            // resolutionPicture
            // 
            this.resolutionPicture.Image = global::cubeLauncher.Properties.Resources.resolution;
            this.resolutionPicture.Location = new System.Drawing.Point(11, 110);
            this.resolutionPicture.Name = "resolutionPicture";
            this.resolutionPicture.Size = new System.Drawing.Size(66, 14);
            this.resolutionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resolutionPicture.TabIndex = 13;
            this.resolutionPicture.TabStop = false;
            // 
            // argumentsPicture
            // 
            this.argumentsPicture.Image = global::cubeLauncher.Properties.Resources.arguments;
            this.argumentsPicture.Location = new System.Drawing.Point(11, 145);
            this.argumentsPicture.Name = "argumentsPicture";
            this.argumentsPicture.Size = new System.Drawing.Size(66, 14);
            this.argumentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.argumentsPicture.TabIndex = 14;
            this.argumentsPicture.TabStop = false;
            // 
            // xPicture
            // 
            this.xPicture.BackColor = System.Drawing.Color.Transparent;
            this.xPicture.Image = global::cubeLauncher.Properties.Resources.close_x;
            this.xPicture.Location = new System.Drawing.Point(63, 125);
            this.xPicture.Name = "xPicture";
            this.xPicture.Size = new System.Drawing.Size(15, 15);
            this.xPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xPicture.TabIndex = 0;
            this.xPicture.TabStop = false;
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(142, 239);
            this.Controls.Add(this.xPicture);
            this.Controls.Add(this.argumentsPicture);
            this.Controls.Add(this.resolutionPicture);
            this.Controls.Add(this.versionPicture);
            this.Controls.Add(this.namePicture);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.customVersionBox);
            this.Controls.Add(this.customNameBox);
            this.Controls.Add(this.customHeightBox);
            this.Controls.Add(this.customWidthBox);
            this.Controls.Add(this.customArgsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "options";
            this.Text = "cubeLauncher Options";
            this.Activated += new System.EventHandler(this.options_Activated);
            this.Load += new System.EventHandler(this.options_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox customArgsBox;
        private System.Windows.Forms.TextBox customWidthBox;
        private System.Windows.Forms.TextBox customHeightBox;
        private System.Windows.Forms.TextBox customNameBox;
        private System.Windows.Forms.TextBox customVersionBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox namePicture;
        private System.Windows.Forms.PictureBox versionPicture;
        private System.Windows.Forms.PictureBox resolutionPicture;
        private System.Windows.Forms.PictureBox argumentsPicture;
        private System.Windows.Forms.PictureBox xPicture;
        private System.Windows.Forms.PictureBox iconPicture;
    }
}