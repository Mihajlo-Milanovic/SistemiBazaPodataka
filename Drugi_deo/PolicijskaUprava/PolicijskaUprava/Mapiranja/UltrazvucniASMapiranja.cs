namespace PolicijskaUprava.Mapiranja
{
    public class UltrazvucniASMapiranja : SubclassMap<UltrazvucniAS>
    {
        public UltrazvucniASMapiranja()
        {
            DiscriminatorValue("ULTRAZVUCNI");

            Map(x => x.GornjaGranica, "GORNJA_GRANICA");
            Map(x => x.DonjaGranica, "DONJA_GRANICA");

        }
    }
}
