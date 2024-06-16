namespace PolicijskaUpravaLibrary.Entiteti {

    public class Vozilo {

        public virtual int Id { get; set; }
        public virtual String RegOznaka { get; set; }
        public virtual String Boja { get; set; }
        public virtual String Tip { get; set; }
        public virtual String Proizvodjac { get; set; }
        public virtual String Model { get; set; }

        public virtual IList<Patrola>Patrole{ get; set; }

        public Vozilo() {

            Patrole = new List<Patrola>();

            RegOznaka = string.Empty;
            Boja = string.Empty;
            Tip = string.Empty;
            Proizvodjac = string.Empty;
            Model = string.Empty;
        }

        public Vozilo(int id, string regOznaka, string boja, string tip, string proiz, string model)
        {
            Id = id;
            RegOznaka = regOznaka;
            Boja = boja;
            Tip = tip;
            Proizvodjac = proiz;
            Model = model;

            Patrole = new List<Patrola>();
        }

        public override string ToString() {
            return "ID: " + Id + "\nRegistarska oznaka: " + RegOznaka + "\nBoja: " + Boja + "\nTip: " + Tip + "\nProizvodjac: " + Proizvodjac + "\nModel: " + Model;
        }
    }
}
