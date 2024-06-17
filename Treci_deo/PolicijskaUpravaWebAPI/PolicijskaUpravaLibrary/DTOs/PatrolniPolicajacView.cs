namespace PolicijskaUpravaLibrary.DTOs {
	public class PatrolniPolicajacView : PolicajacView {

		#region Properties

		public virtual string VrstaOruzja { get; set; }

		#endregion

		#region Constructors

		public PatrolniPolicajacView() : base() {
			VrstaOruzja = string.Empty;
		}

		//public PatrolniPolicajacView(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
		//	string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanicaView stanica,
		//	PolicijskaStanicaView sefuje, PolicijskaStanicaView zamenik, string tip, string vrsta_oruzja, IList<Patrola> sefovi, IList<Patrola> pomocnici)
		//	: base(id, ime, ime_roditelja, prezime, datum_rodjenja,
		//	 jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje,
		//	 zamenik, tip) {
		//	VrstaOruzja = VrstaOruzja;
		//	//SefPatrole = sefovi;
		//	//PomocnikPatrole = pomocnici;
		//}

		public PatrolniPolicajacView(PatrolniPolicajac p) : base(p) {

			VrstaOruzja = p.VrstaOruzja;
		}


		#endregion

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
				Tip = this.Tip,

				Stanica = this.RadiUStanici != null ? this.RadiUStanici.ToPolicijskaStanica() : null,
				SefujeStanicom = this.SefujeStanicom != null ? this.SefujeStanicom.ToPolicijskaStanica() : null,
				ZamenikStanice = this.ZamenikStanice != null ? this.ZamenikStanice.ToPolicijskaStanica() : null,

				VrstaOruzja = this.VrstaOruzja,
			};
		
		}
	}
}
