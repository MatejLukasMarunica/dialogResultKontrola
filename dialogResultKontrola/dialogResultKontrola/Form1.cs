using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogResultKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOtvori_Click(object sender, EventArgs e)
        {
            
            DialogResult rez = MessageBox.Show("Odaberite jednu od 3 opcija: Yes/No/Cancel", "Naslovna linija Dijaloga za poruke", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            switch(rez)
            {
                case DialogResult.Yes:
                    textBoxRezultat.Text = "Kliknuli ste opciju ---> YES!";
                    break;
                case DialogResult.No:
                    textBoxRezultat.Text = "Kliknuli ste opciju ---> NO!";
                    break;
                case DialogResult.Cancel:
                    textBoxRezultat.Text = "Kliknuli ste opciju ---> CANCEL!";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
