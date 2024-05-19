using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class AS_detekcije_toplotnog_odrazaMapiranja : SubclassMap<AS_detekcije_toplotnog_odraza>
    {
        public AS_detekcije_toplotnog_odrazaMapiranja()
        {
            DiscriminatorValue("DETEKCIJA TOPLOTNOG ODRAZA");

            Map(x => x.Hor_rez_ic_kamere, "HOR_REZ_IC_KAMERE");
            Map(x => x.Ver_rez_ic_kamere, "VER_REZ_IC_KAMERE");

        }
    }
}
