namespace PolicijskaUprava.Mapiranja {

    class VoziloMapiranja : ClassMap<Vozilo> {
    
        public VoziloMapiranja() {
            Table("VOZILO");

            Id(x => x.Reg_oznaka, "REG_OZNAKA");

            Map(x => x.Boja, "BOJA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Model, "MODEL");

            HasMany(x => x.Patrole);

        }
    }
}
