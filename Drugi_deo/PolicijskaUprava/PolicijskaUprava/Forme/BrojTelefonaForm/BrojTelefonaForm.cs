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
    public partial class BrojTelefonaForm : Form
    {
        public int idObjekta;
        public BrojTelefonaForm()
        {
            InitializeComponent();
        }
        public BrojTelefonaForm(int idObjekta)
        {
            InitializeComponent();
            this.idObjekta = idObjekta;
            osvezi();
        }
        private void BrojTelefonaForm_Load(object sender, EventArgs e)
        {

        }
        public void osvezi()
        {
            dgvBrojevi.DataSource = DTOManager.VratiTelefoneZaObjekat(idObjekta);
            bindingSource1.DataSource = dgvBrojevi;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new DodajBrojTelefonaForm(this.idObjekta).ShowDialog();
            osvezi();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvBrojevi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvBrojevi.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string poruka = $"Da li sigurno zelite da obrisete broj: {row.Cells[0].Value.ToString()}?";
                        string title = "Pitanje";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(poruka, title, buttons);

                        if (result == DialogResult.OK)
                            DTOManager.ObrisiBroj(row.Cells[0].Value.ToString(),idObjekta);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nema selektovanog reda za brisanje.");
            }
            osvezi();
        }
    }
}
