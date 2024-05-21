namespace PolicijskaUprava.Entiteti {

    public class PolicijskaStanica {
    
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime Datum_osnivanja { get; set; }
        public virtual int BrojVozila { get; set; }

        public virtual IList<Objekat> Objekti { get; set; }
		public virtual IList<Policajac> Zaposleni { get; set; }

		public PolicijskaStanica() {
            Naziv = string.Empty;
            Opstina = string.Empty;
            Adresa = string.Empty;
            BrojVozila = 0;
            Datum_osnivanja = DateTime.Now;
            Objekti = new List<Objekat>();
            Zaposleni = new List<Policajac>();
        }

        public PolicijskaStanica(int id, string naziv, string opstina, string adresa,
                                    DateTime datum_osnivanja, int broj_vozila, IList<Objekat> objekti, IList<Policajac> zaposleni) {
            
            Id = id;
            Naziv = naziv;
            Opstina = opstina;
            Adresa = adresa;
            Datum_osnivanja = datum_osnivanja;
            BrojVozila = broj_vozila;
            Objekti = objekti != null ? objekti : new List<Objekat>();
            Zaposleni = zaposleni != null ? zaposleni : new List<Policajac>();
        }

        public override string ToString() {
            string output = "Naziv: " + Naziv
                    + "\nOpstina:" + Opstina
                    + "\nAdresa:" + Adresa
                    + "\nDatum osnivanja: " + Datum_osnivanja
                    + "\nBroj vozila: " + BrojVozila
                    + "\n\nCuvani objekti: ";

            
            foreach (var objekat in Objekti) {
                output += "\n\t" + objekat.Id;
            }
            output += "\n\nZaposleni: ";
			foreach (var z in Zaposleni) {
				output += "\n\t" + z.Id;
			}
            
			return output;
        }

    }
}
