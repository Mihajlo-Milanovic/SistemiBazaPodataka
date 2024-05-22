namespace PolicijskaUprava.Entiteti {
    public class PolicajacPozornik : Policajac {

        public virtual string NazivUlice { get; set; }


        public PolicajacPozornik() : base()
        {
            NazivUlice = string.Empty;
        }

        public PolicajacPozornik(int id, string ime, string imeRoditelja, string prezime, DateTime datumRodjenja,
            string jmbg, string adresa, DateTime datumPrijemaUSluzbu, PolicijskaStanica stanica,
            PolicijskaStanica sefuje, PolicijskaStanica zamenik, string tip, string nazivUlice)
            : base(id, ime, imeRoditelja, prezime, datumRodjenja,
             jmbg, adresa, datumPrijemaUSluzbu, stanica, sefuje, zamenik, tip)
        {
            NazivUlice = nazivUlice;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNaziv ulice: " + NazivUlice;
        }

    }
}
