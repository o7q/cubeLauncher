namespace cubeLauncher
{
    partial class Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.TitlebarCreditPictureBox = new System.Windows.Forms.PictureBox();
            this.TitlebarVersionPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.TitlebarPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InstallListBox = new System.Windows.Forms.ComboBox();
            this.ProgramToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CreateInstallButton = new System.Windows.Forms.Button();
            this.OpenOptionsButton = new System.Windows.Forms.Button();
            this.DeleteInstallButton = new System.Windows.Forms.Button();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.OpenPathButton = new System.Windows.Forms.Button();
            this.DropBoxPanel = new System.Windows.Forms.Panel();
            this.GrassPictureBox = new System.Windows.Forms.PictureBox();
            this.DropBoxInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.DropBoxLabel = new System.Windows.Forms.Label();
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarCreditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarVersionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarPictureBox)).BeginInit();
            this.DropBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrassPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropBoxInfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(25)))));
            this.TitlebarPanel.Controls.Add(this.TitlebarCreditPictureBox);
            this.TitlebarPanel.Controls.Add(this.TitlebarVersionPictureBox);
            this.TitlebarPanel.Controls.Add(this.MinimizeButton);
            this.TitlebarPanel.Controls.Add(this.TitlebarPictureBox);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(25)))));
            this.TitlebarPanel.Location = new System.Drawing.Point(-6, -3);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(251, 47);
            this.TitlebarPanel.TabIndex = 0;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // TitlebarCreditPictureBox
            // 
            this.TitlebarCreditPictureBox.Image = global::cubeLauncher.Properties.Resources.byo7q;
            this.TitlebarCreditPictureBox.Location = new System.Drawing.Point(73, 31);
            this.TitlebarCreditPictureBox.Name = "TitlebarCreditPictureBox";
            this.TitlebarCreditPictureBox.Size = new System.Drawing.Size(29, 14);
            this.TitlebarCreditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlebarCreditPictureBox.TabIndex = 0;
            this.TitlebarCreditPictureBox.TabStop = false;
            this.TitlebarCreditPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarCreditPictureBox_MouseDown);
            // 
            // TitlebarVersionPictureBox
            // 
            this.TitlebarVersionPictureBox.Image = global::cubeLauncher.Properties.Resources.v2_0_0;
            this.TitlebarVersionPictureBox.Location = new System.Drawing.Point(30, 29);
            this.TitlebarVersionPictureBox.Name = "TitlebarVersionPictureBox";
            this.TitlebarVersionPictureBox.Size = new System.Drawing.Size(47, 17);
            this.TitlebarVersionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlebarVersionPictureBox.TabIndex = 0;
            this.TitlebarVersionPictureBox.TabStop = false;
            this.TitlebarVersionPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarVersionPictureBox_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(183, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // TitlebarPictureBox
            // 
            this.TitlebarPictureBox.Image = global::cubeLauncher.Properties.Resources.banner;
            this.TitlebarPictureBox.Location = new System.Drawing.Point(3, 8);
            this.TitlebarPictureBox.Name = "TitlebarPictureBox";
            this.TitlebarPictureBox.Size = new System.Drawing.Size(157, 31);
            this.TitlebarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlebarPictureBox.TabIndex = 0;
            this.TitlebarPictureBox.TabStop = false;
            this.TitlebarPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPictureBox_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(212, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InstallListBox
            // 
            this.InstallListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.InstallListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallListBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.InstallListBox.FormattingEnabled = true;
            this.InstallListBox.ItemHeight = 13;
            this.InstallListBox.Location = new System.Drawing.Point(2, 114);
            this.InstallListBox.Name = "InstallListBox";
            this.InstallListBox.Size = new System.Drawing.Size(138, 21);
            this.InstallListBox.TabIndex = 2;
            this.InstallListBox.DropDown += new System.EventHandler(this.InstallListBox_DropDown);
            this.InstallListBox.SelectedIndexChanged += new System.EventHandler(this.InstallListBox_SelectedIndexChanged);
            // 
            // ProgramToolTip
            // 
            this.ProgramToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ProgramToolTip_Draw);
            // 
            // CreateInstallButton
            // 
            this.CreateInstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(55)))), ((int)(((byte)(5)))));
            this.CreateInstallButton.BackgroundImage = global::cubeLauncher.Properties.Resources._25x_gradient;
            this.CreateInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateInstallButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(55)))), ((int)(((byte)(5)))));
            this.CreateInstallButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateInstallButton.Image")));
            this.CreateInstallButton.Location = new System.Drawing.Point(141, 114);
            this.CreateInstallButton.Name = "CreateInstallButton";
            this.CreateInstallButton.Size = new System.Drawing.Size(25, 25);
            this.CreateInstallButton.TabIndex = 3;
            this.CreateInstallButton.UseVisualStyleBackColor = false;
            this.CreateInstallButton.Click += new System.EventHandler(this.CreateInstallButton_Click);
            // 
            // OpenOptionsButton
            // 
            this.OpenOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(39)))));
            this.OpenOptionsButton.BackgroundImage = global::cubeLauncher.Properties.Resources._25x_gradient;
            this.OpenOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(39)))));
            this.OpenOptionsButton.Image = global::cubeLauncher.Properties.Resources.options;
            this.OpenOptionsButton.Location = new System.Drawing.Point(216, 114);
            this.OpenOptionsButton.Name = "OpenOptionsButton";
            this.OpenOptionsButton.Size = new System.Drawing.Size(25, 25);
            this.OpenOptionsButton.TabIndex = 6;
            this.OpenOptionsButton.UseVisualStyleBackColor = false;
            this.OpenOptionsButton.Click += new System.EventHandler(this.OpenOptionsButton_Click);
            // 
            // DeleteInstallButton
            // 
            this.DeleteInstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.DeleteInstallButton.BackgroundImage = global::cubeLauncher.Properties.Resources._25x_gradient;
            this.DeleteInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteInstallButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.DeleteInstallButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteInstallButton.Image")));
            this.DeleteInstallButton.Location = new System.Drawing.Point(166, 114);
            this.DeleteInstallButton.Name = "DeleteInstallButton";
            this.DeleteInstallButton.Size = new System.Drawing.Size(25, 25);
            this.DeleteInstallButton.TabIndex = 4;
            this.DeleteInstallButton.UseVisualStyleBackColor = false;
            this.DeleteInstallButton.Click += new System.EventHandler(this.DeleteInstallButton_Click);
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.LaunchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaunchButton.BackgroundImage")));
            this.LaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(30)))));
            this.LaunchButton.Image = global::cubeLauncher.Properties.Resources.launch;
            this.LaunchButton.Location = new System.Drawing.Point(-1, 139);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(245, 35);
            this.LaunchButton.TabIndex = 7;
            this.LaunchButton.UseVisualStyleBackColor = false;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // OpenPathButton
            // 
            this.OpenPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.OpenPathButton.BackgroundImage = global::cubeLauncher.Properties.Resources._25x_gradient;
            this.OpenPathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.OpenPathButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenPathButton.Image")));
            this.OpenPathButton.Location = new System.Drawing.Point(191, 114);
            this.OpenPathButton.Name = "OpenPathButton";
            this.OpenPathButton.Size = new System.Drawing.Size(25, 25);
            this.OpenPathButton.TabIndex = 5;
            this.OpenPathButton.UseVisualStyleBackColor = false;
            this.OpenPathButton.Click += new System.EventHandler(this.OpenPathButton_Click);
            // 
            // DropBoxPanel
            // 
            this.DropBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.DropBoxPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DropBoxPanel.BackgroundImage")));
            this.DropBoxPanel.Controls.Add(this.GrassPictureBox);
            this.DropBoxPanel.Controls.Add(this.DropBoxInfoPictureBox);
            this.DropBoxPanel.Controls.Add(this.DropBoxLabel);
            this.DropBoxPanel.Location = new System.Drawing.Point(-2, 42);
            this.DropBoxPanel.Name = "DropBoxPanel";
            this.DropBoxPanel.Size = new System.Drawing.Size(249, 72);
            this.DropBoxPanel.TabIndex = 0;
            this.DropBoxPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropBoxPanel_DragDrop);
            this.DropBoxPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBoxPanel_DragEnter);
            this.DropBoxPanel.DragLeave += new System.EventHandler(this.DropBoxPanel_DragLeave);
            // 
            // GrassPictureBox
            // 
            this.GrassPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GrassPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GrassPictureBox.Image")));
            this.GrassPictureBox.Location = new System.Drawing.Point(2, 0);
            this.GrassPictureBox.Name = "GrassPictureBox";
            this.GrassPictureBox.Size = new System.Drawing.Size(242, 16);
            this.GrassPictureBox.TabIndex = 0;
            this.GrassPictureBox.TabStop = false;
            this.GrassPictureBox.DoubleClick += new System.EventHandler(this.GrassPictureBox_DoubleClick);
            // 
            // DropBoxInfoPictureBox
            // 
            this.DropBoxInfoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DropBoxInfoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DropBoxInfoPictureBox.Image")));
            this.DropBoxInfoPictureBox.Location = new System.Drawing.Point(20, 20);
            this.DropBoxInfoPictureBox.Name = "DropBoxInfoPictureBox";
            this.DropBoxInfoPictureBox.Size = new System.Drawing.Size(210, 40);
            this.DropBoxInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DropBoxInfoPictureBox.TabIndex = 0;
            this.DropBoxInfoPictureBox.TabStop = false;
            this.DropBoxInfoPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropBoxInfoPictureBox_DragDrop);
            this.DropBoxInfoPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBoxInfoPictureBox_DragEnter);
            this.DropBoxInfoPictureBox.DragLeave += new System.EventHandler(this.DropBoxInfoPictureBox_DragLeave);
            // 
            // DropBoxLabel
            // 
            this.DropBoxLabel.AutoSize = true;
            this.DropBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.DropBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(80)))));
            this.DropBoxLabel.Location = new System.Drawing.Point(-1, 55);
            this.DropBoxLabel.Name = "DropBoxLabel";
            this.DropBoxLabel.Size = new System.Drawing.Size(245, 15);
            this.DropBoxLabel.TabIndex = 0;
            this.DropBoxLabel.Text = "__________________________________";
            // 
            // Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(242, 173);
            this.Controls.Add(this.CreateInstallButton);
            this.Controls.Add(this.OpenOptionsButton);
            this.Controls.Add(this.DeleteInstallButton);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.OpenPathButton);
            this.Controls.Add(this.InstallListBox);
            this.Controls.Add(this.DropBoxPanel);
            this.Controls.Add(this.TitlebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "Program";
            this.Text = "cubeLauncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Program_FormClosing);
            this.Load += new System.EventHandler(this.Program_Load);
            this.TitlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarCreditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarVersionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarPictureBox)).EndInit();
            this.DropBoxPanel.ResumeLayout(false);
            this.DropBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrassPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropBoxInfoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.PictureBox TitlebarPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox TitlebarVersionPictureBox;
        private System.Windows.Forms.PictureBox TitlebarCreditPictureBox;
        private System.Windows.Forms.Label DropBoxLabel;
        private System.Windows.Forms.PictureBox DropBoxInfoPictureBox;
        private System.Windows.Forms.Panel DropBoxPanel;
        private System.Windows.Forms.ComboBox InstallListBox;
        private System.Windows.Forms.Button OpenPathButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button DeleteInstallButton;
        private System.Windows.Forms.Button OpenOptionsButton;
        private System.Windows.Forms.ToolTip ProgramToolTip;
        private System.Windows.Forms.Button CreateInstallButton;
        private System.Windows.Forms.PictureBox GrassPictureBox;
    }
}