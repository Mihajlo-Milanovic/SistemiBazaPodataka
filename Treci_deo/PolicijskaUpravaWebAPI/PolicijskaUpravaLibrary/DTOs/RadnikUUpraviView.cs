namespace PolicijskaUpravaLibrary.DTOs {
	public class RadnikUUpraviView : PolicajacView{


		#region Properties

		public virtual string Pozicija { get; set; }

		#endregion

		#region Constructors

		public RadnikUUpraviView() : base() {

			//Tip = TipPolicajca.RadikUUpravi;
			Pozicija = string.Empty;
		}

		public RadnikUUpraviView(RadnikUUpravi r) : base(r) {

			//Tip = TipPolicajca.RadikUUpravi;
			Pozicija = r.Pozicija;
		}

		#endregion

		//public override string VratiTip() {
		//	return "RADNIK U UPRAVI";
		//}

		public RadnikUUpravi ToRadnikUUpravi() {

			return new RadnikUUpravi() {
				Id = this.Id,
				Ime = this.Ime,
				Prezime = this.Prezime,
				JMBG = this.JMBG,
				Adresa = this.Adresa,
				DatumPrijemaUSluzbu = this.DatumPrijemaUSluzbu,
				DatumRodjenja = this.DatumRodjenja,
				ImeRoditelja = this.ImeRoditelja,
				Tip = this.Tip,

				//Stanica = this.RadiUStanici?.ToPolicijskaStanica(),
				//SefujeStanicom = this.SefujeStanicom?.ToPolicijskaStanica(),
				//ZamenikStanice = this.ZamenikStanice?.ToPolicijskaStanica(),

				Pozicija = this.Pozicija,
			};

		}
	}
}
