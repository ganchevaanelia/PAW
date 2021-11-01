namespace project
{
    partial class FormPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmOperatii = new System.Windows.Forms.ToolStripMenuItem();
            this.platiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesizariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOperatii,
            this.tsmClipboard});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(116, 407);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmOperatii
            // 
            this.tsmOperatii.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.platiToolStripMenuItem,
            this.sesizariToolStripMenuItem});
            this.tsmOperatii.Name = "tsmOperatii";
            this.tsmOperatii.Size = new System.Drawing.Size(109, 32);
            this.tsmOperatii.Text = "Operatii";
            // 
            // platiToolStripMenuItem
            // 
            this.platiToolStripMenuItem.Name = "platiToolStripMenuItem";
            this.platiToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.platiToolStripMenuItem.Text = "Plati";
            this.platiToolStripMenuItem.Click += new System.EventHandler(this.platiToolStripMenuItem_Click);
            // 
            // sesizariToolStripMenuItem
            // 
            this.sesizariToolStripMenuItem.Name = "sesizariToolStripMenuItem";
            this.sesizariToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.sesizariToolStripMenuItem.Text = "Sesizari";
            this.sesizariToolStripMenuItem.Click += new System.EventHandler(this.sesizariToolStripMenuItem_Click);
            // 
            // tsmClipboard
            // 
            this.tsmClipboard.Name = "tsmClipboard";
            this.tsmClipboard.Size = new System.Drawing.Size(109, 32);
            this.tsmClipboard.Text = "Clipboard";
            this.tsmClipboard.Click += new System.EventHandler(this.tsmClipboard_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(116, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 407);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(147, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(300, 180);
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(147, 211);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(300, 180);
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 407);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormPrincipal";
            this.Text = "Welcome";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmOperatii;
        private System.Windows.Forms.ToolStripMenuItem tsmClipboard;
        private System.Windows.Forms.ToolStripMenuItem platiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesizariToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
    }
}

