namespace PolicijskaUprava.Entiteti {

    public class TehnickoLice {
    
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual IList<Odrzava> Odrzava { get; set; }

        public TehnickoLice() { }

        public override string ToString() {
            return "ID tehnickog lica: " + Id;
        }
    }
}
