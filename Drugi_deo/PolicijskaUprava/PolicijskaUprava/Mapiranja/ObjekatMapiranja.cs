namespace PolicijskaUprava.Mapiranja
{
    public class ObjekatMapiranja : ClassMap<Objekat>
    {
        ObjekatMapiranja()
        {
            Table("OBJEKAT");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Tip, "TIP");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Povrsina, "POVRSINA");
            Map(x => x.KontaktIme, "KONTAKT_IME");
            Map(x => x.KontaktPrezime, "KONTAKT_PREZIME");
            References(x => x.PolicijskaStanica, "P_STANICA_ID");
            HasMany(x => x.AlarmniSistemi);
        }
    }
}
