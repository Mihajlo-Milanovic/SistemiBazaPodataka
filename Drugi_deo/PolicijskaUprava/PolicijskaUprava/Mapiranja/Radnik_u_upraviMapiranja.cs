namespace PolicijskaUprava.Mapiranja
{
     
    public class Radnik_u_upraviMapiranja : SubclassMap<RadnikUUpravi>
    {
        public Radnik_u_upraviMapiranja()
        {
            Table("RADNIK_U_UPRAVI");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Pozicija).Column("POZICIJA");
        }
    }
}
