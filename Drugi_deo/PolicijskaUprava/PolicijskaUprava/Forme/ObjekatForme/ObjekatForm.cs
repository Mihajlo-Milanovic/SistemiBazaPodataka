namespace PolicijskaUprava.Forme.ObjekatForme
{
    public partial class ObjekatForm : Form
    {
        public int idStanice;
        public ObjekatForm()
        {
            InitializeComponent();
        }

        public ObjekatForm(int idStanice)
        {
            this.idStanice = idStanice;
            InitializeComponent();

            //MessageBox.Show(idStanice.ToString());
            // DTOManager.dodajObjekatStanici(this, idStanice);
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
            btnDodaj.Enabled = false;
            btnAzuriraj.Enabled = true;
            btnObrisi.Enabled = true;
            btnBroj.Enabled = true;
           // MessageBox.Show("Kliknut :" + dgvObjekti.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void dgvObjekti_CellClick(object sender, EventArgs e)
        {
            btnDodaj.Enabled = true;
            btnAzuriraj.Enabled = false;
            btnObrisi.Enabled = false;
            btnBroj.Enabled = false;
        }
        private void osvezi()
        {
            dgvObjekti.DataSource = DTOManager.vratiSveObjekte();

            bindingSource.DataSource = dgvObjekti;
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
            if (dgvObjekti.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvObjekti.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string poruka = $"Da li sigurno zelite da obrisete objekat sa IDem: {(int)row.Cells[0].Value}?";
                        string title = "Pitanje";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(poruka, title, buttons);

                        if (result == DialogResult.OK)
                            DTOManager.ObrisiObjekat((int)row.Cells[0].Value);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nema selektovanog reda za brisanje.");
            }
            osvezi();
        }
        private void btnBroj_Click(object sender, EventArgs e)
        {
            new BrojTelefonaForm.BrojTelefonaForm((int)dgvObjekti.SelectedRows[0].Cells[0].Value).ShowDialog();
        }
    }
}
