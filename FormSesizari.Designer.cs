namespace project
{
    partial class FormSesizari
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDetaliiSesizare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdaugaEditeaza = new System.Windows.Forms.Button();
            this.btnCurataSterge = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.lvSesizari = new System.Windows.Forms.ListView();
            this.Categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detalii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsBinar = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.DeserializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDetaliiSesizare);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCategorie);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga sesizare";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(10, 186);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(287, 22);
            this.tbNume.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume";
            // 
            // tbDetaliiSesizare
            // 
            this.tbDetaliiSesizare.AllowDrop = true;
            this.tbDetaliiSesizare.Location = new System.Drawing.Point(6, 100);
            this.tbDetaliiSesizare.Multiline = true;
            this.tbDetaliiSesizare.Name = "tbDetaliiSesizare";
            this.tbDetaliiSesizare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDetaliiSesizare.Size = new System.Drawing.Size(291, 51);
            this.tbDetaliiSesizare.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorie";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Items.AddRange(new object[] {
            "Spatii verzi/Parcuri",
            "Strazi/Alei/Trotuare",
            "Parcari",
            "Altele"});
            this.cbCategorie.Location = new System.Drawing.Point(6, 42);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(291, 24);
            this.cbCategorie.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sesizari";
            // 
            // btnAdaugaEditeaza
            // 
            this.btnAdaugaEditeaza.Location = new System.Drawing.Point(170, 298);
            this.btnAdaugaEditeaza.Name = "btnAdaugaEditeaza";
            this.btnAdaugaEditeaza.Size = new System.Drawing.Size(139, 45);
            this.btnAdaugaEditeaza.TabIndex = 4;
            this.btnAdaugaEditeaza.Text = "Adauga/Editeaza";
            this.btnAdaugaEditeaza.UseVisualStyleBackColor = true;
            this.btnAdaugaEditeaza.Click += new System.EventHandler(this.btnAdaugaEditeaza_Click);
            // 
            // btnCurataSterge
            // 
            this.btnCurataSterge.Location = new System.Drawing.Point(22, 298);
            this.btnCurataSterge.Name = "btnCurataSterge";
            this.btnCurataSterge.Size = new System.Drawing.Size(142, 45);
            this.btnCurataSterge.TabIndex = 5;
            this.btnCurataSterge.Text = "Curata/Sterge";
            this.btnCurataSterge.UseVisualStyleBackColor = true;
            this.btnCurataSterge.Click += new System.EventHandler(this.btnCurataSterge_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel.Location = new System.Drawing.Point(229, 361);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(166, 17);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Catre pagina principala...";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // lvSesizari
            // 
            this.lvSesizari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Categorie,
            this.Detalii,
            this.Nume});
            this.lvSesizari.FullRowSelect = true;
            this.lvSesizari.HideSelection = false;
            this.lvSesizari.Location = new System.Drawing.Point(340, 50);
            this.lvSesizari.MultiSelect = false;
            this.lvSesizari.Name = "lvSesizari";
            this.lvSesizari.Size = new System.Drawing.Size(297, 293);
            this.lvSesizari.TabIndex = 10;
            this.lvSesizari.UseCompatibleStateImageBehavior = false;
            this.lvSesizari.View = System.Windows.Forms.View.Details;
            this.lvSesizari.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSesizari_MouseClick);
            this.lvSesizari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSesizari_MouseDoubleClick);
            // 
            // Categorie
            // 
            this.Categorie.Text = "Categorie";
            this.Categorie.Width = 76;
            // 
            // Detalii
            // 
            this.Detalii.Text = "Detalii";
            this.Detalii.Width = 87;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 59;
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBinar,
            this.exportTextToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(151, 52);
            // 
            // tsBinar
            // 
            this.tsBinar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerializareBinara,
            this.DeserializareBinara});
            this.tsBinar.Name = "tsBinar";
            this.tsBinar.Size = new System.Drawing.Size(150, 24);
            this.tsBinar.Text = "Binar";
            // 
            // SerializareBinara
            // 
            this.SerializareBinara.Name = "SerializareBinara";
            this.SerializareBinara.Size = new System.Drawing.Size(178, 26);
            this.SerializareBinara.Text = "Serializare";
            this.SerializareBinara.Click += new System.EventHandler(this.SerializareBinara_Click);
            // 
            // DeserializareBinara
            // 
            this.DeserializareBinara.Name = "DeserializareBinara";
            this.DeserializareBinara.Size = new System.Drawing.Size(178, 26);
            this.DeserializareBinara.Text = "Deserializare";
            this.DeserializareBinara.Click += new System.EventHandler(this.DeserializareBinara_Click);
            // 
            // exportTextToolStripMenuItem
            // 
            this.exportTextToolStripMenuItem.Name = "exportTextToolStripMenuItem";
            this.exportTextToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.exportTextToolStripMenuItem.Text = "Export text";
            this.exportTextToolStripMenuItem.Click += new System.EventHandler(this.exportTextToolStripMenuItem_Click);
            // 
            // FormSesizari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 400);
            this.Controls.Add(this.lvSesizari);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.btnCurataSterge);
            this.Controls.Add(this.btnAdaugaEditeaza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSesizari";
            this.Text = "Sesizari";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDetaliiSesizare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdaugaEditeaza;
        private System.Windows.Forms.Button btnCurataSterge;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.ListView lvSesizari;
        private System.Windows.Forms.ColumnHeader Categorie;
        private System.Windows.Forms.ColumnHeader Detalii;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsBinar;
        private System.Windows.Forms.ToolStripMenuItem SerializareBinara;
        private System.Windows.Forms.ToolStripMenuItem DeserializareBinara;
        private System.Windows.Forms.ToolStripMenuItem exportTextToolStripMenuItem;
    }
}