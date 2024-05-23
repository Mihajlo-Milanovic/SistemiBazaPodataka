using PolicijskaUprava.Entiteti;
using PolicijskaUprava.Forme.UnapredjenjeForme;
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
    public partial class ObrazovanjeForm : Form
    {
        public int policajacId;
        public ObrazovanjeForm()
        {
            InitializeComponent();
        }

        public ObrazovanjeForm(int policajacId)
        {
            InitializeComponent();
            this.policajacId = policajacId;
            osvezi();
        }

        private void osvezi()
        {
            dgvObrazovanja.DataSource = DTOManager.vratiObrazovanjaZaPolicajca(policajacId);
            bindingSource1.DataSource = dgvObrazovanja;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new DodajObrazovanjeForm(policajacId).ShowDialog();
            osvezi();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvObrazovanja.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvObrazovanja.SelectedRows)
                {
                    if (!row.IsNewRow)
                        DTOManager.obrisiObrazovanje(row.Cells[0].Value.ToString(),(DateTime)row.Cells[1].Value, policajacId);
                }
            }
            else
            {
                MessageBox.Show("Nema selektovanog obrazovanja za brisanje.");
            }
            osvezi();
        }
    }
}
