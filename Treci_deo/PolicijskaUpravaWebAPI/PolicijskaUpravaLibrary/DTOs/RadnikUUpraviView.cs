namespace PolicijskaUpravaLibrary.DTOs {
	public class RadnikUUpraviView : PolicajacView{


		#region Properties

		public virtual string Pozicija { get; set; }

		#endregion

		#region Constructors

		public RadnikUUpraviView() : base() {
			Pozicija = string.Empty;
		}

		//public RadnikUUpraviView(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
		//	string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanicaView stanica,
		//	PolicijskaStanicaView sefuje, PolicijskaStanicaView zamenik, string tip, string pozicija)
		//	: base(id, ime, ime_roditelja, prezime, datum_rodjenja,
		//	 jmbg, adresa, datum_prijema_u_sluzbu, stanica,
		//	 sefuje, zamenik, tip) {
		//	Pozicija = pozicija;
		//}

		public RadnikUUpraviView(RadnikUUpravi r) : base(r) {

			Pozicija = r.Pozicija;
		}

		#endregion


	}
}
