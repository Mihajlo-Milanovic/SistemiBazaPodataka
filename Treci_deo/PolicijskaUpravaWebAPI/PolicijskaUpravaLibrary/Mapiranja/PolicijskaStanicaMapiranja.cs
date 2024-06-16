namespace PolicijskaUpravaLibrary.Mapiranja
{
    class PolicijskaStanicaMapiranja : ClassMap<PolicijskaStanica>
    {
        public PolicijskaStanicaMapiranja()
        {
            Table("POLICIJSKA_STANICA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Opstina, "OPSTINA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.DatumOsnivanja, "DATUM_OSNIVANJA");
            Map(x => x.BrojVozila, "BROJ_VOZILA");

            HasMany(x => x.Objekti).KeyColumn("P_STANICA_ID").LazyLoad().Cascade.All();
            HasMany(x => x.Zaposleni).KeyColumn("STANICA_ID").LazyLoad().Cascade.All();
        }
    }
}





