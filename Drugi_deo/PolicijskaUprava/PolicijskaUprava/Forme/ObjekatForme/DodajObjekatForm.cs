using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.ObjekatForme
{
    public partial class DodajObjekatForm : Form
    {
        public int idStanice;
        public DodajObjekatForm()
        {
            InitializeComponent();
        }

        public DodajObjekatForm(int idStanice)
        {
            InitializeComponent();
            this.idStanice = idStanice;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtAdresa.Text == "" || txtIme.Text == "" || txtPrezime.Text == "" ||
                txtTip.Text == "" || numPovrsina.Value == 0)
            {
                string str = "Unesite sve podatke !";
                if (numPovrsina.Value == 0)
                    str += "\nPovrsina objekta mora biti veca od 0!";
                MessageBox.Show(str);
                return;
            }
            ObjekatView o = new ObjekatView();
            o.Adresa = txtAdresa.Text;
            o.Povrsina = (int)numPovrsina.Value;
            o.Tip = txtTip.Text;
            o.KontaktIme = txtIme.Text;
            o.KontaktPrezime = txtPrezime.Text;
            o.PolicijskaStanicaId = idStanice;

            DTOManager.dodajObjekatStanici(o, idStanice);
            MessageBox.Show("Dodali ste objekat !");

            txtAdresa.Text = "";
            numPovrsina.Value = 0;
            txtTip.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
        }
    }
}
