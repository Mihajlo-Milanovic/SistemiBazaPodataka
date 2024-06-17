using PolicijskaUpravaLibrary.Entiteti;

namespace PolicijskaUpravaLibrary.DTOs {
	public class PatrolaView {


		#region Properties

		public virtual int RedniBroj { get; set; }
		public virtual VoziloView Vozilo { get; set; }
		public virtual PatrolniPolicajacView Sef { get; set; }
		public virtual PatrolniPolicajacView Pomocnik { get; set; }

		#endregion

		#region Constructors

		public PatrolaView() { }

		public PatrolaView(Patrola p) {

			RedniBroj = p.RedniBroj;

			Vozilo = new VoziloView(p.DuziVozilo);

			Sef = new PatrolniPolicajacView(p.Sef);

			Pomocnik = new PatrolniPolicajacView(p.Pomocnik);

		}

		#endregion

		public override string ToString() {
			return "Redni broj: " + RedniBroj
				+ "\nRegistarska oznaka vozila: " + Vozilo.RegOznaka
				+ "\nSef: [" + Sef.Id + "] " + Sef.Ime + ' ' + Sef.Prezime
				+ "\nPomocnik: [" + Pomocnik.Id + "] " + Pomocnik.Ime + ' ' + Pomocnik.Prezime;
		}


		public Patrola ToPatrola() {

			return new Patrola() { 
				RedniBroj = this.RedniBroj,
				DuziVozilo = this.Vozilo.ToVozilo(),
				Pomocnik = this.Pomocnik.ToPatrolniPolicajac(),
				Sef = this.Sef.ToPatrolniPolicajac()
			};
		}
	}
}