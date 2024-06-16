namespace PolicijskaUpravaLibrary.Mapiranja
{
    public class ASDetekcijeToplotnogOdrazaMapiranja : SubclassMap<ASDetekcijeToplotnogOdraza>
    {
        public ASDetekcijeToplotnogOdrazaMapiranja()
        {
            DiscriminatorValue("DETEKCIJE TOPLOTNOG ODRAZA");

            Map(x => x.HorRezIcKamere, "HOR_REZ_IC_KAMERE");
            Map(x => x.VerRezIcKamere, "VER_REZ_IC_KAMERE");

        }
    }
}
