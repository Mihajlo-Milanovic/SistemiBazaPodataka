namespace PolicijskaUprava.Entiteti
{
    public class P_za_vanredne_situacije : Policajac
    {

        public virtual string Kurs {  get; set; }
        public virtual string Vestina { get; set; }
        public virtual DateTime Datum_zavrsetka_kursa { get; set; }
        public virtual string Sertifikat {  get; set; }
        public virtual DateTime Datum_sticanja_sertifikata { get; set; }

        //public P_za_vanredne_situacije()
        //{
        //    Kurs = string.Empty;
        //    Vestina = string.Empty;
        //    Sertifikat = string.Empty;
        //}
        public override string ToString()
        {
            return base.ToString() + "\nKurs: " + Kurs + "\nVestina:" + Vestina
                                   + "\nDatum zavrsetka kursa:" + Datum_zavrsetka_kursa
                                   + "\nSertifikat: " + Sertifikat
                                   + "\nDatum sticanja sertifikata:" + Datum_sticanja_sertifikata;
        }

    }
}
