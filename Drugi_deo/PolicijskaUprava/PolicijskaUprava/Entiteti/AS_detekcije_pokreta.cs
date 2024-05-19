using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class AS_detekcije_pokreta : Alarmni_sistem
    {
        public virtual string Osetljivost { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Osetljivost: " + Osetljivost;
        }
    }
}
