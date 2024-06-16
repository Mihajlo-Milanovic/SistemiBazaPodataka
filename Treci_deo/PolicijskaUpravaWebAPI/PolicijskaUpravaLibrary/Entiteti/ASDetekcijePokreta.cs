namespace PolicijskaUpravaLibrary.Entiteti
{
    public class ASDetekcijePokreta : AlarmniSistem
    {
        public virtual string Osetljivost { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Osetljivost: " + Osetljivost;
        }
    }
}
