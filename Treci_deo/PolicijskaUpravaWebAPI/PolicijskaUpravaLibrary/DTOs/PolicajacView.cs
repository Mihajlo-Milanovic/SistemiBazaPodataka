using PolicijskaUpravaLibrary.Entiteti;

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

		public virtual TipPolicajca Tip { get; set; }

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

			switch (p.Tip) {
				case "POLICAJAC ZA VANREDNE SITUACIJE":
				this.Tip = TipPolicajca.ZaVanredneSituacije; 
				break;
				case "RADNIK U UPRAVI":
				this.Tip = TipPolicajca.RadikUUpravi;
				break;
				case "SKOLSKI POLICAJAC":
				this.Tip = TipPolicajca.Skolski;
				break;
				case "PATROLNI POLICAJAC":
				this.Tip = TipPolicajca.Patrolni;
				break;
				default://case "POLICAJAC POZORNIK":
				this.Tip = TipPolicajca.Pozornik;
				break;
			}

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

		internal Policajac ToPolicajac() {
			
			
			return new Policajac() {

				Id = this.Id,
				Adresa = this.Adresa,
				DatumPrijemaUSluzbu = this.DatumPrijemaUSluzbu,
				DatumRodjenja = this.DatumRodjenja,
				Ime = this.Ime,
				Prezime = this.Prezime,
				ImeRoditelja = this.ImeRoditelja,
				JMBG = this.JMBG,
				Tip = this.VratiTip(),

				SefujeStanicom = this.SefujeStanicom?.ToPolicijskaStanica(),
				Stanica = this.RadiUStanici?.ToPolicijskaStanica(),
				ZamenikStanice = this.ZamenikStanice?.ToPolicijskaStanica()
			};
		}

		public virtual string VratiTip() {

			switch (this.Tip) {
				case TipPolicajca.Patrolni:
				return "PATROLNI POLICAJAC";
				case TipPolicajca.ZaVanredneSituacije:
				return "POLICAJAC ZA VANREDNE SITUACIJE";
				case TipPolicajca.Skolski:
				return "SKOLSKI POLICAJAC";
				case TipPolicajca.RadikUUpravi:
				return "RADNIK U UPRAVI";
				default://case TipPolicajca.Pozornik:
				return "POLICAJAC POZORNIK";
			}
		}
	}

	public enum TipPolicajca { 
	
		Patrolni, 
		Pozornik,
		RadikUUpravi,
		Skolski,
		ZaVanredneSituacije,
		
	}
}
