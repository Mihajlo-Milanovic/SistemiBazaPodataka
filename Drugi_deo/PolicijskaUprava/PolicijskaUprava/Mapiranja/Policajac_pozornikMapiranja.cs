using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class Policajac_pozornikMapiranja : SubclassMap<Policajac_pozornik>
    {
        public Policajac_pozornikMapiranja()
        {

            Table("POLICAJAC_POZORNIK");
            KeyColumn("POLICAJAC_ID");

            Map(x => x.Naziv_ulice).Column("NAZIV_ULICE");
            // References(x => x.Policajac);
        }
    }
}
