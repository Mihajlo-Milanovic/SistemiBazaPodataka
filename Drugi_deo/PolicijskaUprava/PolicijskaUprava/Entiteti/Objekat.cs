namespace PolicijskaUprava.Entiteti
{
    public class Objekat
    {
        public virtual int Id{ get; set; }
        public virtual string Tip{ get; set; }
        public virtual string Adresa{ get; set; }
        public virtual int Povrsina { get; set; }
        public virtual string KontaktIme { get; set; }
        public virtual string KontaktPrezime { get; set; }

        public virtual PolicijskaStanica PolicijskaStanica { get; set; }

        public virtual IList<PolicijskaIntervencija> Intervencije { get; set; }

        public virtual IList<AlarmniSistem> AlarmniSistemi { get; set; }

        public Objekat() { 
            AlarmniSistemi=new List<AlarmniSistem>();
            Intervencije = new List<PolicijskaIntervencija>();
        }
        public Objekat(int id)
        {
            Id = id;
        }
        public Objekat(int id, string tip, string adresa, int povrsina, string kontaktIme, string kontaktPrezime,
            PolicijskaStanica policijskaStanica, List<PolicijskaIntervencija> intervencije, List<AlarmniSistem> alarmniSistemi)
        {
            Id = id;
            Tip = tip;
            Adresa = adresa;
            Povrsina = povrsina;
            KontaktIme = kontaktIme;
            KontaktPrezime = kontaktPrezime;
            PolicijskaStanica = policijskaStanica;
            Intervencije = intervencije;
            AlarmniSistemi = alarmniSistemi;
        }

        public override string ToString()
        {
            return "Tip: " + Tip + "\n" +
                   "Adresa: " + Adresa + "\n" +
                   "Povrsina: " + Povrsina + "\n" +
                   "Kontakt ime: " + KontaktIme + "\n" +
                   "Kontakt prezime: " + KontaktPrezime + "\n" +
                   "\n\nStanica ID: \n" + PolicijskaStanica.Id;
        }
    }
}
