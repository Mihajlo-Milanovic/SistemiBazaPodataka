using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

/*CREATE TABLE POLICIJSKA_STANICA(
    ID NUMBER PRIMARY KEY,
    NAZIV VARCHAR2(30),
    OPSTINA VARCHAR2(30),
    ADRESA VARCHAR2(30),
    DATUM_OSNIVANJA DATE,
    BROJ_VOZILA NUMBER
);
*/

namespace PolicijskaUprava.Entiteti
{
    public class Policijska_stanica
    {
        public virtual int Id { get; set; }
        public virtual string Naziv {  get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Adresa { get; set; }
        public virtual DateTime Datum_osnivanja { get; set; }
        public virtual int Broj_vozila { get; set; }

        public Policijska_stanica()
        {
            Naziv = string.Empty;
            Opstina = string.Empty;
            Adresa = string.Empty;
        }

        public override string ToString()
        {
            return "Naziv: " + Naziv + "\nOpstina:" + Opstina + "\nAdresa:" + Adresa + "\nDatum osnivanja: " + Datum_osnivanja + "\nBroj vozila: " + Broj_vozila;
        }

    }
}
