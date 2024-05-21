namespace PolicijskaUprava.DTOs {
	public class PolicijskaStanicaView {

		#region Properties

		public virtual int Id { get; set; }
		public virtual string Naziv { get; set; }
		public virtual string Opstina { get; set; }
		public virtual string Adresa { get; set; }
		public virtual DateTime DatumOsnivanja { get; set; }
		public virtual int BrojVozila { get; set; }

		#endregion

		#region Constructors

		public PolicijskaStanicaView() {
			Naziv = string.Empty;
			Opstina = string.Empty;
			Adresa = string.Empty;
			DatumOsnivanja = DateTime.Now;
		}

		//public PolicijskaStanicaView(int id, string naziv, string opstina, string adresa,DateTime datum_osnivanja, int broj_vozila
		//							/*, IList<Objekat> objekti, IList<Policajac> zaposleni*/) {

		//	Id = id;
		//	Naziv = naziv;
		//	Opstina = opstina;
		//	Adresa = adresa;
		//	DatumOsnivanja = datum_osnivanja;
		//	BrojVozila = broj_vozila;
		//}

		public PolicijskaStanicaView(PolicijskaStanica p) {

			Id = p.Id;
			Naziv = p.Naziv;
			Opstina = p.Opstina;
			Adresa = p.Adresa;
			DatumOsnivanja = p.Datum_osnivanja;
			BrojVozila = p.BrojVozila;
		}

		#endregion

	}
}
