﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUpravaLibrary.Mapiranja
{
    public class OdrzavaMapiranja : ClassMap<Odrzava>
    {
        public OdrzavaMapiranja()
        {
            Table("ODRZAVA");
            CompositeId(x => x.Id)
            .KeyReference(x => x.Tehnicar, "TEHNICAR_ID")
            .KeyReference(x => x.AlarmniSistem, "ALARMNI_SISTEM_ID")
            .KeyProperty(x => x.PocetniDatum, "POCETNI_DATUM");

            Map(x => x.KrajnjiDatum).Column("KRAJNJI_DATUM");
        }
    }
}
