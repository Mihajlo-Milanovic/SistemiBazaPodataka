namespace PolicijskaUpravaLibrary.DTOs {
	public class AlarmniSistemView : IComparable<AlarmniSistemView> {


		#region Properties

		public virtual int Id { get; set; }
		public virtual string SerijskiBroj { get; set; }
		public virtual string Proizvodjac { get; set; }
		public virtual string Model { get; set; }
		public virtual DateTime GodinaProizvodnje { get; set; }
		public virtual DateTime DatumInstalacije { get; set; }
		public virtual DateTime DatumPoslednjegAtesta { get; set; }
		public virtual DateTime DatumPoslednjegServisiranja { get; set; }
		public virtual string OpisOtklonjenogKvara { get; set; }
		public virtual TipAlarmnogSistema Tip { get; set; }

		public virtual ObjekatView PripadaObjektu { get; set; }

		#endregion

		#region Constructors

		public AlarmniSistemView() { }

		//AlarmniSistemView(int id, string serijskiBroj, string proizvodjac, string model, DateTime godinaProizvodnje, DateTime datumInstalacije,
		//	DateTime datumPoslednjegAtesta, DateTime datumPoslednjegServisiranja, string opisOtklonjenogKvara, string tip, Objekat pripadaObjektu) {

		//	Id = id;
		//	SerijskiBroj = serijskiBroj;
		//	Proizvodjac = proizvodjac;
		//	Model = model;
		//	GodinaProizvodnje = godinaProizvodnje;
		//	DatumInstalacije = datumInstalacije;
		//	DatumPoslednjegAtesta = datumPoslednjegAtesta;
		//	DatumPoslednjegServisiranja = datumPoslednjegServisiranja;
		//	OpisOtklonjenogKvara = opisOtklonjenogKvara;
		//	Tip = tip;
		//	PripadaObjektuId = pripadaObjektu.Id;
		//}

		public AlarmniSistemView(AlarmniSistem a) {

			Id = a.Id;
			SerijskiBroj = a.SerijskiBroj;
			Proizvodjac = a.Proizvodjac;
			Model = a.Model;
			GodinaProizvodnje = a.GodinaProizvodnje;
			DatumInstalacije = a.DatumInstalacije;
			DatumPoslednjegAtesta = a.DatumPoslednjegAtesta;
			DatumPoslednjegServisiranja = a.DatumPoslednjegServisiranja;
			OpisOtklonjenogKvara = a.OpisOtklonjenogKvara;

			if (a.Tip == "ULTRAZVUCNI")
				Tip = TipAlarmnogSistema.Ultrazvucni;
			else if (a.Tip == "DETEKCIJE POKRETA")
				Tip = TipAlarmnogSistema.DetekcijePokreta;
			else
				Tip = TipAlarmnogSistema.DetekcijeToplotnogOdraza;

			PripadaObjektu = new ObjekatView(a.PripadaObjektu);
		}

		#endregion


		public int CompareTo(AlarmniSistemView other) {

			if (this.Id < other.Id)
				return -1;
			else if (this.Id > other.Id)
				return 1;
			else
				return 0;
		}

		public AlarmniSistem ToAlarmniSistem() {

			return new AlarmniSistem() {

				Id = this.Id,
				SerijskiBroj = this.SerijskiBroj,
				Proizvodjac = this.Proizvodjac,
				Model = this.Model,
				GodinaProizvodnje = this.GodinaProizvodnje,
				DatumInstalacije = this.DatumInstalacije,
				DatumPoslednjegAtesta = this.DatumPoslednjegAtesta,
				DatumPoslednjegServisiranja = this.DatumPoslednjegServisiranja,
				OpisOtklonjenogKvara = this.OpisOtklonjenogKvara,

				Tip = this.VratiTip(),

				PripadaObjektu = this.PripadaObjektu.ToObjekat(),

			};
		}

		public string VratiTip() {

			switch (this.Tip) {

				case TipAlarmnogSistema.Ultrazvucni:
				return "ULTRAZVUCNI";

				case TipAlarmnogSistema.DetekcijePokreta:
				return "DETEKCIJE POKRETA";
	
				default:
				return "DETEKCIJE TOPLOTNOG ODRAZA";
			}
		}

	}

	public enum TipAlarmnogSistema {

		Ultrazvucni,
		DetekcijePokreta,
		DetekcijeToplotnogOdraza
	}
}
