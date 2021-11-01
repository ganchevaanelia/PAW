using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lucrare
{
    public partial class FormEchipe : Form
    {
        List<int> listaTrofee = new List<int>();
        public FormEchipe()
        {
            InitializeComponent();
        }

        private void CurataFormular()
        {
            tbNume.Clear();
            tbBuget.Clear();
            tbTrofee.Clear();
            dtpInfiintare.Value = DateTime.Now;
            checkLotJunioriDa.Checked = false;
            cbTrofee.Items.Clear();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool valid = true;

            String nume = tbNume.Text;
            if (String.IsNullOrEmpty(nume) ||
                String.IsNullOrWhiteSpace(nume) ||
                nume.Length < 3)
            {
                valid = false;
            }

            bool check = false;
            if (checkLotJunioriDa.Checked)
            {
                check = true;
            }

            DateTime data = dtpInfiintare.Value;
            if (DateTime.Compare(data, DateTime.Now) > 0)
            {
                valid = false;
            }

            double.TryParse(tbBuget.Text, out double buget);
            if (buget == 0)
            {
                valid = false;
            }

            if (valid)
            {
                Echipa echipa = new Echipa(nume, check, data, buget, listaTrofee);
                FormListBox fListBox = new FormListBox();
                fListBox.UpdateListBox(echipa);

                CurataFormular();
            }
            else
            {
                MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnAdaugaTrofee_Click(object sender, EventArgs e)
        {
            int.TryParse(tbTrofee.Text, out int ani);
            if (ani > 1900 && ani < 2020)
            {
                cbTrofee.Items.Add(ani);
                listaTrofee.Add(ani);
            }  
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            CurataFormular();
        }

        private void formularListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormListBox fListBox = new FormListBox();
            fListBox.ShowDialog();
            this.Close();
        }
    }
}
