namespace PolicijskaUprava.Entiteti
{
    /*RADNIK_U_UPRAVI
    (POLICAJAC_ID, POZICIJA)
*/

    public class Radnik_u_upravi : Policajac
    {
        public virtual string Pozicija { get; set; }

        public Radnik_u_upravi() : base()
        {
            Pozicija = string.Empty;
        }

        public Radnik_u_upravi(int id,string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, Policijska_stanica stanica,
            Policijska_stanica sefuje, Policijska_stanica zamenik, string tip, string pozicija)
            : base(id,ime, ime_roditelja, prezime, datum_rodjenja,
             jmbg, adresa, datum_prijema_u_sluzbu, stanica,
             sefuje, zamenik, tip)
        {
            Pozicija = pozicija;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPozicija: " + Pozicija;
        }
    }
}
