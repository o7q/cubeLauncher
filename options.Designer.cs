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
            this.customArgsBox = new System.Windows.Forms.RichTextBox();
            this.customWidthBox = new System.Windows.Forms.TextBox();
            this.customHeightBox = new System.Windows.Forms.TextBox();
            this.customNameBox = new System.Windows.Forms.TextBox();
            this.customVersionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customArgsBox
            // 
            this.customArgsBox.Location = new System.Drawing.Point(247, 165);
            this.customArgsBox.Name = "customArgsBox";
            this.customArgsBox.Size = new System.Drawing.Size(100, 96);
            this.customArgsBox.TabIndex = 0;
            this.customArgsBox.Text = "";
            this.customArgsBox.TextChanged += new System.EventHandler(this.customArgsBox_TextChanged);
            // 
            // customWidthBox
            // 
            this.customWidthBox.Location = new System.Drawing.Point(99, 101);
            this.customWidthBox.Name = "customWidthBox";
            this.customWidthBox.Size = new System.Drawing.Size(100, 20);
            this.customWidthBox.TabIndex = 1;
            this.customWidthBox.TextChanged += new System.EventHandler(this.customWidthBox_TextChanged);
            // 
            // customHeightBox
            // 
            this.customHeightBox.Location = new System.Drawing.Point(227, 101);
            this.customHeightBox.Name = "customHeightBox";
            this.customHeightBox.Size = new System.Drawing.Size(100, 20);
            this.customHeightBox.TabIndex = 2;
            this.customHeightBox.TextChanged += new System.EventHandler(this.customHeightBox_TextChanged);
            // 
            // customNameBox
            // 
            this.customNameBox.Location = new System.Drawing.Point(114, 39);
            this.customNameBox.Name = "customNameBox";
            this.customNameBox.Size = new System.Drawing.Size(100, 20);
            this.customNameBox.TabIndex = 3;
            this.customNameBox.TextChanged += new System.EventHandler(this.customNameBox_TextChanged);
            // 
            // customVersionBox
            // 
            this.customVersionBox.Location = new System.Drawing.Point(420, 36);
            this.customVersionBox.Name = "customVersionBox";
            this.customVersionBox.Size = new System.Drawing.Size(100, 20);
            this.customVersionBox.TabIndex = 4;
            this.customVersionBox.TextChanged += new System.EventHandler(this.customVersionBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "args";
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customVersionBox);
            this.Controls.Add(this.customNameBox);
            this.Controls.Add(this.customHeightBox);
            this.Controls.Add(this.customWidthBox);
            this.Controls.Add(this.customArgsBox);
            this.Name = "options";
            this.Text = "options";
            this.Activated += new System.EventHandler(this.options_Activated);
            this.Load += new System.EventHandler(this.options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox customArgsBox;
        private System.Windows.Forms.TextBox customWidthBox;
        private System.Windows.Forms.TextBox customHeightBox;
        private System.Windows.Forms.TextBox customNameBox;
        private System.Windows.Forms.TextBox customVersionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}