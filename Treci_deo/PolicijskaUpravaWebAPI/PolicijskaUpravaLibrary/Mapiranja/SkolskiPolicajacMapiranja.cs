namespace PolicijskaUpravaLibrary.Mapiranja
{
    public class SkolskiPolicajacMapiranja : SubclassMap<SkolskiPolicajac>
    {

        public SkolskiPolicajacMapiranja()
        {
            Table("SKOLSKI_POLICAJAC");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.NazivSkole).Column("NAZIV_SKOLE");
            Map(x => x.TipSkole).Column("TIP_SKOLE");
            Map(x => x.AdresaSkole).Column("ADRESA_SKOLE");
            Map(x => x.KontaktIme).Column("KONTAKT_IME");
            Map(x => x.KontaktPrezime).Column("KONTAKT_PREZIME");
            Map(x => x.TelefonSkole).Column("TELEFON_SKOLE");


        }
    }
}
