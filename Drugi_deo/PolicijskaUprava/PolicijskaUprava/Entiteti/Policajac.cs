using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class Policajac
    {
       public virtual int Id { get; set; }
       public virtual string Ime {  get; set; }
       public virtual string Ime_roditelja {  get; set; }
       public virtual string Prezime { get; set; }
       public virtual DateTime Datum_rodjenja {  get; set; }
       public virtual string JMBG { get; set; }
       public virtual string Adresa {  get; set; }
       public virtual DateTime Datum_prijema_u_sluzbu {  get; set; }

        //public virtual Stanica Stanica { get; set; }

        //public virtual Stanica Je_sef { get; set; }

        //public virtual Stanica Zamenik { get; set; }

        //public virtual string Tip { get; set; }

        public override string ToString()
        {
            return "Ime: " + Ime + "\nPrezime:" + Prezime + "\nDatum rodnjenja:" + Datum_rodjenja + "\nJMBG: " + JMBG + "\nAdresa: " + Adresa; 
        }
        public Policajac() 
        {
            Ime = string.Empty;
            Prezime = string.Empty;
            Ime_roditelja = string.Empty;
            JMBG = string.Empty;
            Adresa = string.Empty;
        }
    }  
}      
       