using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.VozilaForme
{
    public partial class DodajVoziloForm : Form
    {
        public DodajVoziloForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtRegOznaka.Text == "" || txtProizvodjac.Text == "" || txtModel.Text == ""
                || txtBoja.Text == "" || txtTip.Text == "")
            {
                MessageBox.Show("Svi podaci su neophodni !");
                return; 
            }

            string poruka = "Da li zelite da dodate novo vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            Vozilo vozilo = new Vozilo(txtRegOznaka.Text,txtBoja.Text,txtTip.Text,txtProizvodjac.Text,txtModel.Text);

            DTOManager.DodajVozilo(vozilo);
        }
    }
}
