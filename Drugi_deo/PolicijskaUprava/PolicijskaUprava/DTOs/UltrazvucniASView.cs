namespace PolicijskaUprava.DTOs {

	public class UltrazvucniASView : AlarmniSistemView{

		public virtual int GornjaGranica { get; set; }
		public virtual int DonjaGranica { get; set; }

		public UltrazvucniASView() { }

		public UltrazvucniASView(UltrazvucniAS a) : base(a) {

			GornjaGranica = a.GornjaGranica;
			DonjaGranica = a.DonjaGranica;
		}
	}
}
