namespace PolicijskaUprava.Forme.PatroleForme {
	public partial class PatroleForm : Form {
		public PatroleForm() {
			InitializeComponent();
			bsPatrole.DataSource = DTOManager.vratiSvePatrole();
			dgvPatrole.DataSource = bsPatrole;
		}

		private void btnDodaj_Click(object sender, EventArgs e) {

			new DodajPatroluForm().ShowDialog();
			bsPatrole.DataSource = DTOManager.vratiSvePatrole();

		}

		private void btnIzmeni_Click(object sender, EventArgs e) {

			int rid = dgvPatrole.SelectedCells[0].RowIndex;

			PatrolaView pv = new PatrolaView();
			pv.RedniBroj = (int)dgvPatrole.Rows[rid].Cells[0].Value;
			pv.RegOznakaVozila = (string)dgvPatrole.Rows[rid].Cells[1].Value;
			pv.SefId = (int)dgvPatrole.Rows[rid].Cells[2].Value;
			pv.PomocnikId = (int)dgvPatrole.Rows[rid].Cells[4].Value;

			new IzmeniPatroluForm(pv).ShowDialog();

			bsPatrole.DataSource = DTOManager.vratiSvePatrole();
		}

		private void btnObrisi_Click(object sender, EventArgs e) {

			int rid = dgvPatrole.SelectedCells[0].RowIndex;
			PatrolaView pv = new();
			pv.RedniBroj = (int)dgvPatrole.Rows[rid].Cells[0].Value;
			if(DTOManager.obrisiPatrolu(pv))
				bsPatrole.RemoveAt(rid);
		}
	}
}
