
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class Patrolni_policajacMapiranja : SubclassMap<Patrolni_policajac>
    {
        public Patrolni_policajacMapiranja()
        {
            Table("PATROLNI_POLICAJAC");
            KeyColumn("POLICAJAC_ID");

            Map(x => x.Vrsta_oruzja, "VRSTA_ORUZJA");
            //References(x => x.Policajac);
            HasMany(x => x.Sefovi).KeyColumn("SEF_ID").Cascade.All().Inverse();
            HasMany(x => x.Pomocnici).KeyColumn("POMOCNIK_ID").Cascade.All().Inverse();
        }
    }
}
