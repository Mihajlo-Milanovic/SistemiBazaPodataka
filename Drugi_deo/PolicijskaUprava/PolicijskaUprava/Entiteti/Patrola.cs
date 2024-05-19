using PolicijskaUprava.Veze_Vise_Na_Vise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class Patrola
    {
        public virtual  int RedniBroj { get; set; }
        public virtual Vozilo RegOznakaVozila { get; set; }
        public virtual Patrolni_policajac SefId{ get; set; }
        public virtual Patrolni_policajac PomocnikId { get; set; }
        public virtual IList<PolicijskaIntervencija> Intervencije{ get; set; }

        public Patrola(int redniBroj, Vozilo regOznakaVozila, Patrolni_policajac sefId, Patrolni_policajac pomocnikId)
        {
            RedniBroj = redniBroj;
            RegOznakaVozila = regOznakaVozila;
            SefId = sefId;
            PomocnikId = pomocnikId;
        }
        public Patrola() { }
    }
}
