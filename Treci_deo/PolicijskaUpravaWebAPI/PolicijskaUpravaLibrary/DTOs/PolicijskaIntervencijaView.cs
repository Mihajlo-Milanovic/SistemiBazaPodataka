namespace PolicijskaUpravaLibrary.DTOs {
	public class PolicijskaIntervencijaView {

		#region Properties

		public virtual PatrolaView Patrola { get; set; }
		public virtual ObjekatView Objekat { get; set; }
		public virtual DateTime DatumIVreme { get; set; }
		public virtual string Opis { get; set; }

		#endregion

		#region Constructors

		public PolicijskaIntervencijaView() { }

		public PolicijskaIntervencijaView(PolicijskaIntervencija o) {

			this.Opis = o.Opis;
			this.DatumIVreme = o.Id.DatumIVreme;
			this.Patrola = new PatrolaView(o.Id.Patrola);
			this.Objekat = new ObjekatView(o.Id.Objekat);
		}

		#endregion

		public PolicijskaIntervencija ToPolicijskaIntervencija() {

			return new PolicijskaIntervencija() {

				Id = new PolicijskaIntervencijaId() {
					Objekat = this.Objekat.ToObjekat(),
					Patrola = this.Patrola.ToPatrola(),
					DatumIVreme = this.DatumIVreme,
				},
				Opis = this.Opis
			};
		}
	}
}
