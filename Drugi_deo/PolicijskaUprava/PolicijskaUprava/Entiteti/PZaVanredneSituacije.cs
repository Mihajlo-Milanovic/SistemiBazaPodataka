namespace PolicijskaUprava.Entiteti
{
    public class PZaVanredneSituacije : Policajac
    {

        public virtual string Kurs {  get; set; }
        public virtual string Vestina { get; set; }
        public virtual DateTime Datum_zavrsetka_kursa { get; set; }
        public virtual string Sertifikat {  get; set; }
        public virtual DateTime Datum_sticanja_sertifikata { get; set; }

        public PZaVanredneSituacije() : base()
        {
            Kurs = string.Empty;
            Vestina = string.Empty;
            Sertifikat = string.Empty;
        }
        public PZaVanredneSituacije(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanica stanica, PolicijskaStanica sefuje,
            PolicijskaStanica zamenik, string tip, string kurs, string vestina, DateTime datum_zavrsetka_kursa, string sertifikat,
            DateTime datum_sticanja_sertifikata)
            : base(id,ime, ime_roditelja, prezime, datum_rodjenja,
             jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje, zamenik, tip)
        {
            Kurs = kurs;
            Vestina = vestina;
            Datum_zavrsetka_kursa = datum_zavrsetka_kursa;
            Sertifikat = sertifikat;
            Datum_sticanja_sertifikata = datum_sticanja_sertifikata;
        }

        public override string ToString()
        {
            return base.ToString() + "\nKurs: " + Kurs + "\nVestina:" + Vestina
                                   + "\nDatum zavrsetka kursa:" + Datum_zavrsetka_kursa
                                   + "\nSertifikat: " + Sertifikat
                                   + "\nDatum sticanja sertifikata:" + Datum_sticanja_sertifikata;
        }

    }
}
