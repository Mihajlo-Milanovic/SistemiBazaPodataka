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

        public Radnik_u_upravi(string pozicija) : base()
        {
            Pozicija = pozicija;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPozicija: " + Pozicija;
        }
    }
}
