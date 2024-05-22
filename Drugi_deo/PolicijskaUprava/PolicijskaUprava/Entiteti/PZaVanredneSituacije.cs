namespace PolicijskaUprava.Entiteti
{
    public class PZaVanredneSituacije : Policajac
    {

        public virtual string Kurs {  get; set; }
        public virtual string Vestina { get; set; }
        public virtual DateTime DatumZavrsetkaKursa { get; set; }
        public virtual string Sertifikat {  get; set; }
        public virtual DateTime DatumSticanjaSertifikata { get; set; }

        public PZaVanredneSituacije() : base()
        {
            Kurs = string.Empty;
            Vestina = string.Empty;
            Sertifikat = string.Empty;
        }

        public override string ToString()
        {
            return base.ToString() + "\nKurs: " + Kurs + "\nVestina:" + Vestina
                                   + "\nDatum zavrsetka kursa:" + DatumZavrsetkaKursa
                                   + "\nSertifikat: " + Sertifikat
                                   + "\nDatum sticanja sertifikata:" + DatumSticanjaSertifikata;
        }

    }
}
