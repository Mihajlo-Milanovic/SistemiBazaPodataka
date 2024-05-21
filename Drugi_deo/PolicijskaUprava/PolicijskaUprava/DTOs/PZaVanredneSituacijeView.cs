namespace PolicijskaUprava.DTOs {
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
			Kurs = string.Empty;
			Vestina = string.Empty;
			Sertifikat = string.Empty;
		}
		//public PZaVanredneSituacijeView(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
		//	string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanicaView stanica, PolicijskaStanicaView sefuje,
		//	PolicijskaStanicaView zamenik, string tip, string kurs, string vestina, DateTime datum_zavrsetka_kursa, string sertifikat,
		//	DateTime datum_sticanja_sertifikata)

		//	: base(id, ime, ime_roditelja, prezime, datum_rodjenja,
		//	 jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje, zamenik, tip) {
		//	Kurs = kurs;
		//	Vestina = vestina;
		//	DatumZavrsetkaKursa = datum_zavrsetka_kursa;
		//	Sertifikat = sertifikat;
		//	DatumSticanjaSertifikata = datum_sticanja_sertifikata;
		//}

		public PZaVanredneSituacijeView(PZaVanredneSituacije p) : base(p) {

			Kurs = p.Kurs;
			Vestina = p.Vestina;
			DatumZavrsetkaKursa = p.Datum_zavrsetka_kursa;
			Sertifikat = p.Sertifikat;
			DatumSticanjaSertifikata = p.Datum_sticanja_sertifikata;
		}

		#endregion


	}
}
