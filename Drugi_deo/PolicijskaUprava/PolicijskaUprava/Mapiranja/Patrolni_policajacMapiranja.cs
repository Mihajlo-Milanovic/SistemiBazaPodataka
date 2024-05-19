
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

            Map(x => x.Vrsta_oruzja).Column("VRSTA_ORUZJA");

            HasMany(x => x.SefPatrole).KeyColumn("SEF_ID").LazyLoad().Inverse().Cascade.All();
            HasMany(x => x.PomocnikPatrole).KeyColumn("POMOCNIK_ID").LazyLoad().Inverse().Cascade.All();
        }
    }
}
