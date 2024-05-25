
using PolicijskaUprava.Forme.PatroleForm;

namespace PolicijskaUprava.Forme.PatroleForme {
	public partial class DodajPatroluForm : Form {

		PatrolaView pv;

		public DodajPatroluForm() {
			InitializeComponent();

			pv = new();
			pv.RegOznakaVozila = null;
			pv.SefId = -1;
			pv.PomocnikId = -1;
		}

		private void btnIzaberiVozilo_Click(object sender, EventArgs e) {

			new ListaVozilaForm(pv).ShowDialog();

			if (pv.RegOznakaVozila != null)
				btnIzaberiVozilo.Text = pv.RegOznakaVozila;

		}

		private void btnIzaberiSefa_Click(object sender, EventArgs e) {

			new ListaPatrolnihPolicajacaForm(pv, true).ShowDialog();

			if (pv.SefId > 0)
				if (pv.PomocnikId == pv.SefId)
					MessageBox.Show("Pa gde ima da iti covek bude i sef i pomocnik");
				else
					btnIzaberiSefa.Text = pv.SefId.ToString();

		}

		private void btnIzaberiPomocnika_Click(object sender, EventArgs e) {

			new ListaPatrolnihPolicajacaForm(pv, false).ShowDialog();

			if (pv.PomocnikId > 0)
				if (pv.PomocnikId == pv.SefId)
					MessageBox.Show("Pa gde ima da iti covek bude i sef i pomocnik");
				else
					btnIzaberiPomocnika.Text = pv.PomocnikId.ToString();

		}

		private void btnDodaj_Click(object sender, EventArgs e) {

			if (DTOManager.dodajPatrolu(pv))
				MessageBox.Show("Dodata patrola: \n" + pv.ToString());

		}
	}
}