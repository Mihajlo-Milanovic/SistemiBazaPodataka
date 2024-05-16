namespace PolicijskaUprava.Mapiranja
{
     
    public class Radnik_u_upraviMapiranja : SubclassMap<Radnik_u_upravi>
    {
        public Radnik_u_upraviMapiranja()
        {
            Table("RADNIK_U_UPRAVI");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Pozicija).Column("POZICIJA");
        }
    }
}
