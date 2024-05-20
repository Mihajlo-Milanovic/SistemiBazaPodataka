using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class Policajac_pozornikMapiranja : SubclassMap<PolicajacPozornik>
    {
        public Policajac_pozornikMapiranja()
        {

            Table("POLICAJAC_POZORNIK");
            KeyColumn("POLICAJAC_ID");

            Map(x => x.NazivUlice).Column("NAZIV_ULICE");
            // References(x => x.Policajac);
        }
    }
}
