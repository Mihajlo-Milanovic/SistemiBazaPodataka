using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Forme.TehnickoLiceForme {
	public partial class DodajTehnickoLiceForm : Form {
		public DodajTehnickoLiceForm() {
			InitializeComponent();
		}


		private void btnDodajTehnickoLice_Click(object sender, EventArgs e) {

			bool uspesanUpis = DTOManager.dodajTehnickoLice(tbxIme.Text, tbxPrezime.Text);
			if (uspesanUpis) {
				MessageBox.Show("Upisano tehnicko lice: " + tbxIme.Text + " " + tbxPrezime.Text);
			}
		}
		

	}
}
