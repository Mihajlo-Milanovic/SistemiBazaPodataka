using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class Ultrazvucni_AS : Alarmni_sistem
    {
        public virtual int Gornja_granica { get; set; }
        public virtual int Donja_granica { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Gornja granica: " + Gornja_granica + "\nDonja granica: " + Donja_granica;
        }
    }
}
