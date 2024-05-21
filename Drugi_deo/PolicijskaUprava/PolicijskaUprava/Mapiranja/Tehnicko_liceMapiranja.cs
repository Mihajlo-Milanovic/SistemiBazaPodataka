namespace PolicijskaUprava.Mapiranja {

    class Tehnicko_liceMapiranja : ClassMap<TehnickoLice> {
    
        public Tehnicko_liceMapiranja() {
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
