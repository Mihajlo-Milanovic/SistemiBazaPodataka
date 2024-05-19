namespace PolicijskaUprava.Entiteti {

    public class Tehnicko_lice {
    
        public virtual int Id { get; set; }
        public Tehnicko_lice() { }
        public virtual IList<Odrzava> Odrzava { get; set; }

        public override string ToString() {
            return "ID tehnickog lica: " + Id;
        }
    }
}
