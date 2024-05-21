using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class ASDetekcijePokretaView : AlarmniSistemView{

		public virtual string Osetljivost { get; set; }

		public ASDetekcijePokretaView(ASDetekcijePokreta a) : base(a) { 
		
			Osetljivost = a.Osetljivost;
		}
	}
}
