using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class AS_detekcije_pokretaMapiranja : SubclassMap<AS_detekcije_pokreta>
    {
        public AS_detekcije_pokretaMapiranja()
        {
            DiscriminatorValue("DETEKCIJA POKRETA");

            Map(x => x.Osetljivost, "OSETLJIVOST");

        }
    }
}
