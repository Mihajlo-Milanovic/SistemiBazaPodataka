namespace PolicijskaUprava.Mapiranja
{
    
    public class P_za_vanredne_situacijeMapiranja : SubclassMap<P_za_vanredne_situacije>
    {
        public P_za_vanredne_situacijeMapiranja()
        {
            Table("P_ZA_VANREDNE_SITUACIJE");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Kurs).Column("KURS");
            Map(x => x.Vestina).Column("DATUM_ZAVRSETKA_KURSA");
            Map(x => x.Sertifikat).Column("SERTIFIKAT");
            Map(x => x.Datum_sticanja_sertifikata).Column("DATUM_STICANJA_SERTIFIKATA");

        }
    }
}

