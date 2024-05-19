using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Mapiranja
{

    class BrojTelefonaMapiranja : ClassMap<BrojTelefona>
    {
        public BrojTelefonaMapiranja()
        {
            Table("BROJ_TELEFONA");
            CompositeId(x => x.Id)
            .KeyProperty(x => x.Broj, "BROJ")
            .KeyReference(x => x.ObjekatZaBroj, "OBJEKAT_ID");
        }
    }
}
