namespace PolicijskaUprava.Entiteti {

    public class RadnikUUpravi : Policajac {

        public virtual string Pozicija { get; set; }

        public RadnikUUpravi() : base() {
            Pozicija = string.Empty;
        }

        public RadnikUUpravi(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanica stanica,
            PolicijskaStanica sefuje, PolicijskaStanica zamenik, string tip, string pozicija)
            : base(id, ime, ime_roditelja, prezime, datum_rodjenja,
             jmbg, adresa, datum_prijema_u_sluzbu, stanica,
             sefuje, zamenik, tip) {
            Pozicija = pozicija;
        }

        public override string ToString() {
            return base.ToString() + "\nPozicija: " + Pozicija;
        }
    }
}