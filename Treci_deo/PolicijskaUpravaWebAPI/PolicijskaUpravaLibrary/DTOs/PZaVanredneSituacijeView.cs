namespace PolicijskaUpravaLibrary.DTOs {
	public class PZaVanredneSituacijeView : PolicajacView {


		#region Properties

		public virtual string Kurs { get; set; }
		public virtual string Vestina { get; set; }
		public virtual DateTime DatumZavrsetkaKursa { get; set; }
		public virtual string Sertifikat { get; set; }
		public virtual DateTime DatumSticanjaSertifikata { get; set; }

		#endregion

		#region Constructors

		public PZaVanredneSituacijeView() : base() {

			Tip = TipPolicajca.ZaVanredneSituacije;
			Kurs = string.Empty;
			Vestina = string.Empty;
			Sertifikat = string.Empty;
		}
		
		public PZaVanredneSituacijeView(PZaVanredneSituacije p) : base(p) {

			Tip = TipPolicajca.ZaVanredneSituacije;
			Kurs = p.Kurs;
			Vestina = p.Vestina;
			DatumZavrsetkaKursa = p.DatumZavrsetkaKursa;
			Sertifikat = p.Sertifikat;
			DatumSticanjaSertifikata = p.DatumSticanjaSertifikata;
		}

		#endregion

		public override string VratiTip() {
			return "POLICAJAC ZA VANREDNE SITUACIJE";
		}

		public PZaVanredneSituacije ToPZaVanredneSituacije() {

			return new PZaVanredneSituacije() {
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

				DatumSticanjaSertifikata = this.DatumSticanjaSertifikata,
				DatumZavrsetkaKursa = this.DatumZavrsetkaKursa,
				Kurs = this.Kurs,
				Sertifikat = this.Sertifikat,
				Vestina = this.Vestina,
			};

		}
	}
}
