namespace PolicijskaUprava.Mapiranja
{
    
    public class PZaVanredneSituacijeMapiranja : SubclassMap<PZaVanredneSituacije>
    {
        public PZaVanredneSituacijeMapiranja()
        {
            Table("P_ZA_VANREDNE_SITUACIJE");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Kurs).Column("KURS");
            Map(x => x.Vestina).Column("VESTINA");
            Map(x => x.Sertifikat).Column("SERTIFIKAT");
            Map(x => x.DatumSticanjaSertifikata).Column("DATUM_STICANJA_SERTIFIKATA");
            Map(x => x.DatumZavrsetkaKursa).Column("DATUM_ZAVRSETKA_KURSA");
        }
    }
}

