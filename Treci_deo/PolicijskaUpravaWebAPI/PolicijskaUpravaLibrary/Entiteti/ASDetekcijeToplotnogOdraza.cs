namespace PolicijskaUpravaLibrary.Entiteti
{
    public class ASDetekcijeToplotnogOdraza : AlarmniSistem
    {
        public virtual int HorRezIcKamere { get; set; }
        public virtual int VerRezIcKamere { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nHorizontalna rezolucija: " + HorRezIcKamere.ToString() + "\nVertikalna rezolucija: " + VerRezIcKamere.ToString();
        }
    }
}
