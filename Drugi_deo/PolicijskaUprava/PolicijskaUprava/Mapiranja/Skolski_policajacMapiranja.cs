namespace PolicijskaUprava.Mapiranja
{
    public class Skolski_policajacMapiranja : SubclassMap<Skolski_policajac>
    {

        public Skolski_policajacMapiranja()
        {
            Table("SKOLSKI_POLICAJAC");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Naziv_skole).Column("NAZIV_SKOLE");
            Map(x => x.Tip_skole).Column("TIP_SKOLE");
            Map(x => x.Adresa_skole).Column("ADRESA_SKOLE");
            Map(x => x.Kontakt_ime).Column("KONTAKT_IME");
            Map(x => x.Kontakt_prezime).Column("KONTAKT_PREZIME");
            Map(x => x.Telefon_skole).Column("TELEFON_SKOLE");


        }
    }
}
