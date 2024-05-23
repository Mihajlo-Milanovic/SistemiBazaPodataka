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
    public partial class UnapredjenjeForm : Form
    {
        public int policajacId;
        public UnapredjenjeForm()
        {
            InitializeComponent();
        }
        public UnapredjenjeForm(int policajacId)
        {
            InitializeComponent();
            this.policajacId = policajacId;
            osvezi();
        }

        private void osvezi()
        {
            dgvUnapredjenja.DataSource = DTOManager.vratiUnapredjenjaZaPolicajca(policajacId);
            bindingSource1.DataSource = dgvUnapredjenja;
            /*dgvUnapredjenja.Sort(dgvUnapredjenja.Columns[1], System.ComponentModel.ListSortDirection.Ascending);*/
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new DodajUnapredjenjeForm(policajacId).ShowDialog();
            osvezi();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvUnapredjenja.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUnapredjenja.SelectedRows)
                {
                    if (!row.IsNewRow)
                        DTOManager.obrisiUnapredjenje((DateTime)row.Cells[1].Value, policajacId);
                }
            }
            else
            {
                MessageBox.Show("Nema selektovanog unapredjenja za brisanje.");
            }
            osvezi();
        }
    }
}
