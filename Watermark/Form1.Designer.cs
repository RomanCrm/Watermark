namespace Watermark
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watermarkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.textWatermarkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.imageWatermarkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFoderToolStripMenuItem,
            this.selectAFileToolStripMenuItem,
            this.watermarkBtn,
            this.saveBtn,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.файлToolStripMenuItem.Text = "&File";
            // 
            // selectFoderToolStripMenuItem
            // 
            this.selectFoderToolStripMenuItem.Name = "selectFoderToolStripMenuItem";
            this.selectFoderToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.selectFoderToolStripMenuItem.Text = "Select a folder";
            this.selectFoderToolStripMenuItem.Click += new System.EventHandler(this.SelectFolder_Clicked);
            // 
            // selectAFileToolStripMenuItem
            // 
            this.selectAFileToolStripMenuItem.Name = "selectAFileToolStripMenuItem";
            this.selectAFileToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.selectAFileToolStripMenuItem.Text = "Select a file";
            this.selectAFileToolStripMenuItem.Click += new System.EventHandler(this.SelectFile_Clicked);
            // 
            // watermarkBtn
            // 
            this.watermarkBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textWatermarkBtn,
            this.imageWatermarkBtn});
            this.watermarkBtn.Name = "watermarkBtn";
            this.watermarkBtn.Size = new System.Drawing.Size(142, 22);
            this.watermarkBtn.Text = "Watermark";
            // 
            // textWatermarkBtn
            // 
            this.textWatermarkBtn.Enabled = false;
            this.textWatermarkBtn.Name = "textWatermarkBtn";
            this.textWatermarkBtn.Size = new System.Drawing.Size(155, 22);
            this.textWatermarkBtn.Text = "TextWatermark";
            this.textWatermarkBtn.Click += new System.EventHandler(this.TextWatermark_Clicked);
            // 
            // imageWatermarkBtn
            // 
            this.imageWatermarkBtn.Enabled = false;
            this.imageWatermarkBtn.Name = "imageWatermarkBtn";
            this.imageWatermarkBtn.Size = new System.Drawing.Size(155, 22);
            this.imageWatermarkBtn.Text = "ImageWatermark";
            this.imageWatermarkBtn.Click += new System.EventHandler(this.ImageWaterrmark_Clicked);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(142, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.Save_Clicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Clicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFoderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watermarkBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem textWatermarkBtn;
        private System.Windows.Forms.ToolStripMenuItem imageWatermarkBtn;
        private System.Windows.Forms.ToolStripMenuItem selectAFileToolStripMenuItem;
    }
}

