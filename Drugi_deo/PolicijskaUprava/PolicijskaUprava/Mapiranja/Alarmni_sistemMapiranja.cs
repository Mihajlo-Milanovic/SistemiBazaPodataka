using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    class Alarmni_sistemMapiranja : ClassMap<Alarmni_sistem>
    {
        public Alarmni_sistemMapiranja()
        {
            Table("ALARMNI_SISTEM");

            //mapiranje potklasa !!
            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
           
            Map(x => x.Serijski_broj, "SERIJSKI_BROJ");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Model, "MODEL");
            Map(x => x.Godina_proizvodnje, "GODINA_PROIZVODNJE");


            Map(x => x.Datum_instalacije, "DATUM_INSTALACIJE");
            Map(x => x.Datum_poslednjeg_atesta, "DATUM_POSLEDNJEG_ATESTA");
            Map(x => x.Datum_poslednjeg_servisiranja, "DATUM_POSLEDNJEG_SERVISIRANJA");
            Map(x => x.Opis_otklonjenog_kvara, "OPIS_OTKLONJENOG_KVARA");

            References(x => x.PripadaObjektu).Column("OBJEKAT_ID").LazyLoad();

            HasMany(x => x.Odrzavan)
            .KeyColumn("ALARMNI_SISTEM_ID")
            .Cascade.All()
            .Inverse();


        }
    }
}
