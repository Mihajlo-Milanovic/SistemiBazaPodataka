using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class ObrazovanjeMapiranja : ClassMap<Obrazovanje>
    {
        public ObrazovanjeMapiranja()
        {
            Table("OBRAZOVANJE");
            CompositeId(x => x.Id)
            .KeyProperty(x => x.Skola, "SKOLA")
            .KeyProperty(x => x.DatumDiplomiranja, "DATUM_DIPLOMIRANJA")
            .KeyReference(x => x.PolicajacObrazovanje, "POLICAJAC_ID");
        }
    }
}
