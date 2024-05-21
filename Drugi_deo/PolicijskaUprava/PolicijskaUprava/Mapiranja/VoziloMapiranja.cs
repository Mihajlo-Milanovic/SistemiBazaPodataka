namespace PolicijskaUprava.Mapiranja {

    class VoziloMapiranja : ClassMap<Vozilo> {
    
        public VoziloMapiranja() {
            Table("VOZILO");

            Id(x => x.RegOznaka, "REG_OZNAKA");

            Map(x => x.Boja, "BOJA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Model, "MODEL");


            HasMany(x => x.Patrole).KeyColumn("REG_OZNAKA_VOZILA").LazyLoad().Inverse().Cascade.All();



        }
    }
}
