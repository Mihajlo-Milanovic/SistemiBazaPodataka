using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Helpers;
using PolicijskaUprava.Entiteti;
using FluentNHibernate.Conventions.Inspections;

namespace PolicijskaUprava.Mapiranja {

    class Tehnicko_liceMapiranja : ClassMap<Tehnicko_lice> {
    
        public Tehnicko_liceMapiranja() {
            Table("TEHNICKO_LICE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        }
    }
}
