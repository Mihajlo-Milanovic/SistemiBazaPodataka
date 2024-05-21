namespace PolicijskaUprava.DTOs {
	public class AlarmniSistemView {


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
		public virtual string Tip { get; set; }

		public virtual int PripadaObjektuId { get; set; }

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
			Tip = a.Tip;

			if (a.PripadaObjektu != null)
				PripadaObjektuId = a.PripadaObjektu.Id;
			else
				PripadaObjektuId = -1;
		}

		#endregion

	}
}
