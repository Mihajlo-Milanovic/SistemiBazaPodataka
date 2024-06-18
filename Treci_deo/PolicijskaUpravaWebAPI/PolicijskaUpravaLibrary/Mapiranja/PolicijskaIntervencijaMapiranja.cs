using PolicijskaUpravaLibrary.Entiteti.VezeViseNaVise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUpravaLibrary.Mapiranja
{
    public class PolicijskaIntervencijaMapiranja :ClassMap<PolicijskaIntervencija>
    {
        public PolicijskaIntervencijaMapiranja()
        {
            Table("POLICIJSKA_INTERVENCIJA");
            CompositeId(x => x.Id)
            .KeyReference(x => x.Patrola, "PATROLA_ID")
            .KeyReference(x => x.Objekat, "OBJEKAT_ID")
            .KeyProperty(x => x.DatumIVreme, "DATUM_I_VREME");
            Map(x => x.Opis).Column("OPIS");
        
        }
    }
}
