namespace PolicijskaUprava.Forme.TehnickoLiceForme {
	public partial class IzmeniTehnickoLiceForm : Form {

		TehnickoLice tl;

		public IzmeniTehnickoLiceForm(TehnickoLice t) {
			InitializeComponent();
			tl = t;

			tbxIme.Text = tl.Ime;
			tbxPrezime.Text = tl.Prezime;

		}


		private void btnIzmeniTehnickoLice_Click(object sender, EventArgs e) {

			tl.Ime = tbxIme.Text;
			tl.Prezime = tbxPrezime.Text;


			DTOManager.izmeniTehnickoLice(tl);

			this.Close();
		}
	}
}
