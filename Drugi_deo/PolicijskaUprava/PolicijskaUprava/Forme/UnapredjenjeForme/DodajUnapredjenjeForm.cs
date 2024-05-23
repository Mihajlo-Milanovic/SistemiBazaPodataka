using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.UnapredjenjeForme
{
    public partial class DodajUnapredjenjeForm : Form
    {
        private int policajacId;

        public DodajUnapredjenjeForm()
        {
            InitializeComponent();
        }

        public DodajUnapredjenjeForm(int policajacId)
        {
            InitializeComponent();
            this.policajacId = policajacId;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UnapredjenjeView uv = new UnapredjenjeView();
            uv.DatumSticanja = dtpSticanje.Value;
            uv.Cin = txtCin.Text;
            DTOManager.dodajUnapredjenjeZaPolicajca(uv,policajacId);
            MessageBox.Show("Dodali ste unapredjenje policajcu.");
        }
    }
}
