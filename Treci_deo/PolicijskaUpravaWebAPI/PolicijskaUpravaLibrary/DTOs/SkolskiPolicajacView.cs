namespace PolicijskaUpravaLibrary.DTOs {
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

			Tip = TipPolicajca.Skolski;
			NazivSkole = string.Empty;
			TipSkole = string.Empty;
			AdresaSkole = string.Empty;
			KontaktIme = string.Empty;
			KontaktPrezime = string.Empty;
			TelefonSkole = string.Empty;
		}

		public SkolskiPolicajacView(SkolskiPolicajac p) : base(p) {

			Tip = TipPolicajca.Skolski;
			NazivSkole = p.NazivSkole;
			TipSkole = p.TipSkole;
			AdresaSkole = p.AdresaSkole;
			KontaktIme = p.KontaktIme;
			KontaktPrezime = p.KontaktPrezime;
			TelefonSkole = p.TelefonSkole;
		}

		#endregion

		public override string VratiTip() {
			return "SKOLSKI POLICAJAC";
		}

		public SkolskiPolicajac ToSkolskiPolicajac() {

			return new SkolskiPolicajac() {
				Id = this.Id,
				Ime = this.Ime,
				Prezime = this.Prezime,
				JMBG = this.JMBG,
				Adresa = this.Adresa,
				DatumPrijemaUSluzbu = this.DatumPrijemaUSluzbu,
				DatumRodjenja = this.DatumRodjenja,
				ImeRoditelja = this.ImeRoditelja,
				Tip = this.VratiTip(),

				Stanica = this.RadiUStanici?.ToPolicijskaStanica(),
				SefujeStanicom = this.SefujeStanicom?.ToPolicijskaStanica(),
				ZamenikStanice = this.ZamenikStanice?.ToPolicijskaStanica(),

				AdresaSkole = this.AdresaSkole,
				KontaktIme = this.KontaktIme,
				KontaktPrezime = this.KontaktPrezime,
				NazivSkole = this.NazivSkole,
				TelefonSkole = this.TelefonSkole,
				TipSkole = this.TipSkole,
			};

		}
	}
}
