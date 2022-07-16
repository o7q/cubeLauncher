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
            this.panelByO7q = new System.Windows.Forms.PictureBox();
            this.panelBannerVersion = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panelBanner = new System.Windows.Forms.PictureBox();
            this.dropBoxLabel = new System.Windows.Forms.Label();
            this.dropBoxPanel = new System.Windows.Forms.Panel();
            this.dropBoxInfoPicture = new System.Windows.Forms.PictureBox();
            this.installList = new System.Windows.Forms.ComboBox();
            this.openPathButton = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.deleteInstallButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelByO7q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBannerVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBanner)).BeginInit();
            this.dropBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropBoxInfoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(25)))));
            this.panel.Controls.Add(this.panelByO7q);
            this.panel.Controls.Add(this.panelBannerVersion);
            this.panel.Controls.Add(this.minimizeButton);
            this.panel.Controls.Add(this.closeButton);
            this.panel.Controls.Add(this.panelBanner);
            this.panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(25)))));
            this.panel.Location = new System.Drawing.Point(-6, -3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(288, 47);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panelByO7q
            // 
            this.panelByO7q.Image = global::cubeLauncher.Properties.Resources.byo7q;
            this.panelByO7q.Location = new System.Drawing.Point(85, 33);
            this.panelByO7q.Name = "panelByO7q";
            this.panelByO7q.Size = new System.Drawing.Size(29, 14);
            this.panelByO7q.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelByO7q.TabIndex = 0;
            this.panelByO7q.TabStop = false;
            this.panelByO7q.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelByO7q_MouseDown);
            // 
            // panelBannerVersion
            // 
            this.panelBannerVersion.Image = global::cubeLauncher.Properties.Resources.v1_1_0;
            this.panelBannerVersion.Location = new System.Drawing.Point(41, 30);
            this.panelBannerVersion.Name = "panelBannerVersion";
            this.panelBannerVersion.Size = new System.Drawing.Size(47, 17);
            this.panelBannerVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelBannerVersion.TabIndex = 0;
            this.panelBannerVersion.TabStop = false;
            this.panelBannerVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBannerVersion_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.minimizeButton.Image = global::cubeLauncher.Properties.Resources.close__;
            this.minimizeButton.Location = new System.Drawing.Point(211, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(245, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.Image = global::cubeLauncher.Properties.Resources.banner;
            this.panelBanner.Location = new System.Drawing.Point(-2, 5);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(209, 38);
            this.panelBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelBanner.TabIndex = 0;
            this.panelBanner.TabStop = false;
            this.panelBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBanner_MouseDown);
            // 
            // dropBoxLabel
            // 
            this.dropBoxLabel.AutoSize = true;
            this.dropBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.dropBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dropBoxLabel.Location = new System.Drawing.Point(-1, 65);
            this.dropBoxLabel.Name = "dropBoxLabel";
            this.dropBoxLabel.Size = new System.Drawing.Size(92, 15);
            this.dropBoxLabel.TabIndex = 0;
            this.dropBoxLabel.Text = "outputMessage";
            // 
            // dropBoxPanel
            // 
            this.dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.dropBoxPanel.Controls.Add(this.dropBoxInfoPicture);
            this.dropBoxPanel.Controls.Add(this.dropBoxLabel);
            this.dropBoxPanel.Location = new System.Drawing.Point(-2, 42);
            this.dropBoxPanel.Name = "dropBoxPanel";
            this.dropBoxPanel.Size = new System.Drawing.Size(284, 81);
            this.dropBoxPanel.TabIndex = 0;
            this.dropBoxPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBoxPanel_DragDrop);
            this.dropBoxPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBoxPanel_DragEnter);
            this.dropBoxPanel.DragLeave += new System.EventHandler(this.dropBoxPanel_DragLeave);
            // 
            // dropBoxInfoPicture
            // 
            this.dropBoxInfoPicture.BackColor = System.Drawing.Color.Transparent;
            this.dropBoxInfoPicture.Image = ((System.Drawing.Image)(resources.GetObject("dropBoxInfoPicture.Image")));
            this.dropBoxInfoPicture.Location = new System.Drawing.Point(38, 30);
            this.dropBoxInfoPicture.Name = "dropBoxInfoPicture";
            this.dropBoxInfoPicture.Size = new System.Drawing.Size(207, 26);
            this.dropBoxInfoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dropBoxInfoPicture.TabIndex = 0;
            this.dropBoxInfoPicture.TabStop = false;
            this.dropBoxInfoPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBoxInfoPicture_DragDrop);
            this.dropBoxInfoPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBoxInfoPicture_DragEnter);
            this.dropBoxInfoPicture.DragLeave += new System.EventHandler(this.dropBoxInfoPicture_DragLeave);
            // 
            // installList
            // 
            this.installList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.installList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installList.ForeColor = System.Drawing.Color.YellowGreen;
            this.installList.FormattingEnabled = true;
            this.installList.ItemHeight = 13;
            this.installList.Location = new System.Drawing.Point(2, 126);
            this.installList.Name = "installList";
            this.installList.Size = new System.Drawing.Size(138, 21);
            this.installList.TabIndex = 2;
            this.installList.DropDown += new System.EventHandler(this.installList_DropDown);
            this.installList.SelectedIndexChanged += new System.EventHandler(this.installList_SelectedIndexChanged);
            // 
            // openPathButton
            // 
            this.openPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.openPathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.openPathButton.Image = global::cubeLauncher.Properties.Resources.open;
            this.openPathButton.Location = new System.Drawing.Point(141, 125);
            this.openPathButton.Name = "openPathButton";
            this.openPathButton.Size = new System.Drawing.Size(25, 25);
            this.openPathButton.TabIndex = 3;
            this.openPathButton.UseVisualStyleBackColor = false;
            this.openPathButton.Click += new System.EventHandler(this.openPathButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.launchButton.Image = global::cubeLauncher.Properties.Resources.launch;
            this.launchButton.Location = new System.Drawing.Point(-3, 150);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(279, 41);
            this.launchButton.TabIndex = 6;
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // deleteInstallButton
            // 
            this.deleteInstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.deleteInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteInstallButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.deleteInstallButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteInstallButton.Image")));
            this.deleteInstallButton.Location = new System.Drawing.Point(166, 125);
            this.deleteInstallButton.Name = "deleteInstallButton";
            this.deleteInstallButton.Size = new System.Drawing.Size(25, 25);
            this.deleteInstallButton.TabIndex = 4;
            this.deleteInstallButton.UseVisualStyleBackColor = false;
            this.deleteInstallButton.Click += new System.EventHandler(this.deleteInstallButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.optionsButton.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Image")));
            this.optionsButton.Location = new System.Drawing.Point(191, 125);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(84, 25);
            this.optionsButton.TabIndex = 5;
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(275, 190);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.deleteInstallButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.openPathButton);
            this.Controls.Add(this.installList);
            this.Controls.Add(this.dropBoxPanel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "program";
            this.Text = "cubeLauncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.program_FormClosing);
            this.Load += new System.EventHandler(this.program_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelByO7q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBannerVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBanner)).EndInit();
            this.dropBoxPanel.ResumeLayout(false);
            this.dropBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropBoxInfoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox panelBanner;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.PictureBox panelBannerVersion;
        private System.Windows.Forms.PictureBox panelByO7q;
        private System.Windows.Forms.Label dropBoxLabel;
        private System.Windows.Forms.PictureBox dropBoxInfoPicture;
        private System.Windows.Forms.Panel dropBoxPanel;
        private System.Windows.Forms.ComboBox installList;
        private System.Windows.Forms.Button openPathButton;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button deleteInstallButton;
        private System.Windows.Forms.Button optionsButton;
    }
}

