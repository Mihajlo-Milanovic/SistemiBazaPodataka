using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.BrojTelefonaForm
{
    public partial class DodajBrojTelefonaForm : Form
    {
        public int idObjekta;
        public DodajBrojTelefonaForm()
        {
            InitializeComponent();
        }
        public DodajBrojTelefonaForm(int idObjekta)
        {
            this.idObjekta = idObjekta;
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DTOManager.dodajBrojTelefonaZaObjekat(new BrojTelefonaView(txtBroj.Text), this.idObjekta);
            MessageBox.Show("Dodali ste novi broj.");
            this.Close();
        }
    }
}
