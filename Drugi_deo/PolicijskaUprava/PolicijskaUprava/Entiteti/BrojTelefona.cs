using FluentNHibernate.MappingModel.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class BrojTelefona
    {
        public virtual BrojTelefonaId Id { get; set; }

        public BrojTelefona(BrojTelefonaId id)
        {
            Id = id;
        }

        public BrojTelefona() 
        {
            Id = new BrojTelefonaId();
        }

        public override string ToString()
        {
            return Id.Broj.ToString() + "\n" +
                   Id.ObjekatZaBroj.ToString();
        }
    }
    public class BrojTelefonaId
    {
        public virtual int Broj { get; set; }
        public virtual Objekat ObjekatZaBroj { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(BrojTelefonaId))
                return false;

            BrojTelefonaId recievedObject = (BrojTelefonaId)obj;

            if ((ObjekatZaBroj.Id == recievedObject.ObjekatZaBroj.Id) && (Broj == recievedObject.Broj))
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
