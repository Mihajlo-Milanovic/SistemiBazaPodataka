using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
    public class Tehnicko_lice
    {
        public virtual int Id { get; set; }
        public Tehnicko_lice() { }

        public override string ToString()
        {
            return "ID tehnickog lica: " + Id;
        }
    }
}
