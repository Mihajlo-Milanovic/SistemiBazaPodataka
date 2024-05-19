using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class AS_detekcije_toplotnog_odraza : Alarmni_sistem
    {
        public virtual int Hor_rez_ic_kamere { get; set; }
        public virtual int Ver_rez_ic_kamere { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nHorizontalna rezolucija: " + Hor_rez_ic_kamere.ToString() + "\nVertikalna rezolucija: " + Ver_rez_ic_kamere.ToString();
        }
    }
}
