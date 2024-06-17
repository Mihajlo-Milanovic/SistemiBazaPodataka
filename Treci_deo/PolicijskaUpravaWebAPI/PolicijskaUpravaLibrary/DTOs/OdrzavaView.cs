using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUpravaLibrary.DTOs {
	public class OdrzavaView {


		#region Properties

		public virtual TehnickoLiceView TehnickoLice { get; set; }
		public virtual AlarmniSistemView AlarmniSistem { get; set; }
		public virtual DateTime Pocetak { get; set; }
		public virtual DateTime Kraj { get; set; }

		#endregion

		#region Constructors

		public OdrzavaView() { }

		public OdrzavaView(Odrzava o) {

			TehnickoLice = new TehnickoLiceView(o.Id.Tehnicar);
			AlarmniSistem = new AlarmniSistemView(o.Id.AlarmniSistem);
			Pocetak = o.Id.PocetniDatum;
			Kraj = o.KrajnjiDatum;
		}

		#endregion

		public Odrzava ToOdrzava() {

			return new Odrzava() {
				KrajnjiDatum = this.Kraj,
				Id = new OdrzavaId() {
					AlarmniSistem = this.AlarmniSistem.ToAlarmniSistem(),
					PocetniDatum = this.Pocetak,
					Tehnicar = this.TehnickoLice.ToTehnickoLice()
				}
			};
		}
	}
}
