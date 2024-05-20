using PolicijskaUprava.Veze_Vise_Na_Vise;

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

        public virtual IList<Alarmni_sistem> AlarmniSistemi { get; set; }

        public Objekat() { 
            AlarmniSistemi=new List<Alarmni_sistem>();
            Intervencije = new List<PolicijskaIntervencija>();
        
        }
        public override string ToString()
        {
            return "Tip: " + Tip + "\n" +
                   "Adresa: " + Adresa + "\n" +
                   "Povrsina: " + Povrsina + "\n" +
                   "Kontakt ime: " + KontaktIme + "\n" +
                   "Kontakt prezime: " + KontaktPrezime + "\n" +
                   "\n\nStanica: \n" + PolicijskaStanica.ToString();
        }
    }
}
