namespace PolicijskaUprava.Forme.PatroleForm {
	public partial class ListaVozilaForm : Form {

		PatrolaView vv;

		public ListaVozilaForm(PatrolaView vv) {
			InitializeComponent();
			this.vv = vv;
			dataGridView1.DataSource = DTOManager.vratiSvaVozila();

		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {
			vv.RegOznakaVozila = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
			this.Close();
		}
	}
}
