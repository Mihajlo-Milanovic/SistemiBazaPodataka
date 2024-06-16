namespace PolicijskaUpravaLibrary.DTOs {

	public class UltrazvucniASView : AlarmniSistemView{

		#region Properties

		public virtual int GornjaGranica { get; set; }
		public virtual int DonjaGranica { get; set; }

		#endregion

		#region Constructors

		public UltrazvucniASView() { }

		public UltrazvucniASView(UltrazvucniAS a) : base(a) {

			GornjaGranica = a.GornjaGranica;
			DonjaGranica = a.DonjaGranica;
		}

		#endregion

	}
}
