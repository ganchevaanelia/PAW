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
    public partial class FormListBox : Form
    {
        public FormListBox()
        {
            InitializeComponent();
        }

        public void UpdateListBox(Echipa e)
        {
            listBox.Items.Add(e.Nume);
            listBox.Items.Add(e.AreLotDeJuniori);
            listBox.Items.Add(e.DataInfiintarii);
            listBox.Items.Add(e.Buget);
          //  listBox.Items.Add(e.TrofeeCastigate.ToString());
        }

        private void formularEchipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEchipe fEchipe = new FormEchipe();
            fEchipe.ShowDialog();
            this.Close();
        }
    }
}
