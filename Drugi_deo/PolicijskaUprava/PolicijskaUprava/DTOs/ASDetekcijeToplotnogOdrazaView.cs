using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class ASDetekcijeToplotnogOdrazaView : AlarmniSistemView {

		public virtual int HorRezIcKamere { get; set; }
		public virtual int VerRezIcKamere { get; set; }

		public ASDetekcijeToplotnogOdrazaView() { }

		public ASDetekcijeToplotnogOdrazaView(ASDetekcijeToplotnogOdraza a) : base(a) {

			HorRezIcKamere = a.HorRezIcKamere;
			VerRezIcKamere = a.VerRezIcKamere;
		}
	}
}
