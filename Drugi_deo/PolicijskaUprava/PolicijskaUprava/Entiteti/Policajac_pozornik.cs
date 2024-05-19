using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti {
    public class Policajac_pozornik : Policajac {

        public virtual string Naziv_ulice { get; set; }
        public virtual Policajac Policajac { get; set; }
    }
}
