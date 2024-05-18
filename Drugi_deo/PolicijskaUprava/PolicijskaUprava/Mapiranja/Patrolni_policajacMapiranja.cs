
namespace PolicijskaUprava.Mapiranja
{
    public class Patrolni_policajacMapiranja : SubclassMap<Patrolni_policajac>
    {
        public Patrolni_policajacMapiranja()
        {
            Table("PATROLNI_POLICAJAC");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Vrsta_oruzja).Column("VRSTA_ORUZJA");
        }
    }
}
