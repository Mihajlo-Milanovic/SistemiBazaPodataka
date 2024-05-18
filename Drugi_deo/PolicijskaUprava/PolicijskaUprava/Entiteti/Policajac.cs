namespace PolicijskaUprava.Entiteti {

    public class Policajac {

        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Ime_roditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime Datum_rodjenja { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime Datum_prijema_u_sluzbu { get; set; }

		public virtual Policijska_stanica Stanica { get; set; }
		public virtual Policijska_stanica SefujeStanicom { get; set; }
		public virtual Policijska_stanica ZamenikStanice { get; set; }

		public virtual string Tip { get; set; }

        public override string ToString() {
            return "Ime: " + Ime
                + "\nPrezime:" + Prezime
                + "\nDatum rodnjenja:" + Datum_rodjenja
                + "\nJMBG: " + JMBG
                + "\nAdresa: " + Adresa
                + "\n\nRadi u stanici: \n" + Stanica
                + "\n\nJe sef stanice: \n" + SefujeStanicom
				+ "\n\nZamenik u stanici: \n" + ZamenikStanice;
        }

        //public Policajac()
        //{
        //    Ime = string.Empty;
        //    Prezime = string.Empty;
        //    Ime_roditelja = string.Empty;
        //    JMBG = string.Empty;
        //    Adresa = string.Empty;
        //}
    }
}  
       