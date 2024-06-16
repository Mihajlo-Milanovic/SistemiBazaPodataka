namespace PolicijskaUpravaLibrary.DTOs {
	public class ASDetekcijePokretaView : AlarmniSistemView{

		#region Properties

		public virtual string Osetljivost { get; set; }

		#endregion

		#region Constructors

		public ASDetekcijePokretaView() { }

		public ASDetekcijePokretaView(ASDetekcijePokreta a) : base(a) {

			Osetljivost = a.Osetljivost;
		}

		#endregion

	}
}
