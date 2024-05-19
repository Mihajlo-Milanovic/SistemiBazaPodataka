namespace PolicijskaUprava.Entiteti
{
     public class Skolski_policajac : Policajac
    {
        public virtual string Naziv_skole { get; set; }
        public virtual string Tip_skole { get; set; }
        public virtual string Adresa_skole { get; set; }
        public virtual string Kontakt_ime {  get; set; }
        public virtual string Kontakt_prezime {  get; set; }
        public virtual string Telefon_skole { get; set; }

        public Skolski_policajac() :base()
        {
            Naziv_skole = string.Empty;
            Tip_skole = string.Empty;
            Adresa_skole = string.Empty;
            Kontakt_ime = string.Empty;
            Kontakt_prezime = string.Empty;
            Telefon_skole = string.Empty;
        }

        public Skolski_policajac(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, Policijska_stanica stanica, Policijska_stanica
            sefuje, Policijska_stanica zamenik, string tip,string naziv_skole,string tip_skole,string adresa_skole,
            string kontakt_ime,string kontakt_prezime,string telefon_skole) 
            : base(id, ime, ime_roditelja, prezime, datum_rodjenja,
             jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje, zamenik, tip)
        {
            Naziv_skole=naziv_skole;
            Tip_skole=tip_skole;
            Adresa_skole=adresa_skole;
            Kontakt_ime = kontakt_ime;
            Kontakt_prezime =kontakt_prezime;
            Telefon_skole =telefon_skole;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNaziv skole: " + Naziv_skole
                                   + "\nTip skole: " + Tip_skole 
                                   +"\nAdresa skole: " + Adresa_skole
                                   + "\nKontakt ime: " + Kontakt_ime
                                   + "\nKontakt prezime: " + Kontakt_prezime
                                   + "\nTelefon: " + Telefon_skole;
        }
    }
}
