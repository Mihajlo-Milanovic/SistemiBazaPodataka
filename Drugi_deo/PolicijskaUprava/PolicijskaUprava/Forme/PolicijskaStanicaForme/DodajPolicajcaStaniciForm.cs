namespace PolicijskaUprava.Forme.PolicijskaStanicaForme {
	public partial class DodajPolicajcaStaniciForm : Form {

		PolicajacView p;
		int stanicaId;
		int pozicija;

		public DodajPolicajcaStaniciForm(int stanicaId) {
			InitializeComponent();

			rbtnZaposleni.Checked = true;
			btnDodaj.Enabled = false;
			this.stanicaId = stanicaId;

			p = new();
		}

		private void button1_Click(object sender, EventArgs e) {

			new SlobodniPolicajciForm(p).ShowDialog();

			btnIzaberi.Text = p.Id.ToString();

			btnDodaj.Enabled = true;
		}

		private void btnDodaj_Click(object sender, EventArgs e) {

			if(rbtnZaposleni.Checked == true) {
				pozicija = 0;
			}else if(rbtnSef.Checked == true) {
				pozicija = 1;
			}else {
				pozicija = 2;
			}

			if (DTOManager.dodajPolicajcaStanici(p.Id, stanicaId, pozicija))
				MessageBox.Show("Uspesno ste dodali policajca sa ID: " + p.Id + " u stanicu sa ID: " + stanicaId);
		}
	}
}
