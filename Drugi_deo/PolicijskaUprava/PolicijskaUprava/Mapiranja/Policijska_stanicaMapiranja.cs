namespace PolicijskaUprava.Mapiranja
{
    class Policijska_stanicaMapiranja : ClassMap<Policijska_stanica>
    {
        public Policijska_stanicaMapiranja()
        {
            Table("POLICIJSKA_STANICA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();/// proveriti!!!!!!

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Opstina, "OPSTINA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Datum_osnivanja, "DATUM_OSNIVANJA");
            Map(x => x.Broj_vozila, "BROJ_VOZILA");
        }
    }
}
