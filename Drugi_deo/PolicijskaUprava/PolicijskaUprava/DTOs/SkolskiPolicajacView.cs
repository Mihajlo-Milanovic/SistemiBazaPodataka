using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class SkolskiPolicajacView : PolicajacView{

		public virtual string NazivSkole { get; set; }
		public virtual string TipSkole { get; set; }
		public virtual string AdresaSkole { get; set; }
		public virtual string KontaktIme { get; set; }
		public virtual string KontaktPrezime { get; set; }
		public virtual string TelefonSkole { get; set; }

		public SkolskiPolicajacView() : base() {
			NazivSkole = string.Empty;
			TipSkole = string.Empty;
			AdresaSkole = string.Empty;
			KontaktIme = string.Empty;
			KontaktPrezime = string.Empty;
			TelefonSkole = string.Empty;
		}

		public SkolskiPolicajacView(int id, string ime, string imeRoditelja, string prezime, DateTime datumRodjenja,
			string jmbg, string adresa, DateTime datumPrijemaUSluzbu, PolicijskaStanicaView stanica, PolicijskaStanicaView
			sefuje, PolicijskaStanicaView zamenik, string tip, string nazivSkole, string tipSkole, string adresaSkole,
			string kontaktIme, string kontaktPrezime, string telefonSkole)
			: base(id, ime, imeRoditelja, prezime, datumRodjenja,
			 jmbg, adresa, datumPrijemaUSluzbu, stanica, sefuje, zamenik, tip) {
			NazivSkole = nazivSkole;
			TipSkole = tipSkole;
			AdresaSkole = adresaSkole;
			KontaktIme = kontaktIme;
			KontaktPrezime = kontaktPrezime;
			TelefonSkole = telefonSkole;
		}

		public SkolskiPolicajacView(SkolskiPolicajac p) : base(p) {

			NazivSkole = p.NazivSkole;
			TipSkole = p.TipSkole;
			AdresaSkole = p.AdresaSkole;
			KontaktIme = p.KontaktIme;
			KontaktPrezime = p.KontaktPrezime;
			TelefonSkole = p.TelefonSkole;
		}	
	}
}
