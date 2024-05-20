using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public abstract class Alarmni_sistem
    {
        public virtual int Id { get; set; }
        public virtual string Serijski_broj { get; set; }
        public virtual string Proizvodjac { get; set; }
        public virtual string Model { get; set; }
        public virtual DateTime Godina_proizvodnje { get; set; }
        public virtual DateTime Datum_instalacije { get; set; }
        public virtual DateTime Datum_poslednjeg_atesta { get; set; }
        public virtual DateTime Datum_poslednjeg_servisiranja { get; set; }
        public virtual string Opis_otklonjenog_kvara { get; set; }
        public virtual string Tip { get; set; }

        public virtual Objekat PripadaObjektu { get; set; }
        public virtual IList<Odrzava> Odrzavan { get; set; }

        public override string ToString()
        {
            return "Serijski broj: " + Serijski_broj
                + "\nProizvodjac: " + Proizvodjac
                + "\nModel: " + Model;    
        }
    }
}
