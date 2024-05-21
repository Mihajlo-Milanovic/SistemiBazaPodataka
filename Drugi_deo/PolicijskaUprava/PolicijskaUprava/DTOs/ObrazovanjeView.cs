namespace PolicijskaUprava.DTOs {
	public class ObrazovanjeView {

		#region Properties

		public virtual string Skola { get; set; }
		public virtual DateTime DatumDipolomirnja { get; set; }

		#endregion

		#region Constructors

		public ObrazovanjeView() { }

		public ObrazovanjeView(Obrazovanje o) {

			Skola = o.Id.Skola;
			DatumDipolomirnja = o.Id.DatumDiplomiranja;
		}
		
		#endregion
	}
}
