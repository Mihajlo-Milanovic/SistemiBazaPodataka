namespace PolicijskaUprava.Mapiranja {

    class Tehnicko_liceMapiranja : ClassMap<Tehnicko_lice> {
    
        public Tehnicko_liceMapiranja() {
            Table("TEHNICKO_LICE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        }
    }
}
