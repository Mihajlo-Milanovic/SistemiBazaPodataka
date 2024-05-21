namespace PolicijskaUprava.Entiteti {

    public class Vozilo {

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

        public Vozilo(string reg_oznaka, string boja, string tip, string proiz, string model)
        {
            RegOznaka = reg_oznaka;
            Boja = boja;
            Tip = tip;
            Proizvodjac = proiz;
            Model = model;
        }

        public override string ToString() {
            return "Registarska oznaka: " + RegOznaka + "\nBoja: " + Boja + "\nTip: " + Tip + "\nProizvodjac: " + Proizvodjac + "\nModel: " + Model;
        }
    }
}
