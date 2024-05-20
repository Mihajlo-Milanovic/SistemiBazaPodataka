using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class PatrolniPolicajacView : PolicajacView {

		public virtual string Vrsta_oruzja { get; set; }


		//public virtual IList<Patrola> SefPatrole { get; set; }
		//public virtual IList<Patrola> PomocnikPatrole { get; set; }

		public PatrolniPolicajacView() : base() {
			Vrsta_oruzja = string.Empty;
			//SefPatrole = new List<Patrola>();
			//PomocnikPatrole = new List<Patrola>();
		}
		public PatrolniPolicajacView(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
			string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanicaView stanica,
			PolicijskaStanicaView sefuje, PolicijskaStanicaView zamenik, string tip, string vrsta_oruzja, IList<Patrola> sefovi, IList<Patrola> pomocnici)
			: base(id, ime, ime_roditelja, prezime, datum_rodjenja,
			 jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje,
			 zamenik, tip) {
			Vrsta_oruzja = Vrsta_oruzja;
			//SefPatrole = sefovi;
			//PomocnikPatrole = pomocnici;
		}
		public override string ToString() {
			return base.ToString() + "\nVrsta oruzja: " + Vrsta_oruzja;
		}

		public PatrolniPolicajacView(PatrolniPolicajac p) : base(p) {

			Vrsta_oruzja = p.VrstaOruzja;
		}
	}
}
