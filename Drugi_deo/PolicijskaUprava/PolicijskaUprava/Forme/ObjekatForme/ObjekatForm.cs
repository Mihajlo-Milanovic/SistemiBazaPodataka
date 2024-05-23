namespace PolicijskaUprava.Forme.ObjekatForme
{
    public partial class ObjekatForm : Form
    {
        public int idStanice;

        public ObjekatForm(int idStanice)
        {
            InitializeComponent();
            this.idStanice = idStanice;
        }

        private void ObekatForm_Load(object sender, EventArgs e)
        {
            btnAzuriraj.Enabled = false;
            btnObrisi.Enabled = false;
            btnBroj.Enabled = false;
            osvezi();
        }
        private void dgvObjekti_RowHeaderMouseClick(object sender, EventArgs e)
        {
            btnAzuriraj.Enabled = true;
            btnObrisi.Enabled = true;
            btnBroj.Enabled = true;
        }

        
        private void dgvObjekti_CellClick(object sender, EventArgs e)
        {
            btnAzuriraj.Enabled = false;
            btnObrisi.Enabled = false;
            btnBroj.Enabled = false;
        }
        
        private void osvezi()
        {
			bindingSource.DataSource = DTOManager.vratiObjekteZaPolicijskuStanicu(idStanice);

            dgvObjekti.DataSource = bindingSource.DataSource;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new DodajObjekatForm(idStanice).ShowDialog();
            osvezi();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            ObjekatView obj = new ObjekatView();

            if (dgvObjekti.SelectedRows.Count == 1)
            {

                DataGridViewRow red = dgvObjekti.SelectedRows[0];

                obj.Id = (int)dgvObjekti.SelectedRows[0].Cells[0].Value;
                obj.Tip = (string)dgvObjekti.SelectedRows[0].Cells[1].Value;
                obj.Adresa = (string)dgvObjekti.SelectedRows[0].Cells[2].Value;
                obj.Povrsina = (int)dgvObjekti.SelectedRows[0].Cells[3].Value;
                obj.KontaktIme = (string)dgvObjekti.SelectedRows[0].Cells[4].Value;
                obj.KontaktPrezime= (string)dgvObjekti.SelectedRows[0].Cells[5].Value;
                new AzurirajObjekatForm(obj).ShowDialog();

                red.Cells[0].Value = obj.Id;
                red.Cells[1].Value = obj.Tip;
                red.Cells[2].Value = obj.Adresa;
                red.Cells[3].Value = obj.Povrsina;
                red.Cells[4].Value = obj.KontaktIme;
                red.Cells[5].Value = obj.KontaktPrezime;
            }
            else if (dgvObjekti.SelectedRows.Count == 0)
                MessageBox.Show("Selektujte 1 red!");
            else
                MessageBox.Show("Selektujte 1 red, ne vise!");
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvObjekti.SelectedRows.Count > 0) {

                string poruka = $"Da li sigurno zelite da obrisete objekat sa ID: {(int)dgvObjekti.SelectedCells[0].Value}?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK) {

                    DTOManager.ObrisiObjekat((int)dgvObjekti.SelectedCells[0].Value);
					osvezi();
				}

            }
            else {
                MessageBox.Show("Nema selektovanog reda za brisanje.");
            }
            
        }
        private void btnBroj_Click(object sender, EventArgs e)
        {
            new BrojTelefonaForm.BrojTelefonaForm((int)dgvObjekti.SelectedRows[0].Cells[0].Value).ShowDialog();
        }
    }
}
