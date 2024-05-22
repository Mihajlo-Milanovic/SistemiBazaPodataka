namespace PolicijskaUprava.Forme.OdrzavaForm {

	public partial class OdrzavaForm : Form {

		int tehId;

		public OdrzavaForm(int tehId) {
			InitializeComponent();

			this.tehId = tehId;
			bsIstorijaOdrzavanja.DataSource = DTOManager.vratiIstorijuOdrzavanja(tehId);
		}
	}
}
