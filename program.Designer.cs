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
            this.dropBoxLabel = new System.Windows.Forms.Label();
            this.dropBoxPanel = new System.Windows.Forms.Panel();
            this.dropBoxInfoPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBannerVersion = new System.Windows.Forms.PictureBox();
            this.panelBanner = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.dropBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropBoxInfoPicture)).BeginInit();
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
            this.panel.Size = new System.Drawing.Size(288, 47);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
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
            // dropBoxLabel
            // 
            this.dropBoxLabel.AutoSize = true;
            this.dropBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.dropBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.dropBoxLabel.Location = new System.Drawing.Point(-3, 123);
            this.dropBoxLabel.Name = "dropBoxLabel";
            this.dropBoxLabel.Size = new System.Drawing.Size(100, 16);
            this.dropBoxLabel.TabIndex = 2;
            this.dropBoxLabel.Text = "outputMessage";
            // 
            // dropBoxPanel
            // 
            this.dropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(15)))));
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cubeLauncher.Properties.Resources.byo7q;
            this.pictureBox1.Location = new System.Drawing.Point(85, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
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
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(275, 191);
            this.Controls.Add(this.dropBoxPanel);
            this.Controls.Add(this.dropBoxLabel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "program";
            this.Text = "cubeLauncher";
            this.Load += new System.EventHandler(this.program_Load);
            this.panel.ResumeLayout(false);
            this.dropBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropBoxInfoPicture)).EndInit();
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
        private System.Windows.Forms.PictureBox panelBannerVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dropBoxLabel;
        private System.Windows.Forms.PictureBox dropBoxInfoPicture;
        private System.Windows.Forms.Panel dropBoxPanel;
    }
}

