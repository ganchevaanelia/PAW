using project.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FormPlati : Form
    {
        PlatiAppContext ctx = new PlatiAppContext();
        public List<Plata> ListPlati = new List<Plata>();
        public FormPlati()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormPrincipal principal = new FormPrincipal();
            principal.ShowDialog();
            this.Close();
        }

        #region ErrorProviders
     

        private void tbCVV_Validated(object sender, EventArgs e)
        {
            epCVV.Clear();
        }

        private void tbCVV_Validating(object sender, CancelEventArgs e)
        {
            String cvv = tbCVV.Text;

            if (String.IsNullOrEmpty(cvv) || String.IsNullOrWhiteSpace(cvv) || cvv.Length != 3)
            {
                epCVV.SetError(this.tbCVV, "Codul CVV contine exact 3 caractere.");
                e.Cancel = true;
            }
        }
        private void tbNrCard_Validated(object sender, EventArgs e)
        {
            epNumarCard.Clear();
        }

        private void tbNrCard_Validating(object sender, CancelEventArgs e)
        {
            String numar = tbNrCard.Text;

            if (String.IsNullOrEmpty(numar) || String.IsNullOrWhiteSpace(numar) || numar.Length != 16)
            {
                epNumarCard.SetError(this.tbNrCard, "Numarul cardului contine exact 16 caractere.");
                e.Cancel = true;
            }
        }
        #endregion
     private void btnAdaugaCard_Click(object sender, EventArgs e)
        {
            bool valid = true;

            String nume = tbNume.Text;
            if (String.IsNullOrEmpty(nume) || String.IsNullOrWhiteSpace(nume) || nume.Length < 2)
            {
                valid = false;
            }
            DateTime data = dtpDataExpirare.Value;
            if (DateTime.Compare(data, DateTime.Now) < 0)
            {
                valid = false;
            }
            if (valid)
            {
                Card card = new Card()
                {
                    Nume = tbNume.Text,
                    NrCard = tbNrCard.Text,
                    CVV = tbCVV.Text,
                    DataExpirare = dtpDataExpirare.Value,
                };
                ctx.Carduri.Add(card);

                CurataFormularCard();
            }
            else
            {
                MessageBox.Show("Formularul de carduri contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            ctx.SaveChanges();
            cardBindingSource.DataSource = ctx.Carduri.ToList();
        }
        private void btnAdaugaPlata_Click(object sender, EventArgs e)
        {
            bool valid = true;
 
            String tipPersoana = "fizica";
            if (rbJuridica.Checked)
            {
                tipPersoana = "juridica";
            }
            int indexTip = cbTaxaImpozit.SelectedIndex;
            TipPlata tipPlata;

            if(indexTip ==0)
            {
                tipPlata = TipPlata.TAXA;
            }
            else 
            {
                tipPlata = TipPlata.IMPOZIT;
            }


            double.TryParse(tbSuma.Text, out double s);
            if (s==0)
            {
                valid = false;
            }

            if (valid)
            {
                Plata p = new Plata(tipPersoana,tipPlata, tbDetalii.Text, s);
                ListPlati.Add(p);
                CurataFormularPlata();
            }
            else
            {
                MessageBox.Show("Formularul de plata contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            listBoxPlati.DataSource = null;
            String[] platiDetalii = new string[ListPlati.Count];
            int k = 0;
            foreach (Plata p in ListPlati)
            {
                platiDetalii[k] = p.Detalii;
                k++;
            }

            listBoxPlati.DataSource = platiDetalii;
          }

        #region CuratareFormulare
        private void CurataFormularPlata()
        {
            rbFizica.Checked=false;
            rbJuridica.Checked = false;
            cbTaxaImpozit.SelectedIndex = -1;
            tbDetalii.Clear();
            tbSuma.Clear();
        }

        private void CurataFormularCard()
        {  
            tbNume.Clear();
            tbNrCard.Clear();
            tbCVV.Clear();
            dtpDataExpirare.Value = DateTime.Now;
        }

        private void btnCurataPlata_Click(object sender, EventArgs e)
        {
            CurataFormularPlata();
        }


        private void btnCurataCard_Click(object sender, EventArgs e)
        {
            CurataFormularCard();
        }
        #endregion

        private void FormPlati_Load(object sender, EventArgs e)
        {
            cardBindingSource.DataSource = ctx.Carduri.ToList();
        }

        private void toolStripPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDoc;
            pageSetupDialog.PageSettings = printDoc.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.DefaultPageSettings = pageSetupDialog.PageSettings;

                printPreviewDialog.Document = printDoc;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Roboto", 16);
            Brush brush = Brushes.DarkGreen;
            Pen pen = new Pen(brush);

            PageSettings settings = printDoc.DefaultPageSettings;

            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalDrawableW;
                totalDrawableW = totalDrawableH;
                totalDrawableH = temp;
            }

            int cellWidth = totalDrawableW / 4;
            int cellHeight = 30;

            int x = settings.Margins.Left;
            int y = 40;

            graphics.DrawString("Lista carduri", font, brush, totalDrawableW / 3, y);

            y += 40;

            // desenare format cap de tabel
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + 2*cellWidth, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + 3*cellWidth, y, cellWidth, cellHeight);

            // desenare continut cap de tabel
            graphics.DrawString("Nume detinator", font, brush, x, y);
            graphics.DrawString("Numar card", font, brush, x + cellWidth, y);
            graphics.DrawString("Cod CVV", font, brush, x + 2*cellWidth, y);
            graphics.DrawString("Data ", font, brush, x + 3*cellWidth, y);

            y += cellHeight;

            List<Card> carduri = ctx.Carduri.ToList();

            foreach (Card c in carduri)
            {
                Font font2 = new Font("Ariel", 14);
                Brush brush2 = Brushes.Red;
                Pen pen2 = new Pen(brush2);
                // desenare celule
                graphics.DrawRectangle(pen2, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen2, x + cellWidth, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen2, x + 2*cellWidth, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen2, x + 3*cellWidth, y, cellWidth, cellHeight);

                // desenare continut celule
                graphics.DrawString(c.Nume, font2, brush2, x, y);
                graphics.DrawString(c.NrCard, font2, brush2, x + cellWidth, y);
                graphics.DrawString(c.CVV, font2, brush2, x+2*cellWidth, y);
                graphics.DrawString(c.DataExpirare.ToString(), font2, brush2, x + 3*cellWidth, y);

                y += cellHeight;
            }
        }

        private void FormPlati_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Alt)
            {
                toolStripPrint_Click(sender, e);
            }
        }
    }
}
