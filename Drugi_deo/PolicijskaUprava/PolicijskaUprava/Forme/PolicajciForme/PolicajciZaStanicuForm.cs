using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.PolicajciForme
{
    public partial class PolicajciZaStanicuForm_ : Form
    {
        public int idStanice;

        public PolicajciZaStanicuForm_(int idStanice)
        {
            InitializeComponent();
            this.idStanice = idStanice;
            osvezi();
        }

        private void osvezi()
        {
            bindingSource1.DataSource = DTOManager.vratiPolicajceZaPolicijskuStanicu(idStanice);

            dgvPolicajci.DataSource = bindingSource1.DataSource;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new DodajPolicajcaStaniciForm(idStanice).ShowDialog();
            osvezi();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            int rInd = dgvPolicajci.SelectedCells[0].RowIndex;

			new AzurirajPolicajcaStaniciForm((int)dgvPolicajci.Rows[rInd].Cells[0].Value).ShowDialog();
			osvezi();
		}

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPolicajci.SelectedRows.Count > 0)
            {

                string poruka = $"Da li sigurno zelite da obrisete policajca sa ID: {(int)dgvPolicajci.SelectedCells[0].Value}?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {

                    DTOManager.ukloniPolicajcaIzStanice((int)dgvPolicajci.SelectedCells[0].Value);
                    osvezi();
                }

            }
        }
    }
}
