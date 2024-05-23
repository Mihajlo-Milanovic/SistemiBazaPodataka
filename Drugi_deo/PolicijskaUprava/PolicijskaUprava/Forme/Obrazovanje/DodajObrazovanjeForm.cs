using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.Obrazovanje
{
    public partial class DodajObrazovanjeForm : Form
    {
        public int policajacId;
        public DodajObrazovanjeForm()
        {
            InitializeComponent();
        }
        public DodajObrazovanjeForm(int policajacId)
        {
            InitializeComponent();
            this.policajacId = policajacId;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ObrazovanjeView ov = new ObrazovanjeView();
            ov.DatumDipolomirnja = dtpDiplomiranje.Value;
            ov.Skola = txtSkola.Text;
            DTOManager.dodajObrazovanjeZaPolicajca(ov, policajacId);
            MessageBox.Show("Dodali ste novo obrazovanje za policajca.");
        }
    }
}
