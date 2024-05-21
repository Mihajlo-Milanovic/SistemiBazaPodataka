using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs {
	public class VoziloView {

		#region Properties

		public virtual String RegOznaka { get; set; }
		public virtual String Boja { get; set; }
		public virtual String Tip { get; set; }
		public virtual String Proizvodjac { get; set; }
		public virtual String Model { get; set; }

		#endregion

		#region Constructors

		public VoziloView() {}

		public VoziloView(Vozilo v) {

			RegOznaka = v.RegOznaka;
			Boja = v.Boja;
			Tip = v.Tip;
			Proizvodjac = v.Proizvodjac;
			Model = v.Model;
		}

		#endregion
	}
}
