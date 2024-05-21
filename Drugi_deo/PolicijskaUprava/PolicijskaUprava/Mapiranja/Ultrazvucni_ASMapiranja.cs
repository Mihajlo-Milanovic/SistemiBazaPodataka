using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class Ultrazvucni_ASMapiranja : SubclassMap<UltrazvucniAS>
    {
        public Ultrazvucni_ASMapiranja()
        {
            DiscriminatorValue("ULTRAZVUCNI");

            Map(x => x.GornjaGranica, "GORNJA_GRANICA");
            Map(x => x.DonjaGranica, "DONJA_GRANICA");

        }
    }
}
