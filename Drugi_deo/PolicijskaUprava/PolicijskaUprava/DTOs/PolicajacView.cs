using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.DTOs {
	public class PolicajacView {

		public virtual int Id { get; set; }
		public virtual string Ime { get; set; }
		public virtual string ImeRoditelja { get; set; }
		public virtual string Prezime { get; set; }
		public virtual DateTime DatumRodjenja { get; set; }
		public virtual string JMBG { get; set; }
		public virtual string Adresa { get; set; }
		public virtual DateTime DatumPrijemaUSluzbu { get; set; }
		public virtual int StanicaId { get; set; }
		public virtual string StanicaNaziv { get; set; }
		public virtual int SefujeStanicomId { get; set; }
		public virtual string SefujeStanicomNaziv { get; set; }
		public virtual int ZamenikStaniceId { get; set; }
		public virtual string ZamenikStaniceNaziv { get; set; }
		public virtual string Tip { get; set; }

		public PolicajacView() {
			Ime = string.Empty;
			Prezime = string.Empty;
			ImeRoditelja = string.Empty;
			JMBG = string.Empty;
			Adresa = string.Empty;
			StanicaId = -1;
			StanicaNaziv = null;
			SefujeStanicomId = -1;
			SefujeStanicomNaziv = null;
			ZamenikStaniceId = -1;
			ZamenikStaniceNaziv = null;
		}
		public PolicajacView(int id, string ime, string imeRoditelja, string prezime, DateTime datumRodjenja,
							string jmbg, string adresa, DateTime datumPrijemaUSluzbu, PolicijskaStanicaView stanica,
							PolicijskaStanicaView sefuje, PolicijskaStanicaView zamenik, string tip) {
			Id = id;
			Ime = ime;
			ImeRoditelja = imeRoditelja;
			Prezime = prezime;
			DatumRodjenja = datumRodjenja;
			JMBG = jmbg;
			Adresa = adresa;
			DatumPrijemaUSluzbu = datumPrijemaUSluzbu;
			StanicaId = stanica.Id;
			StanicaNaziv = stanica.Naziv;
			SefujeStanicomId = sefuje.Id;
			SefujeStanicomNaziv = sefuje.Naziv;
			ZamenikStaniceId = zamenik.Id;
			ZamenikStaniceNaziv = zamenik.Naziv;
			Tip = tip;
		}
	}
}
