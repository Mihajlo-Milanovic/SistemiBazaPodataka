namespace PolicijskaUprava.Forme.PolicajciForme {
	public partial class SlobodniPolicajciForm : Form {

		PolicajacView p;

		public SlobodniPolicajciForm(PolicajacView p) {
			InitializeComponent();
			this.p = p;
			dataGridView1.DataSource = DTOManager.vratiSveSlobodnePolicajce();
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {

			if(dataGridView1.SelectedRows.Count > 0) {

				p.Id = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
				this.Close();
			}
		}
	}
}
