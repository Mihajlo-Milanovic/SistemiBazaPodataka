using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUpravaLibrary.Entiteti.VezeViseNaVise
{
    public class PolicijskaIntervencija
    {
        public virtual PolicijskaIntervencijaId Id { get; set; }
        public virtual string Opis { get; set; }

    }
    public class PolicijskaIntervencijaId
    {
        public virtual Patrola Patrola { get; set; }
        public virtual Objekat Objekat { get; set; }
		public virtual DateTime DatumIVreme { get; set; }

		public PolicijskaIntervencijaId(Patrola broj, Objekat objid)
        {
            Patrola = broj;
            Objekat = objid;
        }

        public PolicijskaIntervencijaId() { }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(PolicijskaIntervencijaId))
                return false;

            PolicijskaIntervencijaId recievedObject = (PolicijskaIntervencijaId)obj;

            if (Objekat == recievedObject.Objekat && Patrola == recievedObject.Patrola)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
