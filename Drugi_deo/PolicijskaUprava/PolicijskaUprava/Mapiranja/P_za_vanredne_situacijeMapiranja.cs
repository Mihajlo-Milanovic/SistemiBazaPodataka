using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{
    /*
       public virtual string Kurs {  get; set; }
        public virtual string Vestina { get; set; }
        public virtual DateTime Datum_zavrsetka_kursa { get; set; }
        public virtual string Sertifikat {  get; set; }
        public virtual DateTime Datum_sticanja_sertifikata { get; set; }
*/
    class P_za_vanredne_situacijeMapiranja : SubclassMap<P_za_vanredne_situacije>
    {
        public P_za_vanredne_situacijeMapiranja()
        {
            Table("P_ZA_VANREDNE_SITUACIJE");

            KeyColumn("POLICAJAC_ID");

            Map(x => x.Kurs).Column("KURS");
            Map(x => x.Datum_zavrsetka_kursa).Column("DATUM_ZAVRSETKA_KURSA");
            Map(x => x.Sertifikat).Column("SERTIFIKAT");
            Map(x => x.Datum_sticanja_sertifikata).Column("DATUM_STICANJE_SERTIFIKATA");

        }
    }
}
