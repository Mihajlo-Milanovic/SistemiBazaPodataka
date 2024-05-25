using PolicijskaUprava.Forme.PatroleForm;

namespace PolicijskaUprava.Forme.PatroleForme {
	public partial class IzmeniPatroluForm : Form {

		PatrolaView pv;

		public IzmeniPatroluForm(PatrolaView pv) {
			InitializeComponent();
			this.pv = pv;

			btnIzaberiVozilo.Text = pv.RegOznakaVozila;
			btnIzaberiSefa.Text = pv.SefId.ToString();
			btnIzaberiPomocnika.Text = pv.PomocnikId.ToString();

		}

		private void btnIzaberiVozilo_Click(object sender, EventArgs e) {

			new ListaVozilaForm(pv).ShowDialog();

			btnIzaberiVozilo.Text = pv.RegOznakaVozila;

		}

		private void btnIzaberiSefa_Click(object sender, EventArgs e) {

			new ListaPatrolnihPolicajacaForm(pv, true).ShowDialog();

			btnIzaberiSefa.Text = pv.SefId.ToString();
		}

		private void btnIzaberiPomocnika_Click(object sender, EventArgs e) {

			new ListaPatrolnihPolicajacaForm(pv, false).ShowDialog();

			btnIzaberiPomocnika.Text = pv.PomocnikId.ToString();
		}

		private void btnIzmeni_Click(object sender, EventArgs e) {

			if (pv.SefId == pv.PomocnikId)
				MessageBox.Show("Ne moze isti policajac da bude i sef i pomocnik");
			else
				if(DTOManager.izmeniPatrolu(pv))
					MessageBox.Show("Upesno azurirana patrola sa ID: " + pv.RedniBroj);
		}
	}
}
