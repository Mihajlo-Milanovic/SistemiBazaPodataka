namespace PolicijskaUprava.Mapiranja {

    class TehnickoLiceMapiranja : ClassMap<TehnickoLice> {
    
        public TehnickoLiceMapiranja() {
            Table("TEHNICKO_LICE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");

            HasMany(x => x.Odrzava)
            .KeyColumn("TEHNICAR_ID")
            .Cascade.All()
            .Inverse();
        }
    }
}
