using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class Patrola
    {
        public virtual int Redni_broj { get; set; }

        public virtual Vozilo RegOznakaVozila { get; set; }
        public virtual Patrolni_policajac Sef { get; set; }
        public virtual Patrolni_policajac Pomocnik { get; set; }

        public override string ToString()
        {
            return "Redni broj: " + Redni_broj.ToString() + "\nVozilo:" + RegOznakaVozila.Proizvodjac;
        }
    }
}
