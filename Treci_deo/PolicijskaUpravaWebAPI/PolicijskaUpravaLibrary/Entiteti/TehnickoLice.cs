namespace PolicijskaUpravaLibrary.Entiteti {

    public class TehnickoLice {
    
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual IList<Odrzava> Odrzava { get; set; }

        public TehnickoLice() { }

        public TehnickoLice(string ime, string prezime, int id = -1) {

            Id = id;
            Ime = ime;
            Prezime = prezime;
        }

        public override string ToString() {
            return "ID tehnickog lica: " + Id
                + "\nIme: " + Ime
                + "\nPrezime: " + Prezime;
        }
    }
}
