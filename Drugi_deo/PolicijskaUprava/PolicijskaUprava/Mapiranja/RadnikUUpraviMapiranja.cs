namespace PolicijskaUprava.Mapiranja
{
     
    public class RadnikUUpraviMapiranja : SubclassMap<RadnikUUpravi>
    {
        public RadnikUUpraviMapiranja()
        {
            Table("RADNIK_U_UPRAVI");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Pozicija).Column("POZICIJA");
        }
    }
}
