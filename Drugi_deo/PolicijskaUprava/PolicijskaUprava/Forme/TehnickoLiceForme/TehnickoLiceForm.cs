namespace PolicijskaUprava.Forme.TehnickoLiceForme {
	public partial class TehnickaLicaForm : Form {

		public TehnickaLicaForm() {
			InitializeComponent();

			bsTehnickoLice.DataSource = DTOManager.vratiSvaTehnickaLica();

			dgvListaTehnickihLica.DataSource = bsTehnickoLice;
		}

		private void btnDodajTehnickoLice_Click(object sender, EventArgs e) {

			DodajTehnickoLiceForm dtlForma = new();

			dtlForma.ShowDialog();

			bsTehnickoLice.DataSource = DTOManager.vratiSvaTehnickaLica();
		}

		private void btnObrisiTehnickoLice_Click(object sender, EventArgs e) {

			int rIndex = dgvListaTehnickihLica.SelectedCells[0].RowIndex;
			int id = (int)dgvListaTehnickihLica.Rows[rIndex].Cells[0].Value;

			if (DTOManager.obrisiTehnickoLice(id))
				bsTehnickoLice.RemoveAt(rIndex);

		}

		private void btnIzmeniTehnickoLice_Click(object sender, EventArgs e) {

			TehnickoLice t = new();

			int rIndex = dgvListaTehnickihLica.SelectedCells[0].RowIndex;

			t.Id = (int)dgvListaTehnickihLica.Rows[rIndex].Cells[0].Value;
			t.Ime = (string)dgvListaTehnickihLica.Rows[rIndex].Cells[1].Value;
			t.Prezime = (string)dgvListaTehnickihLica.Rows[rIndex].Cells[2].Value;

			IzmeniTehnickoLiceForm itlForma = new(t);

			itlForma.ShowDialog();

			dgvListaTehnickihLica.Rows[rIndex].Cells[1].Value = t.Ime;
			dgvListaTehnickihLica.Rows[rIndex].Cells[2].Value = t.Prezime;

		}
	}
}
