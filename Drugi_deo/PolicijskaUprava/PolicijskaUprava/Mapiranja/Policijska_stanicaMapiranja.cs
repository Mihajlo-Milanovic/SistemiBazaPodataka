using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;


namespace PolicijskaUprava.Mapiranja
{
    class Policijska_stanicaMapiranja : ClassMap<Policijska_stanica>
    {
        public Policijska_stanicaMapiranja()
        {
            Table("POLICIJSKA_STANICA");
            //return "Naziv: " + Naziv + "\nOpstina:" +
            //Opstina + "\nAdresa:" + Adresa + "\nDatum osnivanja:
            //" + Datum_osnivanja + "\nBroj vozila: " + Broj_vozila;

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();/// proveriti!!!!!!

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Opstina, "OPSTINA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Datum_osnivanja, "DATUM_OSNIVANJA");
            Map(x => x.Broj_vozila, "BROJ_VOZILA");
        }
    }
}
