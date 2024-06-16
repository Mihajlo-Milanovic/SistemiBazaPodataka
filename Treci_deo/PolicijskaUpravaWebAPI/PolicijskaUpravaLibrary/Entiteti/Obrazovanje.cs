namespace PolicijskaUpravaLibrary.Entiteti
{
    public class Obrazovanje
    {
        public virtual ObrazovanjeId Id { get; set; }

        public Obrazovanje()
        {
            Id = new ObrazovanjeId();   
        }

        public Obrazovanje(ObrazovanjeId id)
        {
            Id = id;
        }
    }
    public class ObrazovanjeId
    {
        public virtual string Skola { get; set; }
        public virtual DateTime DatumDiplomiranja { get; set; }
        public virtual Policajac PolicajacObrazovanje { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(ObrazovanjeId))
                return false;

            ObrazovanjeId recievedObject = (ObrazovanjeId)obj;

            if ((PolicajacObrazovanje.Id == recievedObject.PolicajacObrazovanje.Id) && (Skola == recievedObject.Skola) &&
                DatumDiplomiranja == recievedObject.DatumDiplomiranja)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
