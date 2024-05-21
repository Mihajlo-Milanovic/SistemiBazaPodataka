namespace PolicijskaUprava.DTOs {
	public class SkolskiPolicajacView : PolicajacView{


		#region Properties

		public virtual string NazivSkole { get; set; }
		public virtual string TipSkole { get; set; }
		public virtual string AdresaSkole { get; set; }
		public virtual string KontaktIme { get; set; }
		public virtual string KontaktPrezime { get; set; }
		public virtual string TelefonSkole { get; set; }

		#endregion

		#region Constructors

		public SkolskiPolicajacView() : base() {
			NazivSkole = string.Empty;
			TipSkole = string.Empty;
			AdresaSkole = string.Empty;
			KontaktIme = string.Empty;
			KontaktPrezime = string.Empty;
			TelefonSkole = string.Empty;
		}

		public SkolskiPolicajacView(SkolskiPolicajac p) : base(p) {

			NazivSkole = p.NazivSkole;
			TipSkole = p.TipSkole;
			AdresaSkole = p.AdresaSkole;
			KontaktIme = p.KontaktIme;
			KontaktPrezime = p.KontaktPrezime;
			TelefonSkole = p.TelefonSkole;
		}	

		#endregion


	}
}
