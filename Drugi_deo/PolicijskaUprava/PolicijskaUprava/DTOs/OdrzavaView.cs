using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class OdrzavaView {


		#region Properties

		public virtual int TehnickoLiceId { get; set; }
		public virtual int AlarmniSistem { get; set; }
		public virtual DateTime Pocetak { get; set; }
		public virtual DateTime Kraj { get; set; }

		#endregion

		#region Constructors

		public OdrzavaView() { }

		public OdrzavaView(Odrzava o) {

			TehnickoLiceId = o.Id.Tehnicar.Id;
			AlarmniSistem = o.Id.AlarmniSistem.Id;
			Pocetak = o.Id.PocetniDatum;
			Kraj = o.KrajnjiDatum;
		}

		#endregion


	}
}
