using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class Ultrazvucni_ASMapiranja : SubclassMap<Ultrazvucni_AS>
    {
        public Ultrazvucni_ASMapiranja()
        {
            DiscriminatorValue("ULTRAZVUCNI");

            Map(x => x.Gornja_granica, "GORNJA_GRANICA");
            Map(x => x.Donja_granica, "DONJA_GRANICA");

        }
    }
}
