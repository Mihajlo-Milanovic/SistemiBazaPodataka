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
            .KeyReference(x => x.Broj, "PATROLA_ID")
            .KeyReference(x => x.ObjekatId, "OBJEKAT_ID");
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.DatumIVreme).Column("DATUM_I_VREME");
        }
    }
}
