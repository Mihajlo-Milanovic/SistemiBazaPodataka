namespace PolicijskaUprava.Mapiranja
{
    public class ASDetekcijeToplotnogOdrazaMapiranja : SubclassMap<ASDetekcijeToplotnogOdraza>
    {
        public ASDetekcijeToplotnogOdrazaMapiranja()
        {
            DiscriminatorValue("DETEKCIJA TOPLOTNOG ODRAZA");

            Map(x => x.HorRezIcKamere, "HOR_REZ_IC_KAMERE");
            Map(x => x.VerRezIcKamere, "VER_REZ_IC_KAMERE");

        }
    }
}
