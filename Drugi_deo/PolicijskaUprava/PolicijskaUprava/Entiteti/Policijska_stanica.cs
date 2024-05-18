/*CREATE TABLE POLICIJSKA_STANICA(
    ID NUMBER PRIMARY KEY,
    NAZIV VARCHAR2(30),
    OPSTINA VARCHAR2(30),
    ADRESA VARCHAR2(30),
    DATUM_OSNIVANJA DATE,
    BROJ_VOZILA NUMBER
);
*/

namespace PolicijskaUprava.Entiteti {
    public class Policijska_stanica {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime Datum_osnivanja { get; set; }
        public virtual int BrojVozila { get; set; }

        public virtual IList<Objekat> Objekti { get; set; }
		public virtual IList<Policajac> Zaposleni { get; set; }

		public Policijska_stanica() {
            Naziv = string.Empty;
            Opstina = string.Empty;
            Adresa = string.Empty;
            Datum_osnivanja = DateTime.Now;
            Objekti = new List<Objekat>();
            Zaposleni = new List<Policajac>();
        }

        public Policijska_stanica(int id, string naziv, string opstina, string adresa,
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
            string output = "Naziv: " + Naziv +
                    "\nOpstina:" + Opstina +
                    "\nAdresa:" + Adresa +
                    "\nDatum osnivanja: " + Datum_osnivanja +
                    "\nBroj vozila: " + BrojVozila;

            /**
             * ULAZI U BESKONACNU PETLJU
             */
                    //"\n\nCuvani objekti: ";

            /*
            foreach (var objekat in Objekti) {
                output += "\n\t" + objekat.ToString();
            }
            output += "\n\nZaposleni: ";
			foreach (var z in Zaposleni) {
				output += "\n\t" + z.ToString();
			}
            */
			return output;
        }

    }
}
