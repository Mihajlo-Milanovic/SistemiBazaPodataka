namespace PolicijskaUprava.Entiteti {

    public class PolicijskaStanica {
    
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime DatumOsnivanja { get; set; }
        public virtual int BrojVozila { get; set; }

        public virtual IList<Objekat> Objekti { get; set; }
		public virtual IList<Policajac> Zaposleni { get; set; }

		public PolicijskaStanica() {
            Naziv = string.Empty;
            Opstina = string.Empty;
            Adresa = string.Empty;
            BrojVozila = 0;
            DatumOsnivanja = DateTime.Now;
            Objekti = new List<Objekat>();
            Zaposleni = new List<Policajac>();
        }

        public PolicijskaStanica(int id, string naziv, string opstina, string adresa,
                                    DateTime datumOsnivanja, int brojVozila, IList<Objekat> objekti, IList<Policajac> zaposleni) {
            
            Id = id;
            Naziv = naziv;
            Opstina = opstina;
            Adresa = adresa;
            DatumOsnivanja = datumOsnivanja;
            BrojVozila = brojVozila;
            Objekti = objekti != null ? objekti : new List<Objekat>();
            Zaposleni = zaposleni != null ? zaposleni : new List<Policajac>();
        }

        public override string ToString() {
            string output = "Naziv: " + Naziv
                    + "\nOpstina:" + Opstina
                    + "\nAdresa:" + Adresa
                    + "\nDatum osnivanja: " + DatumOsnivanja
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
