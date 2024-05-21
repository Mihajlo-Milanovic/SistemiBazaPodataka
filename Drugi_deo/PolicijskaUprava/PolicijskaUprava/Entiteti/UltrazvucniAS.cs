namespace PolicijskaUprava.Entiteti
{
    public class UltrazvucniAS : AlarmniSistem
    {
        public virtual int GornjaGranica { get; set; }
        public virtual int DonjaGranica { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Gornja granica: " + GornjaGranica + "\nDonja granica: " + DonjaGranica;
        }
    }
}
