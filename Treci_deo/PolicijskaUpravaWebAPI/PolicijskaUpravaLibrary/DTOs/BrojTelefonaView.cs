namespace PolicijskaUpravaLibrary.DTOs {
	public class BrojTelefonaView {

		#region Properties

		public virtual string Broj { get; set; }

		#endregion

		#region Constructors

		public BrojTelefonaView() { }
		public BrojTelefonaView(string bt)
		{
			Broj = bt;
		}

		public BrojTelefonaView(BrojTelefona b) {

			Broj = b.Id.Broj;
		}

		#endregion
	}
}
