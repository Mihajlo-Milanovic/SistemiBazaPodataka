namespace PolicijskaUpravaLibrary.DTOs {
	public class PolicajacPozornikView : PolicajacView{


		#region Properties

		public virtual string NazivUlice { get; set; }
		
		#endregion

		#region Constructors

		public PolicajacPozornikView() : base() {

			Tip = TipPolicajca.Pozornik;
			NazivUlice = string.Empty;
		}

		public PolicajacPozornikView(PolicajacPozornik p) : base(p) {

			Tip = TipPolicajca.Pozornik;
			NazivUlice = p.NazivUlice;
		}

		#endregion

		public override string VratiTip() {
			return "PATROLNI POLICAJAC";
		}

		public PolicajacPozornik ToPolicajacPozornik() {

			return new PolicajacPozornik() {
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

				NazivUlice = this.NazivUlice,
			};

		}

	}
}
