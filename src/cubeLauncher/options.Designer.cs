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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(options));
            this.customWidthBox = new System.Windows.Forms.TextBox();
            this.customHeightBox = new System.Windows.Forms.TextBox();
            this.customNameBox = new System.Windows.Forms.TextBox();
            this.customVersionBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.optionsPicture = new System.Windows.Forms.PictureBox();
            this.launcherPathLabel = new System.Windows.Forms.Label();
            this.optionsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.configNameLabel = new System.Windows.Forms.Label();
            this.customArgsBox = new System.Windows.Forms.TextBox();
            this.grass2Picture = new System.Windows.Forms.PictureBox();
            this.clearPathButton = new System.Windows.Forms.Button();
            this.selectPathButton = new System.Windows.Forms.Button();
            this.launcherPathPicture = new System.Windows.Forms.PictureBox();
            this.xPicture = new System.Windows.Forms.PictureBox();
            this.argumentsPicture = new System.Windows.Forms.PictureBox();
            this.resolutionPicture = new System.Windows.Forms.PictureBox();
            this.versionPicture = new System.Windows.Forms.PictureBox();
            this.namePicture = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.launcherPathPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // customWidthBox
            // 
            this.customWidthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.customWidthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customWidthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.customWidthBox.Location = new System.Drawing.Point(11, 127);
            this.customWidthBox.Name = "customWidthBox";
            this.customWidthBox.Size = new System.Drawing.Size(45, 13);
            this.customWidthBox.TabIndex = 3;
            // 
            // customHeightBox
            // 
            this.customHeightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.customHeightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customHeightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.customHeightBox.Location = new System.Drawing.Point(71, 127);
            this.customHeightBox.Name = "customHeightBox";
            this.customHeightBox.Size = new System.Drawing.Size(45, 13);
            this.customHeightBox.TabIndex = 4;
            // 
            // customNameBox
            // 
            this.customNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.customNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.customNameBox.Location = new System.Drawing.Point(11, 62);
            this.customNameBox.Name = "customNameBox";
            this.customNameBox.Size = new System.Drawing.Size(105, 13);
            this.customNameBox.TabIndex = 1;
            // 
            // customVersionBox
            // 
            this.customVersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.customVersionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customVersionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.customVersionBox.Location = new System.Drawing.Point(11, 94);
            this.customVersionBox.Name = "customVersionBox";
            this.customVersionBox.Size = new System.Drawing.Size(105, 13);
            this.customVersionBox.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.panel.Controls.Add(this.iconPicture);
            this.panel.Controls.Add(this.closeButton);
            this.panel.Controls.Add(this.optionsPicture);
            this.panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(25)))));
            this.panel.Location = new System.Drawing.Point(-1, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(130, 33);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // iconPicture
            // 
            this.iconPicture.BackColor = System.Drawing.Color.Transparent;
            this.iconPicture.Image = global::cubeLauncher.Properties.Resources.logo_options;
            this.iconPicture.Location = new System.Drawing.Point(2, 5);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(29, 27);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicture.TabIndex = 0;
            this.iconPicture.TabStop = false;
            this.iconPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconPicture_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(107)))), ((int)(((byte)(69)))));
            this.closeButton.Image = global::cubeLauncher.Properties.Resources.close_x_options;
            this.closeButton.Location = new System.Drawing.Point(101, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // optionsPicture
            // 
            this.optionsPicture.Image = ((System.Drawing.Image)(resources.GetObject("optionsPicture.Image")));
            this.optionsPicture.Location = new System.Drawing.Point(31, 13);
            this.optionsPicture.Name = "optionsPicture";
            this.optionsPicture.Size = new System.Drawing.Size(50, 13);
            this.optionsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optionsPicture.TabIndex = 0;
            this.optionsPicture.TabStop = false;
            this.optionsPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionsPicture_MouseDown);
            // 
            // launcherPathLabel
            // 
            this.launcherPathLabel.AutoSize = true;
            this.launcherPathLabel.BackColor = System.Drawing.Color.Transparent;
            this.launcherPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launcherPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(103)))));
            this.launcherPathLabel.Location = new System.Drawing.Point(8, 223);
            this.launcherPathLabel.MaximumSize = new System.Drawing.Size(110, 15);
            this.launcherPathLabel.Name = "launcherPathLabel";
            this.launcherPathLabel.Size = new System.Drawing.Size(110, 12);
            this.launcherPathLabel.TabIndex = 0;
            this.launcherPathLabel.Text = "_____________________";
            // 
            // optionsToolTip
            // 
            this.optionsToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.optionsToolTip_Draw);
            // 
            // configNameLabel
            // 
            this.configNameLabel.AutoSize = true;
            this.configNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.configNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(103)))));
            this.configNameLabel.Location = new System.Drawing.Point(8, 174);
            this.configNameLabel.MaximumSize = new System.Drawing.Size(110, 15);
            this.configNameLabel.Name = "configNameLabel";
            this.configNameLabel.Size = new System.Drawing.Size(110, 12);
            this.configNameLabel.TabIndex = 0;
            this.configNameLabel.Text = "_____________________";
            // 
            // customArgsBox
            // 
            this.customArgsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.customArgsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customArgsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.customArgsBox.Location = new System.Drawing.Point(11, 160);
            this.customArgsBox.Name = "customArgsBox";
            this.customArgsBox.Size = new System.Drawing.Size(105, 13);
            this.customArgsBox.TabIndex = 5;
            // 
            // grass2Picture
            // 
            this.grass2Picture.BackColor = System.Drawing.Color.Transparent;
            this.grass2Picture.Image = ((System.Drawing.Image)(resources.GetObject("grass2Picture.Image")));
            this.grass2Picture.Location = new System.Drawing.Point(0, 30);
            this.grass2Picture.Name = "grass2Picture";
            this.grass2Picture.Size = new System.Drawing.Size(129, 18);
            this.grass2Picture.TabIndex = 0;
            this.grass2Picture.TabStop = false;
            this.grass2Picture.DoubleClick += new System.EventHandler(this.grass2Picture_DoubleClick);
            // 
            // clearPathButton
            // 
            this.clearPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.clearPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(107)))), ((int)(((byte)(69)))));
            this.clearPathButton.Image = global::cubeLauncher.Properties.Resources.close_x_options;
            this.clearPathButton.Location = new System.Drawing.Point(94, 203);
            this.clearPathButton.Name = "clearPathButton";
            this.clearPathButton.Size = new System.Drawing.Size(20, 20);
            this.clearPathButton.TabIndex = 7;
            this.clearPathButton.UseVisualStyleBackColor = false;
            this.clearPathButton.Click += new System.EventHandler(this.clearPathButton_Click);
            // 
            // selectPathButton
            // 
            this.selectPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.selectPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(107)))), ((int)(((byte)(69)))));
            this.selectPathButton.Image = ((System.Drawing.Image)(resources.GetObject("selectPathButton.Image")));
            this.selectPathButton.Location = new System.Drawing.Point(11, 203);
            this.selectPathButton.Name = "selectPathButton";
            this.selectPathButton.Size = new System.Drawing.Size(84, 20);
            this.selectPathButton.TabIndex = 6;
            this.selectPathButton.UseVisualStyleBackColor = false;
            this.selectPathButton.Click += new System.EventHandler(this.selectPathButton_Click);
            // 
            // launcherPathPicture
            // 
            this.launcherPathPicture.BackColor = System.Drawing.Color.Transparent;
            this.launcherPathPicture.Image = ((System.Drawing.Image)(resources.GetObject("launcherPathPicture.Image")));
            this.launcherPathPicture.Location = new System.Drawing.Point(11, 188);
            this.launcherPathPicture.Name = "launcherPathPicture";
            this.launcherPathPicture.Size = new System.Drawing.Size(104, 17);
            this.launcherPathPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.launcherPathPicture.TabIndex = 0;
            this.launcherPathPicture.TabStop = false;
            // 
            // xPicture
            // 
            this.xPicture.BackColor = System.Drawing.Color.Transparent;
            this.xPicture.Image = global::cubeLauncher.Properties.Resources.close_x_options;
            this.xPicture.Location = new System.Drawing.Point(56, 126);
            this.xPicture.Name = "xPicture";
            this.xPicture.Size = new System.Drawing.Size(15, 15);
            this.xPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xPicture.TabIndex = 0;
            this.xPicture.TabStop = false;
            // 
            // argumentsPicture
            // 
            this.argumentsPicture.BackColor = System.Drawing.Color.Transparent;
            this.argumentsPicture.Image = ((System.Drawing.Image)(resources.GetObject("argumentsPicture.Image")));
            this.argumentsPicture.Location = new System.Drawing.Point(11, 146);
            this.argumentsPicture.Name = "argumentsPicture";
            this.argumentsPicture.Size = new System.Drawing.Size(66, 14);
            this.argumentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.argumentsPicture.TabIndex = 0;
            this.argumentsPicture.TabStop = false;
            // 
            // resolutionPicture
            // 
            this.resolutionPicture.BackColor = System.Drawing.Color.Transparent;
            this.resolutionPicture.Image = ((System.Drawing.Image)(resources.GetObject("resolutionPicture.Image")));
            this.resolutionPicture.Location = new System.Drawing.Point(11, 112);
            this.resolutionPicture.Name = "resolutionPicture";
            this.resolutionPicture.Size = new System.Drawing.Size(66, 14);
            this.resolutionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resolutionPicture.TabIndex = 0;
            this.resolutionPicture.TabStop = false;
            // 
            // versionPicture
            // 
            this.versionPicture.BackColor = System.Drawing.Color.Transparent;
            this.versionPicture.Image = ((System.Drawing.Image)(resources.GetObject("versionPicture.Image")));
            this.versionPicture.Location = new System.Drawing.Point(11, 81);
            this.versionPicture.Name = "versionPicture";
            this.versionPicture.Size = new System.Drawing.Size(49, 13);
            this.versionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.versionPicture.TabIndex = 0;
            this.versionPicture.TabStop = false;
            // 
            // namePicture
            // 
            this.namePicture.BackColor = System.Drawing.Color.Transparent;
            this.namePicture.Image = ((System.Drawing.Image)(resources.GetObject("namePicture.Image")));
            this.namePicture.Location = new System.Drawing.Point(9, 50);
            this.namePicture.Name = "namePicture";
            this.namePicture.Size = new System.Drawing.Size(35, 10);
            this.namePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namePicture.TabIndex = 0;
            this.namePicture.TabStop = false;
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImage = global::cubeLauncher.Properties.Resources._127x240_gradient;
            this.ClientSize = new System.Drawing.Size(127, 240);
            this.Controls.Add(this.grass2Picture);
            this.Controls.Add(this.customArgsBox);
            this.Controls.Add(this.configNameLabel);
            this.Controls.Add(this.clearPathButton);
            this.Controls.Add(this.launcherPathLabel);
            this.Controls.Add(this.selectPathButton);
            this.Controls.Add(this.launcherPathPicture);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "options";
            this.Text = "cubeLauncher Options";
            this.Activated += new System.EventHandler(this.options_Activated);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.launcherPathPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox optionsPicture;
        private System.Windows.Forms.PictureBox launcherPathPicture;
        private System.Windows.Forms.Button selectPathButton;
        private System.Windows.Forms.Label launcherPathLabel;
        private System.Windows.Forms.Button clearPathButton;
        private System.Windows.Forms.ToolTip optionsToolTip;
        private System.Windows.Forms.Label configNameLabel;
        private System.Windows.Forms.TextBox customArgsBox;
        private System.Windows.Forms.PictureBox grass2Picture;
    }
}