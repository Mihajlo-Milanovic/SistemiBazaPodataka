using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti

{
    public class PatrolniPolicajac : Policajac
    {
        public virtual string VrstaOruzja { get; set; }

        public virtual IList<Patrola> SefPatrole { get; set; }
        public virtual IList<Patrola> PomocnikPatrole { get; set; }


        public PatrolniPolicajac() : base()
        {
            VrstaOruzja = string.Empty;
            SefPatrole = new List<Patrola>();
            PomocnikPatrole = new List<Patrola>();
        }
        public PatrolniPolicajac(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
            string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanica stanica,
            PolicijskaStanica sefuje, PolicijskaStanica zamenik, string tip,string vrsta_oruzja, IList<Patrola> sefovi,IList<Patrola> pomocnici)
            : base(id, ime, ime_roditelja, prezime, datum_rodjenja,
             jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje,
             zamenik, tip)
        {
            VrstaOruzja = VrstaOruzja;
            SefPatrole = sefovi;
            PomocnikPatrole = pomocnici;
        }
        public override string ToString()
        {
            return base.ToString() + "\nVrsta oruzja: " + VrstaOruzja;
        }
    }
}
