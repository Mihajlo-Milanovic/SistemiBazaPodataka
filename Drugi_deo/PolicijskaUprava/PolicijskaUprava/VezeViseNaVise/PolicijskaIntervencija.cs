using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Veze_Vise_Na_Vise
{
    public class PolicijskaIntervencija
    {
        public virtual PolicijskaIntervencijaId Id { get; set; }
        public virtual DateTime DatumIVreme { get; set; }
        public virtual string Opis{ get; set; }
        
    }
    public class PolicijskaIntervencijaId
    {
        public virtual Patrola Broj { get; set; }
        public virtual Objekat ObjekatId { get; set; }

        public PolicijskaIntervencijaId(Patrola broj, Objekat objid) 
        {
            Broj = broj;
            ObjekatId = objid;
        }

        public PolicijskaIntervencijaId() { }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(PolicijskaIntervencijaId))
                return false;

            PolicijskaIntervencijaId recievedObject = (PolicijskaIntervencijaId)obj;

            if ((this.ObjekatId == recievedObject.ObjekatId) && (this.Broj == recievedObject.Broj))
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
