namespace PolicijskaUprava.Mapiranja {

    class PolicajacMapiranja : ClassMap<Policajac> {
    
        public PolicajacMapiranja() {
            Table("POLICAJAC");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();/// proveriti!!!!!!

            Map(x => x.Ime, "IME");
            Map(x => x.Ime_roditelja, "IME_RODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Datum_rodjenja, "DATUM_RODJENJA");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Datum_prijema_u_sluzbu, "DATUM_PRIJEMA_U_SLUZBU");

          //  HasMany(x => x.PolicajciPozornici);
          //  HasMany(x => x.PatrolniPolicajci);
        }
    }
}
