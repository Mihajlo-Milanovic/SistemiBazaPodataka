
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    public class PatrolniPolicajacMapiranja : SubclassMap<PatrolniPolicajac>
    {
        public PatrolniPolicajacMapiranja()
        {
            Table("PATROLNI_POLICAJAC");
            KeyColumn("POLICAJAC_ID");

            Map(x => x.VrstaOruzja).Column("VRSTA_ORUZJA");

            HasMany(x => x.SefPatrole).KeyColumn("SEF_ID").LazyLoad().Inverse().Cascade.All();
            HasMany(x => x.PomocnikPatrole).KeyColumn("POMOCNIK_ID").LazyLoad().Inverse().Cascade.All();
        }
    }
}
