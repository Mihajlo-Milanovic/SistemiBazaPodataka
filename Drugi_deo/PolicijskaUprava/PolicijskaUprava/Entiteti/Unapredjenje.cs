using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti {
	public class Unapredjenje {
	
		public virtual UnapredjenjeId Id { get; set; }	
		public virtual string Cin { get; set; }


		public Unapredjenje() {
			Id = new UnapredjenjeId();
		}

		public Unapredjenje(DateTime datumSticanja, string cin, Policajac policajac) { 
		
			Id = new UnapredjenjeId(policajac, datumSticanja);
			Cin = cin;
		}

		public override string ToString() {
			return Id.Policajac
				+ "\n\nDana: " + Id.DatumSticanja
				+ "\nUnapredjen u: " + Cin;
		}
	}

	public class UnapredjenjeId {

		public virtual Policajac Policajac { get; set; }
		public virtual DateTime DatumSticanja { get; set; }

		public UnapredjenjeId() { 
			
		}

		public UnapredjenjeId(Policajac policajac, DateTime datumSticanja) {

			Policajac = policajac;
			DatumSticanja = datumSticanja;
		}

		public override bool Equals(object obj) {
			if (Object.ReferenceEquals(this, obj))
				return true;

			if (obj.GetType() != typeof(UnapredjenjeId))
				return false;

			UnapredjenjeId recivedObj = (UnapredjenjeId)obj;


			if (this.Policajac == recivedObj.Policajac && this.DatumSticanja == recivedObj.DatumSticanja)
				return true;
			return false;
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}
	}
}
