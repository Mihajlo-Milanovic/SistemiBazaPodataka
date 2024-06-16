namespace PolicijskaUpravaLibrary.Mapiranja
{
    class AlarmniSistemMapiranja : ClassMap<AlarmniSistem>
    {
        public AlarmniSistemMapiranja()
        {
            Table("ALARMNI_SISTEM");

            //mapiranje potklasa !!
            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
           
            Map(x => x.SerijskiBroj, "SERIJSKI_BROJ");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Model, "MODEL");
            Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");


            Map(x => x.DatumInstalacije, "DATUM_INSTALACIJE");
            Map(x => x.DatumPoslednjegAtesta, "DATUM_POSLEDNJEG_ATESTA");
            Map(x => x.DatumPoslednjegServisiranja, "DATUM_POSLEDNJEG_SERVISIRANJA");
            Map(x => x.OpisOtklonjenogKvara, "OPIS_OTKLONJENOG_KVARA");

            References(x => x.PripadaObjektu).Column("OBJEKAT_ID").LazyLoad();

            HasMany(x => x.Odrzavan)
            .KeyColumn("ALARMNI_SISTEM_ID")
            .Cascade.All()
            .Inverse();


        }
    }
}
