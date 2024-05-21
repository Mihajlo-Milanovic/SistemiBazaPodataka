using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class PolicajacPozornikView : PolicajacView{


		#region Properties

		public virtual string NazivUlice { get; set; }
		
		#endregion

		#region Constructors

		public PolicajacPozornikView() : base() {
			NazivUlice = string.Empty;
		}

		//public PolicajacPozornikView(int id, string ime, string ime_roditelja, string prezime, DateTime datum_rodjenja,
		//	string jmbg, string adresa, DateTime datum_prijema_u_sluzbu, PolicijskaStanicaView stanica,
		//	PolicijskaStanicaView sefuje, PolicijskaStanicaView zamenik, string tip, string naziv_ulice)
		//	: base(id, ime, ime_roditelja, prezime, datum_rodjenja,
		//	 jmbg, adresa, datum_prijema_u_sluzbu, stanica, sefuje, zamenik, tip) {
		//	NazivUlice = naziv_ulice;
		//}

		public PolicajacPozornikView(PolicajacPozornik p) : base(p) {

			NazivUlice = p.NazivUlice;
		}

		#endregion



	}
}
