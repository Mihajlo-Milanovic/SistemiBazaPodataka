namespace PolicijskaUprava.Mapiranja
{
    public class ASDetekcijePokretaMapiranja : SubclassMap<ASDetekcijePokreta>
    {
        public ASDetekcijePokretaMapiranja()
        {
            DiscriminatorValue("DETEKCIJA POKRETA");

            Map(x => x.Osetljivost, "OSETLJIVOST");

        }
    }
}
