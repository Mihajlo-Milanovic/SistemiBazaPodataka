namespace PolicijskaUprava.Entiteti

{
    public class PatrolniPolicajac : Policajac
    {
        public virtual string VrstaOruzja { get; set; }

        public virtual IList<Patrola> SefPatrole { get; set; }
        public virtual IList<Patrola> PomocnikPatrole { get; set; }


        public PatrolniPolicajac() : base()
        {
            VrstaOruzja = string.Empty;
            SefPatrole = new List<Patrola>();
            PomocnikPatrole = new List<Patrola>();
        }
        public PatrolniPolicajac(int id, string ime, string imeRoditelja, string prezime, DateTime datumRodjenja,
            string jmbg, string adresa, DateTime datumPrijemaUSluzbu, PolicijskaStanica stanica,
            PolicijskaStanica sefuje, PolicijskaStanica zamenik, string tip,string vrstaOruzja, IList<Patrola> sefovi,IList<Patrola> pomocnici)
            : base(id, ime, imeRoditelja, prezime, datumRodjenja,
             jmbg, adresa, datumPrijemaUSluzbu, stanica, sefuje,
             zamenik, tip)
        {
            VrstaOruzja = vrstaOruzja;
            SefPatrole = sefovi;
            PomocnikPatrole = pomocnici;
        }
        public override string ToString()
        {
            return base.ToString() + "\nVrsta oruzja: " + VrstaOruzja;
        }
    }
}
