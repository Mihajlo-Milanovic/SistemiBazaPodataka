namespace PolicijskaUpravaLibrary.Entiteti
{
    public class AlarmniSistem
    {
        public virtual int Id { get; set; }
        public virtual string SerijskiBroj { get; set; }
        public virtual string Proizvodjac { get; set; }
        public virtual string Model { get; set; }
        public virtual DateTime GodinaProizvodnje { get; set; }
        public virtual DateTime DatumInstalacije { get; set; }
        public virtual DateTime DatumPoslednjegAtesta { get; set; }
        public virtual DateTime DatumPoslednjegServisiranja { get; set; }
        public virtual string OpisOtklonjenogKvara { get; set; }
        public virtual string Tip { get; set; }

        public virtual Objekat PripadaObjektu { get; set; }
        public virtual IList<Odrzava> Odrzavan { get; set; }

        public override string ToString()
        {
            return "Serijski broj: " + SerijskiBroj
                + "\nProizvodjac: " + Proizvodjac
                + "\nModel: " + Model;    
        }
    }
}
