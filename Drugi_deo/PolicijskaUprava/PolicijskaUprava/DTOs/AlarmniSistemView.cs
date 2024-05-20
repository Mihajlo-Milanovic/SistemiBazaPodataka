using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class AlarmniSistemView {

		public virtual int Id { get; set; }
		public virtual string SerijskiBroj { get; set; }
		public virtual string Proizvodjac { get; set; }
		public virtual string Model { get; set; }
		public virtual DateTime GodinaProizvodnje { get; set; }
		public virtual DateTime DatumInstalacije { get; set; }
		public virtual DateTime DatumPoslednjegAtesta { get; set; }
		public virtual DateTime DatumPoslednjegServisiranja { get; set; }
		public virtual string OpisOtklonjenogKvara { get; set; }
		public virtual string Tip { get; set; }
		public virtual Objekat PripadaObjektu { get; set; }

		//public virtual IList<Odrzava> Odrzavan { get; set; }


		AlarmniSistemView() { }

		AlarmniSistemView(int id, string serijskiBroj, string proizvodjac, string model, DateTime godinaProizvodnje, DateTime datumInstalacije,
			DateTime datumPoslednjegAtesta, DateTime datumPoslednjegServisiranja, string opisOtklonjenogKvara, string tip, Objekat pripadaObjektu) {

			Id = id;
			SerijskiBroj = serijskiBroj;
			Proizvodjac = proizvodjac;
			Model = model;
			GodinaProizvodnje = godinaProizvodnje;
			DatumInstalacije = datumInstalacije;
			DatumPoslednjegAtesta = datumPoslednjegAtesta;
			DatumPoslednjegServisiranja = datumPoslednjegServisiranja;
			OpisOtklonjenogKvara = opisOtklonjenogKvara;
			Tip = tip;
			PripadaObjektu = pripadaObjektu;
		}
	}
}
