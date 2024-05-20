namespace PolicijskaUprava.Entiteti {

    public class Policajac {

        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime DatumPrijemaUSluzbu { get; set; }
        public virtual PolicijskaStanica Stanica { get; set; }
        public virtual PolicijskaStanica SefujeStanicom { get; set; }
        public virtual PolicijskaStanica ZamenikStanice { get; set; }
        public virtual string Tip { get; set; }

      
        public override string ToString()
        { 
            return "Ime: " + Ime
                + "\nPrezime:" + Prezime
                + "\nDatum rodnjenja:" + DatumRodjenja
                + "\nJMBG: " + JMBG
                + "\nAdresa: " + Adresa
                + "\nTip: " + Tip 
                + "\n\nRadi u stanici sa ID: \n" + Stanica.Id
                + "\n\nJe sef stanice sa ID: \n" + SefujeStanicom.Id
				+ "\n\nZamenik u stanici sa ID: \n" + ZamenikStanice.Id;
        }

        public Policajac()
        {
            Ime = string.Empty;
            Prezime = string.Empty;
            ImeRoditelja = string.Empty;
            JMBG = string.Empty;
            Adresa = string.Empty;
            Stanica = new PolicijskaStanica();
            SefujeStanicom = new PolicijskaStanica();
            ZamenikStanice = new PolicijskaStanica();
        }
        public Policajac(int id,string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa,DateTime datum_prijema_u_sluzbu, PolicijskaStanica stanica, PolicijskaStanica sefuje, PolicijskaStanica zamenik,string tip)
        {
            Id = id;
            Ime = ime;
            ImeRoditelja = ime_roditelja;
            Prezime = prezime;
            DatumRodjenja = datum_rodjenja;
            JMBG = jmbg;
            Adresa = adresa;
            DatumPrijemaUSluzbu = datum_prijema_u_sluzbu;
            Stanica = stanica;
            SefujeStanicom = sefuje;
            ZamenikStanice = zamenik;
            Tip = tip;
        }
    }
}  
       