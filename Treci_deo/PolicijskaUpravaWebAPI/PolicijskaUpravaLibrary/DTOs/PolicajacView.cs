namespace PolicijskaUpravaLibrary.DTOs {
	public class PolicajacView {

		#region Properties

		public virtual int Id { get; set; }
		public virtual string Ime { get; set; }
		public virtual string ImeRoditelja { get; set; }
		public virtual string Prezime { get; set; }
		public virtual DateTime DatumRodjenja { get; set; }
		public virtual string JMBG { get; set; }
		public virtual string Adresa { get; set; }
		public virtual DateTime DatumPrijemaUSluzbu { get; set; }

		public virtual PolicijskaStanicaView? RadiUStanici { get; set; } = null;
		public virtual PolicijskaStanicaView? SefujeStanicom { get; set; } = null;
		public virtual PolicijskaStanicaView? ZamenikStanice { get; set; } = null;

		public virtual string? Tip { get; set; } = null;

		#endregion

		#region Constructors

		public PolicajacView() {
			Ime = string.Empty;
			Prezime = string.Empty;
			ImeRoditelja = string.Empty;
			JMBG = string.Empty;
			Adresa = string.Empty;
			
		}

		public PolicajacView(Policajac p) {

			Id = p.Id;
			Ime = p.Ime;
			ImeRoditelja = p.ImeRoditelja;
			Prezime = p.Prezime;
			DatumRodjenja = p.DatumRodjenja;
			JMBG = p.JMBG;
			Adresa = p.Adresa;
			DatumPrijemaUSluzbu = p.DatumPrijemaUSluzbu;
			Tip = p.Tip;

			if (p.Stanica != null) {
				RadiUStanici = new PolicijskaStanicaView(p.Stanica);
			}

			if (p.SefujeStanicom != null) {
				SefujeStanicom = new PolicijskaStanicaView(p.SefujeStanicom);
			}

			if (p.ZamenikStanice != null) {
				ZamenikStanice = new PolicijskaStanicaView(p.ZamenikStanice);
			}
		}

		#endregion
	}
}
