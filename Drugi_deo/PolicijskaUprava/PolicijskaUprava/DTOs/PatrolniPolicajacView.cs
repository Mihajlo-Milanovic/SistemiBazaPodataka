namespace PolicijskaUprava.DTOs {
	public class PatrolniPolicajacView : PolicajacView {

		#region Properties

		public virtual string Vrsta_oruzja { get; set; }

		#endregion

		#region Constructors

		public PatrolniPolicajacView() : base() {
			Vrsta_oruzja = string.Empty;
		}

		//public PatrolniPolicajacView(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
		//	string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanicaView stanica,
		//	PolicijskaStanicaView sefuje, PolicijskaStanicaView zamenik, string tip, string vrsta_oruzja, IList<Patrola> sefovi, IList<Patrola> pomocnici)
		//	: base(id, ime, ime_roditelja, prezime, datum_rodjenja,
		//	 jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje,
		//	 zamenik, tip) {
		//	Vrsta_oruzja = Vrsta_oruzja;
		//	//SefPatrole = sefovi;
		//	//PomocnikPatrole = pomocnici;
		//}

		public PatrolniPolicajacView(PatrolniPolicajac p) : base(p) {

			Vrsta_oruzja = p.VrstaOruzja;
		}


		#endregion

	}
}
