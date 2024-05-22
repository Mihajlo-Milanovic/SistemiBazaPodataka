namespace PolicijskaUprava.Entiteti {

    public class RadnikUUpravi : Policajac {

        public virtual string Pozicija { get; set; }

        public RadnikUUpravi() : base() {
            Pozicija = string.Empty;
        }

        public override string ToString() {
            return base.ToString() + "\nPozicija: " + Pozicija;
        }
    }
}