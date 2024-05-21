namespace PolicijskaUprava.Entiteti {
    public class PolicajacPozornik : Policajac {

        public virtual string NazivUlice { get; set; }


        public PolicajacPozornik() : base()
        {
            NazivUlice = string.Empty;
        }

        public PolicajacPozornik(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanica stanica,
            PolicijskaStanica sefuje, PolicijskaStanica zamenik, string tip, string naziv_ulice)
            : base(id, ime, ime_roditelja, prezime, datum_rodjenja,
             jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje, zamenik, tip)
        {
            NazivUlice = naziv_ulice;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNaziv ulice: " + NazivUlice;
        }

    }
}
