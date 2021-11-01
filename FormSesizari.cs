using project.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FormSesizari : Form
    {
        List<Sesizare> ListaSesizari = null;
        public FormSesizari()
        {
            InitializeComponent();
            ListaSesizari = new List<Sesizare>();
        }

        #region CRUD
        private void btnAdaugaEditeaza_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (lvSesizari.SelectedItems.Count == 0)
            {
                String detalii = tbDetaliiSesizare.Text;
                if (String.IsNullOrEmpty(detalii) || String.IsNullOrWhiteSpace(detalii))
                {
                    valid = false;
                }

                String nume = tbNume.Text;
                if (String.IsNullOrEmpty(nume) || String.IsNullOrWhiteSpace(nume) || nume.Length < 2)
                {
                    valid = false;
                }

                int indexCat = cbCategorie.SelectedIndex;
                CategorieSesizare categorie;

                if (indexCat == 0)
                {
                    categorie = CategorieSesizare.PARCURI;
                }
                else if (indexCat == 1)
                {
                    categorie = CategorieSesizare.STRAZI;
                }
                else if (indexCat == 2)
                {
                    categorie = CategorieSesizare.PARCARI;
                }
                else
                {
                    categorie = CategorieSesizare.ALTELE;
                }
                if (valid)
                {
                    Sesizare sesizare = new Sesizare(categorie, detalii, nume);
                    ListaSesizari.Add(sesizare);
                    populeazaListView();
                    cbCategorie.SelectedIndex = -1;
                    tbDetaliiSesizare.Clear();
                    tbNume.Clear();
                }
                else
                {
                    MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnCurataSterge_Click(object sender, EventArgs e)
        {
            
            if (lvSesizari.SelectedItems.Count != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Doresti sa stergi aceasta instanta?",
                    "Stergere sesizare", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    ListaSesizari.RemoveAt(lvSesizari.SelectedIndices[0]);
                    populeazaListView();
                }
            }
            else
            { 
                cbCategorie.SelectedIndex = -1;
                 tbDetaliiSesizare.Clear();
                 tbNume.Clear(); 
            }
        }
        #endregion

        private void populeazaListView()
        {
            lvSesizari.Items.Clear();

            foreach (Sesizare s in ListaSesizari)
            {
                ListViewItem lvi = new ListViewItem(new String[] { s.Categorie.ToString(),
                        s.Detalii, s.NumePersoana});
                lvi.Tag = s;
                lvSesizari.Items.Add(lvi);
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormPrincipal principal = new FormPrincipal();
            principal.ShowDialog();
            this.Close();
        }

        private void lvSesizari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
               lvSesizari.FocusedItem.Bounds.Contains(e.Location))
            {

                Sesizare s = ListaSesizari.ElementAt(lvSesizari.SelectedIndices[0]);

                cbCategorie.Text = s.Categorie.ToString();
                tbDetaliiSesizare.Text = s.Detalii;
                tbNume.Text = s.NumePersoana;
                btnAdaugaEditeaza_Click(s, e);

            }
        }

        private void lvSesizari_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }


        #region Serializare/deserializare/Export

        private void SerializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream("sesizari.dat", FileMode.Create);
            binaryFormatter.Serialize(stream, ListaSesizari);
            stream.Close();
            MessageBox.Show("Sesizarile au fost salvate in fisier binar");
        }

        private void DeserializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul binar pentru deserializare";
            ofd.Filter = "Binary files (*.dat)|*.dat";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = File.OpenRead(ofd.FileName);
                ListaSesizari = binaryFormatter.Deserialize(fileStream) as List<Sesizare>;
                fileStream.Close();
                populeazaListView();
            }
        }

        private void exportTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);
                writer.Write("Categorie Detalii Nume\n");

                foreach (Sesizare s in ListaSesizari)
                {
                    writer.WriteLine(s.Categorie.ToString() + " " + s.Detalii + " " + s.NumePersoana);
                }
                writer.Close();
                MessageBox.Show("Sesizarile au fost salvate in fisier text");
            }
        }
        #endregion
    }
}
