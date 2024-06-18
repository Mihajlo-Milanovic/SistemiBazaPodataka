namespace PolicijskaUpravaLibrary.DTOs {
	public class PatrolniPolicajacView : PolicajacView {

		#region Properties

		public virtual string VrstaOruzja { get; set; }

		#endregion

		#region Constructors

		public PatrolniPolicajacView() : base() {

			Tip = TipPolicajca.Patrolni;
			VrstaOruzja = string.Empty;
		}

		public PatrolniPolicajacView(PatrolniPolicajac p) : base(p) {

			Tip = TipPolicajca.Patrolni;
			VrstaOruzja = p.VrstaOruzja;
		}

		#endregion

		public override string VratiTip() {
			return "PATROLNI POLICAJAC";
		}

		public PatrolniPolicajac ToPatrolniPolicajac() {

			return new PatrolniPolicajac() {
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

				VrstaOruzja = this.VrstaOruzja,
			};
		
		}
	}
}
