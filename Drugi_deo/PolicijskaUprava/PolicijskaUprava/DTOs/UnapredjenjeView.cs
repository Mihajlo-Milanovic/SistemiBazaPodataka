namespace PolicijskaUprava.DTOs {
	public class UnapredjenjeView {

		#region Properties

		public virtual string Cin { get; set; }
		public virtual DateTime DatumSticanja { get; set; }

		//public virtual int  PolicajacId { get; set; }

		#endregion

		#region Constructors

		public UnapredjenjeView() { }

		public UnapredjenjeView(Unapredjenje u) {

			Cin = u.Cin;
			DatumSticanja = u.Id.DatumSticanja;
		}

		#endregion
	}
}
