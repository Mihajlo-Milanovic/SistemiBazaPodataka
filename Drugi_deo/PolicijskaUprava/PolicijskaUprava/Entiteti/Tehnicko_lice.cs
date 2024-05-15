namespace PolicijskaUprava.Entiteti {

    public class Tehnicko_lice {
    
        public virtual int Id { get; set; }
        public Tehnicko_lice() { }

        public override string ToString() {
            return "ID tehnickog lica: " + Id;
        }
    }
}
