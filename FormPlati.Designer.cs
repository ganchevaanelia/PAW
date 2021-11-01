namespace project
{
    partial class FormPlati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlati));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCard = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPlata = new System.Windows.Forms.GroupBox();
            this.btnAdaugaPlata = new System.Windows.Forms.Button();
            this.btnCurataPlata = new System.Windows.Forms.Button();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDetalii = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTaxaImpozit = new System.Windows.Forms.ComboBox();
            this.groupTipPersoana = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFizica = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.tbCVV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNrCard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.epNumarCard = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCVV = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCard = new System.Windows.Forms.GroupBox();
            this.btnAdaugaCard = new System.Windows.Forms.Button();
            this.btnCurataCard = new System.Windows.Forms.Button();
            this.listBoxPlati = new System.Windows.Forms.ListBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCard)).BeginInit();
            this.groupBoxPlata.SuspendLayout();
            this.groupTipPersoana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumarCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCVV)).BeginInit();
            this.groupBoxCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripPrint,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(787, 31);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(153, 28);
            this.toolStripLabel1.Text = "Printeaza documentul";
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrint.Image")));
            this.toolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(29, 28);
            this.toolStripPrint.Text = "Alt + T";
            this.toolStripPrint.Click += new System.EventHandler(this.toolStripPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carduri";
            // 
            // dataGridViewCard
            // 
            this.dataGridViewCard.AutoGenerateColumns = false;
            this.dataGridViewCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.nrCardDataGridViewTextBoxColumn,
            this.cVVDataGridViewTextBoxColumn,
            this.dataExpirareDataGridViewTextBoxColumn});
            this.dataGridViewCard.DataSource = this.cardBindingSource;
            this.dataGridViewCard.Location = new System.Drawing.Point(249, 57);
            this.dataGridViewCard.Name = "dataGridViewCard";
            this.dataGridViewCard.RowHeadersWidth = 51;
            this.dataGridViewCard.RowTemplate.Height = 24;
            this.dataGridViewCard.Size = new System.Drawing.Size(240, 136);
            this.dataGridViewCard.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plati";
            // 
            // groupBoxPlata
            // 
            this.groupBoxPlata.Controls.Add(this.btnAdaugaPlata);
            this.groupBoxPlata.Controls.Add(this.btnCurataPlata);
            this.groupBoxPlata.Controls.Add(this.tbSuma);
            this.groupBoxPlata.Controls.Add(this.label6);
            this.groupBoxPlata.Controls.Add(this.tbDetalii);
            this.groupBoxPlata.Controls.Add(this.label5);
            this.groupBoxPlata.Controls.Add(this.label4);
            this.groupBoxPlata.Controls.Add(this.cbTaxaImpozit);
            this.groupBoxPlata.Controls.Add(this.groupTipPersoana);
            this.groupBoxPlata.Location = new System.Drawing.Point(510, 31);
            this.groupBoxPlata.Name = "groupBoxPlata";
            this.groupBoxPlata.Size = new System.Drawing.Size(231, 357);
            this.groupBoxPlata.TabIndex = 5;
            this.groupBoxPlata.TabStop = false;
            this.groupBoxPlata.Text = "Plata";
            // 
            // btnAdaugaPlata
            // 
            this.btnAdaugaPlata.Location = new System.Drawing.Point(14, 262);
            this.btnAdaugaPlata.Name = "btnAdaugaPlata";
            this.btnAdaugaPlata.Size = new System.Drawing.Size(196, 34);
            this.btnAdaugaPlata.TabIndex = 6;
            this.btnAdaugaPlata.Text = "Adauga plata";
            this.btnAdaugaPlata.UseVisualStyleBackColor = true;
            this.btnAdaugaPlata.Click += new System.EventHandler(this.btnAdaugaPlata_Click);
            // 
            // btnCurataPlata
            // 
            this.btnCurataPlata.Location = new System.Drawing.Point(14, 302);
            this.btnCurataPlata.Name = "btnCurataPlata";
            this.btnCurataPlata.Size = new System.Drawing.Size(196, 37);
            this.btnCurataPlata.TabIndex = 7;
            this.btnCurataPlata.Text = "Curata formular";
            this.btnCurataPlata.UseVisualStyleBackColor = true;
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(14, 190);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(196, 22);
            this.tbSuma.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Suma";
            // 
            // tbDetalii
            // 
            this.tbDetalii.Location = new System.Drawing.Point(10, 140);
            this.tbDetalii.Name = "tbDetalii";
            this.tbDetalii.Size = new System.Drawing.Size(200, 22);
            this.tbDetalii.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Detalii plata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tip plata";
            // 
            // cbTaxaImpozit
            // 
            this.cbTaxaImpozit.FormattingEnabled = true;
            this.cbTaxaImpozit.Items.AddRange(new object[] {
            "Taxa",
            "Impozit"});
            this.cbTaxaImpozit.Location = new System.Drawing.Point(10, 93);
            this.cbTaxaImpozit.Name = "cbTaxaImpozit";
            this.cbTaxaImpozit.Size = new System.Drawing.Size(200, 24);
            this.cbTaxaImpozit.TabIndex = 3;
            // 
            // groupTipPersoana
            // 
            this.groupTipPersoana.Controls.Add(this.rbJuridica);
            this.groupTipPersoana.Controls.Add(this.rbFizica);
            this.groupTipPersoana.Location = new System.Drawing.Point(14, 21);
            this.groupTipPersoana.Name = "groupTipPersoana";
            this.groupTipPersoana.Size = new System.Drawing.Size(196, 49);
            this.groupTipPersoana.TabIndex = 2;
            this.groupTipPersoana.TabStop = false;
            this.groupTipPersoana.Text = "Tip persoana";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(107, 21);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(78, 21);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            // 
            // rbFizica
            // 
            this.rbFizica.AutoSize = true;
            this.rbFizica.Checked = true;
            this.rbFizica.Location = new System.Drawing.Point(6, 21);
            this.rbFizica.Name = "rbFizica";
            this.rbFizica.Size = new System.Drawing.Size(65, 21);
            this.rbFizica.TabIndex = 0;
            this.rbFizica.TabStop = true;
            this.rbFizica.Text = "Fizica";
            this.rbFizica.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data expirarii cardului";
            // 
            // dtpDataExpirare
            // 
            this.dtpDataExpirare.Location = new System.Drawing.Point(6, 187);
            this.dtpDataExpirare.Name = "dtpDataExpirare";
            this.dtpDataExpirare.Size = new System.Drawing.Size(200, 22);
            this.dtpDataExpirare.TabIndex = 13;
            // 
            // tbCVV
            // 
            this.tbCVV.Location = new System.Drawing.Point(6, 134);
            this.tbCVV.Name = "tbCVV";
            this.tbCVV.Size = new System.Drawing.Size(200, 22);
            this.tbCVV.TabIndex = 12;
            this.tbCVV.Validating += new System.ComponentModel.CancelEventHandler(this.tbCVV_Validating);
            this.tbCVV.Validated += new System.EventHandler(this.tbCVV_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cod CVV";
            // 
            // tbNrCard
            // 
            this.tbNrCard.Location = new System.Drawing.Point(6, 88);
            this.tbNrCard.Name = "tbNrCard";
            this.tbNrCard.Size = new System.Drawing.Size(200, 22);
            this.tbNrCard.TabIndex = 10;
            this.tbNrCard.Validating += new System.ComponentModel.CancelEventHandler(this.tbNrCard_Validating);
            this.tbNrCard.Validated += new System.EventHandler(this.tbNrCard_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Numar card";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(6, 38);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(200, 22);
            this.tbNume.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nume detinator";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel.Location = new System.Drawing.Point(281, 396);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(166, 17);
            this.linkLabel.TabIndex = 8;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Catre pagina principala...";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // epNumarCard
            // 
            this.epNumarCard.ContainerControl = this;
            // 
            // epCVV
            // 
            this.epCVV.ContainerControl = this;
            // 
            // groupBoxCard
            // 
            this.groupBoxCard.Controls.Add(this.btnAdaugaCard);
            this.groupBoxCard.Controls.Add(this.btnCurataCard);
            this.groupBoxCard.Controls.Add(this.label9);
            this.groupBoxCard.Controls.Add(this.label7);
            this.groupBoxCard.Controls.Add(this.tbNrCard);
            this.groupBoxCard.Controls.Add(this.label8);
            this.groupBoxCard.Controls.Add(this.dtpDataExpirare);
            this.groupBoxCard.Controls.Add(this.tbCVV);
            this.groupBoxCard.Controls.Add(this.label3);
            this.groupBoxCard.Controls.Add(this.tbNume);
            this.groupBoxCard.Location = new System.Drawing.Point(12, 31);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(228, 357);
            this.groupBoxCard.TabIndex = 9;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Card";
            // 
            // btnAdaugaCard
            // 
            this.btnAdaugaCard.Location = new System.Drawing.Point(10, 262);
            this.btnAdaugaCard.Name = "btnAdaugaCard";
            this.btnAdaugaCard.Size = new System.Drawing.Size(196, 34);
            this.btnAdaugaCard.TabIndex = 15;
            this.btnAdaugaCard.Text = "Adauga card";
            this.btnAdaugaCard.UseVisualStyleBackColor = true;
            this.btnAdaugaCard.Click += new System.EventHandler(this.btnAdaugaCard_Click);
            // 
            // btnCurataCard
            // 
            this.btnCurataCard.Location = new System.Drawing.Point(10, 302);
            this.btnCurataCard.Name = "btnCurataCard";
            this.btnCurataCard.Size = new System.Drawing.Size(196, 37);
            this.btnCurataCard.TabIndex = 16;
            this.btnCurataCard.Text = "Curata formular";
            this.btnCurataCard.UseVisualStyleBackColor = true;
            this.btnCurataCard.Click += new System.EventHandler(this.btnCurataCard_Click);
            // 
            // listBoxPlati
            // 
            this.listBoxPlati.FormattingEnabled = true;
            this.listBoxPlati.ItemHeight = 16;
            this.listBoxPlati.Location = new System.Drawing.Point(249, 221);
            this.listBoxPlati.Name = "listBoxPlati";
            this.listBoxPlati.Size = new System.Drawing.Size(240, 148);
            this.listBoxPlati.TabIndex = 10;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(107, 28);
            this.toolStripLabel2.Text = "Afiseaza grafic";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Neimplementat";
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrCardDataGridViewTextBoxColumn
            // 
            this.nrCardDataGridViewTextBoxColumn.DataPropertyName = "NrCard";
            this.nrCardDataGridViewTextBoxColumn.HeaderText = "NrCard";
            this.nrCardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrCardDataGridViewTextBoxColumn.Name = "nrCardDataGridViewTextBoxColumn";
            this.nrCardDataGridViewTextBoxColumn.Width = 125;
            // 
            // cVVDataGridViewTextBoxColumn
            // 
            this.cVVDataGridViewTextBoxColumn.DataPropertyName = "CVV";
            this.cVVDataGridViewTextBoxColumn.HeaderText = "CVV";
            this.cVVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cVVDataGridViewTextBoxColumn.Name = "cVVDataGridViewTextBoxColumn";
            this.cVVDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataExpirareDataGridViewTextBoxColumn
            // 
            this.dataExpirareDataGridViewTextBoxColumn.DataPropertyName = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn.HeaderText = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataExpirareDataGridViewTextBoxColumn.Name = "dataExpirareDataGridViewTextBoxColumn";
            this.dataExpirareDataGridViewTextBoxColumn.Width = 125;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataSource = typeof(project.Clase.Card);
            // 
            // FormPlati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 458);
            this.Controls.Add(this.listBoxPlati);
            this.Controls.Add(this.groupBoxCard);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.groupBoxPlata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip);
            this.KeyPreview = true;
            this.Name = "FormPlati";
            this.Text = "Plati";
            this.Load += new System.EventHandler(this.FormPlati_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPlati_KeyDown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCard)).EndInit();
            this.groupBoxPlata.ResumeLayout(false);
            this.groupBoxPlata.PerformLayout();
            this.groupTipPersoana.ResumeLayout(false);
            this.groupTipPersoana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumarCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCVV)).EndInit();
            this.groupBoxCard.ResumeLayout(false);
            this.groupBoxCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPlata;
        private System.Windows.Forms.ComboBox cbTaxaImpozit;
        private System.Windows.Forms.GroupBox groupTipPersoana;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFizica;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNrCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDetalii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataExpirare;
        private System.Windows.Forms.TextBox tbCVV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdaugaPlata;
        private System.Windows.Forms.Button btnCurataPlata;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.ErrorProvider epNumarCard;
        private System.Windows.Forms.ErrorProvider epCVV;
        private System.Windows.Forms.GroupBox groupBoxCard;
        private System.Windows.Forms.Button btnAdaugaCard;
        private System.Windows.Forms.Button btnCurataCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private System.Windows.Forms.ListBox listBoxPlati;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}