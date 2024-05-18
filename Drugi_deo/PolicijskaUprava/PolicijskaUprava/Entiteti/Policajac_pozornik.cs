namespace PolicijskaUprava.Entiteti
{
    public class Policajac_pozornik : Policajac
    {
        public virtual string Naziv_ulice { get; set; }

        public Policajac_pozornik() : base()
        {
            Naziv_ulice = string.Empty;
        }
        public Policajac_pozornik(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, Policijska_stanica stanica,
            Policijska_stanica sefuje, Policijska_stanica zamenik, string tip, string naziv_ulice)
            : base(id, ime, ime_roditelja, prezime, datum_rodjenja,
             jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje, zamenik, tip)
        {
            Naziv_ulice = naziv_ulice;
        }
        public override string ToString()
        {
            return base.ToString() + "\nNaziv ulice: " + Naziv_ulice;
        }
    }
}
