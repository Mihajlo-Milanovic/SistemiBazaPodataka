namespace PolicijskaUprava.Mapiranja {

    class PolicajacMapiranja : ClassMap<Policajac> {
    
        public PolicajacMapiranja() {
            Table("POLICAJAC");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Ime_roditelja, "IME_RODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Datum_rodjenja, "DATUM_RODJENJA");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Datum_prijema_u_sluzbu, "DATUM_PRIJEMA_U_SLUZBU");


			//STANICA_ID,SEF_STANICE,ZAMENIK_STANICE
			References(x => x.Stanica).Column("STANICA_ID").LazyLoad();
			References(x => x.SefujeStanicom).Column("SEF_STANICE").LazyLoad();
			References(x => x.ZamenikStanice).Column("ZAMENIK_STANICE").LazyLoad();
		}
    }
}
