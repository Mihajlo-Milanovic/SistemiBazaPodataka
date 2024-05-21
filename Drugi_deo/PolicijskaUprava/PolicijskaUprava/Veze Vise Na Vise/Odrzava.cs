using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Veze_Vise_Na_Vise
{
    public class Odrzava
    {
        public virtual OdrzavaId Id { get; set; }
        public virtual DateTime PocetniDatum { get; set; }
        public virtual DateTime KrajnjiDatum { get; set; }
        
    }
    public class OdrzavaId
    {
        public virtual TehnickoLice Tehnicar { get; set; }
        public virtual AlarmniSistem AlarmniSistem { get; set; }

        public OdrzavaId(TehnickoLice tehnicar, AlarmniSistem alarmni) 
        {
            Tehnicar = tehnicar ;
            AlarmniSistem = alarmni;
        }

        public OdrzavaId() { }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(OdrzavaId))
                return false;

            OdrzavaId recievedObject = (OdrzavaId)obj;

            if ((this.AlarmniSistem == recievedObject.AlarmniSistem) && (this.Tehnicar == recievedObject.Tehnicar))
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
