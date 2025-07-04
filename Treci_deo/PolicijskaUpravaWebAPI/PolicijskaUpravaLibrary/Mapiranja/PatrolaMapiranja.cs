﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUpravaLibrary.Mapiranja
{
    public class PatrolaMapiranja : ClassMap<Patrola>
    {
        public PatrolaMapiranja()
        {
            Table("PATROLA");

            Id(x => x.RedniBroj, "REDNI_BROJ").GeneratedBy.TriggerIdentity();

            References(x => x.Sef).Column("SEF_ID").LazyLoad();
            References(x => x.Pomocnik).Column("POMOCNIK_ID").LazyLoad();
            References(x => x.DuziVozilo).Column("REG_OZNAKA_VOZILA").LazyLoad();

            HasMany(x => x.Intervencije)
            .KeyColumn("PATROLA_ID")
            .Cascade.All().Inverse();
        }
    }
}
