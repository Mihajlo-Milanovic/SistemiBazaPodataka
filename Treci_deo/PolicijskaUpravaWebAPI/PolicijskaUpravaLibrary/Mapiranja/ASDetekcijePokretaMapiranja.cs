namespace PolicijskaUpravaLibrary.Mapiranja
{
    public class ASDetekcijePokretaMapiranja : SubclassMap<ASDetekcijePokreta>
    {
        public ASDetekcijePokretaMapiranja()
        {
            DiscriminatorValue("DETEKCIJE POKRETA");

            Map(x => x.Osetljivost, "OSETLJIVOST");

        }
    }
}
