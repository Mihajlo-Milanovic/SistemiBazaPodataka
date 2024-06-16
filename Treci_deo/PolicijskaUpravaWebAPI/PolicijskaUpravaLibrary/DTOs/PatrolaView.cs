namespace PolicijskaUpravaLibrary.DTOs {
	public class PatrolaView {


		#region Properties

		public virtual int RedniBroj { get; set; }
		public virtual string RegOznakaVozila { get; set; }
		public virtual int SefId { get; set; }
		public virtual string SefImeIPrezime { get; set; }
		public virtual int PomocnikId { get; set; }
		public virtual string PomocnikImeIPrezime { get; set; }

		#endregion

		#region Constructors

		public PatrolaView() { }

		public PatrolaView(Patrola p) { 
			
			RedniBroj = p.RedniBroj;

			RegOznakaVozila = p.DuziVozilo.RegOznaka;

			SefId = p.SefId.Id;
			SefImeIPrezime = p.SefId.Ime + " " + p.SefId.Prezime;

			PomocnikId = p.PomocnikId.Id;
			PomocnikImeIPrezime = p.PomocnikId.Ime + " " + p.PomocnikId.Prezime;
		}

		#endregion

		public override string ToString() {
			return "Redni broj: " + RedniBroj
				+ "\nRegistarska oznaka vozila: " + RegOznakaVozila
				+ "\nSef: [" + SefId + "] " + SefImeIPrezime
				+ "\nPomocnik: [" + PomocnikId + "] " + PomocnikImeIPrezime;
		}
	}
}