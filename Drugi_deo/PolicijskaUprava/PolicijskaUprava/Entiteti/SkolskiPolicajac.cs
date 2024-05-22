namespace PolicijskaUprava.Entiteti
{
     public class SkolskiPolicajac : Policajac
    {
        public virtual string NazivSkole { get; set; }
        public virtual string TipSkole { get; set; }
        public virtual string AdresaSkole { get; set; }
        public virtual string KontaktIme {  get; set; }
        public virtual string KontaktPrezime {  get; set; }
        public virtual string TelefonSkole { get; set; }

        public SkolskiPolicajac() :base()
        {
            NazivSkole = string.Empty;
            TipSkole = string.Empty;
            AdresaSkole = string.Empty;
            KontaktIme = string.Empty;
            KontaktPrezime = string.Empty;
            TelefonSkole = string.Empty;
        }

        //public SkolskiPolicajac(int id, string ime, string imeRoditelja, string prezime, DateTime datumRodjenja,
        //    string jmbg, string adresa, DateTime datumPrijemaUSluzbu, PolicijskaStanica stanica, PolicijskaStanica
        //    sefuje, PolicijskaStanica zamenik, string tip,string nazivSkole,string tipSkole,string adresaSkole,
        //    string kontaktIme,string kontaktPrezime,string telefonSkole) 
        //    : base(id, ime, imeRoditelja, prezime, datumRodjenja,
        //     jmbg, adresa, datumPrijemaUSluzbu, stanica, sefuje, zamenik, tip)
        //{
        //    NazivSkole=nazivSkole;
        //    TipSkole=tipSkole;
        //    AdresaSkole=adresaSkole;
        //    KontaktIme = kontaktIme;
        //    KontaktPrezime =kontaktPrezime;
        //    TelefonSkole =telefonSkole;
        //}

        public override string ToString()
        {
            return base.ToString() + "\nNaziv skole: " + NazivSkole
                                   + "\nTip skole: " + TipSkole 
                                   +"\nAdresa skole: " + AdresaSkole
                                   + "\nKontakt ime: " + KontaktIme
                                   + "\nKontakt prezime: " + KontaktPrezime
                                   + "\nTelefon: " + TelefonSkole;
        }
    }
}
