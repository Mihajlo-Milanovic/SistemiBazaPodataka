using PolicijskaUprava.Forme.VozilaForme;
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
    public partial class VozilaForm : Form
    {
        public VozilaForm()
        {
            InitializeComponent();
        }

        private void VozilaForm_Load(object sender, EventArgs e)
        {
            osvezi();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            new DodajVoziloForm().ShowDialog();
            osvezi();
        }
    
        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (dgvVozila.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVozila.SelectedRows)
                {
                    if (!row.IsNewRow)  
                        DTOManager.ObrisiVozilo(row.Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nema selektovanog reda za brisanje.");
            }
            osvezi();
        }

        private void btnAzurirajVozilo_Click(object sender, EventArgs e)
        {
            Vozilo obj = new Vozilo();

            if (dgvVozila.SelectedRows.Count == 1)
            {

                DataGridViewRow red = dgvVozila.SelectedRows[0];

                obj.RegOznaka = (string)dgvVozila.SelectedRows[0].Cells[0].Value;
                obj.Boja = (string)dgvVozila.SelectedRows[0].Cells[1].Value;
                obj.Tip = (string)dgvVozila.SelectedRows[0].Cells[2].Value;
                obj.Proizvodjac = (string)dgvVozila.SelectedRows[0].Cells[3].Value;
                obj.Model = (string)dgvVozila.SelectedRows[0].Cells[4].Value;
                new AzurirajVoziloForm(obj).ShowDialog();

                red.Cells[0].Value = obj.RegOznaka;
                red.Cells[1].Value = obj.Boja;
                red.Cells[2].Value = obj.Tip;
                red.Cells[3].Value = obj.Proizvodjac;
                red.Cells[4].Value = obj.Model;
            }
            else if(dgvVozila.SelectedRows.Count == 0)
                MessageBox.Show("Selektujte 1 red!");
            else
                MessageBox.Show("Selektujte 1 red, ne vise!");

            //dgvVozila.Rows[0].Cells[0].Value = obj.RegOznaka;
        }

        private void osvezi()
        {
            dgvVozila.DataSource = DTOManager.vratiSvaVozila();

            bindingSource1.DataSource = dgvVozila;
        }
    }
}
