using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class PatrolaMapiranja : ClassMap<Patrola>
    {
        public PatrolaMapiranja()
        {
            Table("PATROLA");

            Id(x => x.Redni_broj, "REDNI_BROJ").GeneratedBy.TriggerIdentity();

            References(x => x.RegOznakaVozila).Column("REG_OZNAKA_VOZILA").LazyLoad();
            References(x => x.Sef).Column("SEF_ID").LazyLoad();
            References(x => x.Pomocnik).Column("POMOCNIK_ID").LazyLoad();
        }
    }
}
