namespace cubeLauncher
{
    partial class program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program));
            this.panel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.selectInstall = new System.Windows.Forms.ComboBox();
            this.installButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.selectLaunch = new System.Windows.Forms.ComboBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBannerVersion = new System.Windows.Forms.PictureBox();
            this.panelBanner = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBannerVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.panelBannerVersion);
            this.panel.Controls.Add(this.minimizeButton);
            this.panel.Controls.Add(this.closeButton);
            this.panel.Controls.Add(this.panelBanner);
            this.panel.Location = new System.Drawing.Point(-6, -3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(285, 47);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.minimizeButton.Location = new System.Drawing.Point(208, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.closeButton.Location = new System.Drawing.Point(241, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "❌";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // selectInstall
            // 
            this.selectInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectInstall.FormattingEnabled = true;
            this.selectInstall.Location = new System.Drawing.Point(0, 89);
            this.selectInstall.Name = "selectInstall";
            this.selectInstall.Size = new System.Drawing.Size(121, 21);
            this.selectInstall.TabIndex = 1;
            this.selectInstall.SelectedIndexChanged += new System.EventHandler(this.selectInstall_SelectedIndexChanged);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(8, 119);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(75, 23);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusLabel.Location = new System.Drawing.Point(13, 147);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(29, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "hello";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(128, 90);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(25, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "R";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // selectLaunch
            // 
            this.selectLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLaunch.FormattingEnabled = true;
            this.selectLaunch.Location = new System.Drawing.Point(31, 12);
            this.selectLaunch.Name = "selectLaunch";
            this.selectLaunch.Size = new System.Drawing.Size(105, 21);
            this.selectLaunch.TabIndex = 5;
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(151, 5);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(69, 38);
            this.launchButton.TabIndex = 5;
            this.launchButton.Text = "launch";
            this.launchButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.selectLaunch);
            this.panel1.Controls.Add(this.launchButton);
            this.panel1.Location = new System.Drawing.Point(-5, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 48);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cubeLauncher.Properties.Resources.byo7q;
            this.pictureBox1.Location = new System.Drawing.Point(85, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelBannerVersion
            // 
            this.panelBannerVersion.Image = global::cubeLauncher.Properties.Resources.v1_0_0;
            this.panelBannerVersion.Location = new System.Drawing.Point(41, 30);
            this.panelBannerVersion.Name = "panelBannerVersion";
            this.panelBannerVersion.Size = new System.Drawing.Size(47, 17);
            this.panelBannerVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelBannerVersion.TabIndex = 4;
            this.panelBannerVersion.TabStop = false;
            // 
            // panelBanner
            // 
            this.panelBanner.Image = ((System.Drawing.Image)(resources.GetObject("panelBanner.Image")));
            this.panelBanner.Location = new System.Drawing.Point(-2, 5);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(209, 38);
            this.panelBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelBanner.TabIndex = 1;
            this.panelBanner.TabStop = false;
            this.panelBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBanner_MouseDown);
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(272, 265);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.selectInstall);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "program";
            this.Text = "cubeLauncher";
            this.Load += new System.EventHandler(this.program_Load);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBannerVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox panelBanner;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.ComboBox selectInstall;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox panelBannerVersion;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox selectLaunch;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

