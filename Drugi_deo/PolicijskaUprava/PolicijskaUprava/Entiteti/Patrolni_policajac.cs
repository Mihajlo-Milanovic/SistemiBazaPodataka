using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class Patrolni_policajac : Policajac
    {
        public virtual string Vrsta_oruzja { get; set; }

        public virtual Policajac Policajac { get; set; }

        public virtual IList<Patrola> Sefovi { get; set; } 
        public virtual IList<Patrola> Pomocnici { get; set; }
        public Patrolni_policajac()
        {
            Sefovi = new List<Patrola>();
            Pomocnici = new List<Patrola>();
        }

    }
}
