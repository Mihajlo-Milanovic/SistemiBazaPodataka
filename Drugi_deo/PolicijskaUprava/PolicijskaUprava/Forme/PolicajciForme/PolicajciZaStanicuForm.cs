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
            new DodajPolicajcaForm(idStanice).ShowDialog();
            osvezi();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Policajac policajac = new Policajac();

            if (dgvPolicajci.SelectedRows.Count == 1)
            {

                DataGridViewRow red = dgvPolicajci.SelectedRows[0];

                int Id = (int)red.Cells[0].Value;

                policajac = DTOManager.VratiPolicajca(Id);

                new AzurirajPolicajcaForm(policajac).ShowDialog();

                osvezi();
            }
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

                    DTOManager.ObrisiPolicajcaID((int)dgvPolicajci.SelectedCells[0].Value);
                    osvezi();
                }

            }
        }
    }
}
