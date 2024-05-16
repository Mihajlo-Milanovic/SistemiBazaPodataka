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

        public Skolski_policajac(string naziv_skole,string tip_skole,string adresa_skole,string kontakt_ime,string kontakt_prezime,string telefon_skole) : base()
        {
            Naziv_skole=naziv_skole;
            Tip_skole=tip_skole;
            Adresa_skole=adresa_skole;
            Kontakt_ime = kontakt_ime;
            Kontakt_prezime =kontakt_prezime;
            Telefon_skole =telefon_skole;
        }
    }
}
