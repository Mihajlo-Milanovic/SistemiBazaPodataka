namespace PolicijskaUprava.Mapiranja {

    class PolicajacMapiranja : ClassMap<Policajac> {
    
        public PolicajacMapiranja() {
            Table("POLICAJAC");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.ImeRoditelja, "IME_RODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.DatumPrijemaUSluzbu, "DATUM_PRIJEMA_U_SLUZBU");

          //  HasMany(x => x.PolicajciPozornici);
          //  HasMany(x => x.PatrolniPolicajci);
       
            Map(x => x.Tip, "TIP");


			//STANICA_ID,SEF_STANICE,ZAMENIK_STANICE
			References(x => x.Stanica).Column("STANICA_ID").Not.LazyLoad();
			References(x => x.SefujeStanicom).Column("SEF_STANICE").Not.LazyLoad();
			References(x => x.ZamenikStanice).Column("ZAMENIK_STANICE").Not.LazyLoad();
		}
    }
}
