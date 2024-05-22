namespace PolicijskaUprava.Mapiranja
{
    public class AS_detekcije_toplotnog_odrazaMapiranja : SubclassMap<ASDetekcijeToplotnogOdraza>
    {
        public AS_detekcije_toplotnog_odrazaMapiranja()
        {
            DiscriminatorValue("DETEKCIJA TOPLOTNOG ODRAZA");

            Map(x => x.HorRezIcKamere, "HOR_REZ_IC_KAMERE");
            Map(x => x.VerRezIcKamere, "VER_REZ_IC_KAMERE");

        }
    }
}
