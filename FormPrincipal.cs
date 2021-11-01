using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FormPrincipal : Form
    {
        bool imageOnFirst = true;

        public FormPrincipal()
        {
            
            InitializeComponent();

            pic1.ImageLocation = "https://www.iasi4u.ro/wp-content/uploads/2020/10/Palas-Iasi-2-300x180.jpg";
        }


        private void platiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPlati plati = new FormPlati();
            plati.ShowDialog();
            this.Close();
        }

        private void sesizariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSesizari sesizari = new FormSesizari();
            sesizari.ShowDialog();
            this.Close();
        }

        private void tsmClipboard_Click(object sender, EventArgs e)
        {
            if (imageOnFirst)
            {
                Clipboard.SetImage(pic1.Image);
                pic2.Image = Clipboard.GetImage();
                pic1.Image = null;
                imageOnFirst = false;
            }
            else
            {
                Clipboard.SetImage(pic2.Image);
                pic1.Image = Clipboard.GetImage();
                pic2.Image = null;
                imageOnFirst = true;
            }
        }
    }
}
