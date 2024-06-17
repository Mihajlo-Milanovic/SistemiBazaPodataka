using PolicijskaUpravaLibrary.Entiteti.VezeViseNaVise;

namespace PolicijskaUpravaLibrary.Entiteti
{
    public class Patrola
    {
        public virtual  int RedniBroj { get; set; }
        public virtual Vozilo DuziVozilo { get; set; }
        public virtual PatrolniPolicajac Sef{ get; set; }
        public virtual PatrolniPolicajac Pomocnik { get; set; }
        public virtual IList<PolicijskaIntervencija> Intervencije{ get; set; }

        public Patrola() { }

        public Patrola(int redniBroj, Vozilo regOznakaVozila, PatrolniPolicajac sef, PatrolniPolicajac pomocnik)
        {
            RedniBroj = redniBroj;
            DuziVozilo = regOznakaVozila;
            Sef = sef;
            Pomocnik = pomocnik;
            Intervencije = new List<PolicijskaIntervencija>();
        }

        public override string ToString()
        {
            return "Redni broj: " + RedniBroj.ToString() + "\nVozilo:" + DuziVozilo.Proizvodjac;
        }
    }
}
