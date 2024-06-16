using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUpravaLibrary.Mapiranja
{
    public class PolicajacPozornikMapiranja : SubclassMap<PolicajacPozornik>
    {
        public PolicajacPozornikMapiranja()
        {

            Table("POLICAJAC_POZORNIK");
            KeyColumn("POLICAJAC_ID");

            Map(x => x.NazivUlice).Column("NAZIV_ULICE");
            // References(x => x.Policajac);
        }
    }
}
