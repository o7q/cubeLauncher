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
            this.updateInstallList = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
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
            this.panelByO7q.TabIndex = 7;
            this.panelByO7q.TabStop = false;
            this.panelByO7q.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
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
            this.panelBannerVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBannerVersion_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.minimizeButton.Location = new System.Drawing.Point(211, 7);
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
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.closeButton.Location = new System.Drawing.Point(245, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "❌";
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
            this.panelBanner.TabIndex = 1;
            this.panelBanner.TabStop = false;
            this.panelBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBanner_MouseDown);
            // 
            // dropBoxLabel
            // 
            this.dropBoxLabel.AutoSize = true;
            this.dropBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.dropBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dropBoxLabel.Location = new System.Drawing.Point(-3, 123);
            this.dropBoxLabel.Name = "dropBoxLabel";
            this.dropBoxLabel.Size = new System.Drawing.Size(100, 16);
            this.dropBoxLabel.TabIndex = 2;
            this.dropBoxLabel.Text = "outputMessage";
            // 
            // dropBoxPanel
            // 
            this.dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.dropBoxPanel.Controls.Add(this.dropBoxInfoPicture);
            this.dropBoxPanel.Location = new System.Drawing.Point(-2, 42);
            this.dropBoxPanel.Name = "dropBoxPanel";
            this.dropBoxPanel.Size = new System.Drawing.Size(284, 81);
            this.dropBoxPanel.TabIndex = 4;
            this.dropBoxPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBoxPanel_DragDrop);
            this.dropBoxPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBoxPanel_DragEnter);
            // 
            // dropBoxInfoPicture
            // 
            this.dropBoxInfoPicture.BackColor = System.Drawing.Color.Transparent;
            this.dropBoxInfoPicture.Image = global::cubeLauncher.Properties.Resources.dragndrop;
            this.dropBoxInfoPicture.Location = new System.Drawing.Point(38, 30);
            this.dropBoxInfoPicture.Name = "dropBoxInfoPicture";
            this.dropBoxInfoPicture.Size = new System.Drawing.Size(207, 26);
            this.dropBoxInfoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dropBoxInfoPicture.TabIndex = 3;
            this.dropBoxInfoPicture.TabStop = false;
            this.dropBoxInfoPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBoxInfoPicture_DragDrop);
            this.dropBoxInfoPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBoxInfoPicture_DragEnter);
            // 
            // installList
            // 
            this.installList.FormattingEnabled = true;
            this.installList.Location = new System.Drawing.Point(14, 149);
            this.installList.Name = "installList";
            this.installList.Size = new System.Drawing.Size(121, 21);
            this.installList.TabIndex = 5;
            // 
            // updateInstallList
            // 
            this.updateInstallList.Location = new System.Drawing.Point(138, 149);
            this.updateInstallList.Name = "updateInstallList";
            this.updateInstallList.Size = new System.Drawing.Size(75, 23);
            this.updateInstallList.TabIndex = 6;
            this.updateInstallList.UseVisualStyleBackColor = true;
            this.updateInstallList.Click += new System.EventHandler(this.updateInstallList_Click);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(71, 178);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(128, 55);
            this.launchButton.TabIndex = 7;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(275, 237);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.updateInstallList);
            this.Controls.Add(this.installList);
            this.Controls.Add(this.dropBoxPanel);
            this.Controls.Add(this.dropBoxLabel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "program";
            this.Text = "cubeLauncher";
            this.Load += new System.EventHandler(this.program_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelByO7q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBannerVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBanner)).EndInit();
            this.dropBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropBoxInfoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button updateInstallList;
        private System.Windows.Forms.Button launchButton;
    }
}

