namespace PolicijskaUprava.DTOs {
	public class ObjekatView {

		#region Properties

		public virtual int Id { get; set; }
		public virtual string Tip { get; set; }
		public virtual string Adresa { get; set; }
		public virtual int Povrsina { get; set; }
		public virtual string KontaktIme { get; set; }
		public virtual string KontaktPrezime { get; set; }

		public virtual int PolicijskaStanicaId { get; set; }
		public virtual string PolicijskaStanicaNaziv { get; set; }

		#endregion

		#region Constructors

		public ObjekatView() { }

		public ObjekatView(Objekat o) {

			Id = o.Id;
			Tip = o.Tip;
			Adresa = o.Adresa;
			Povrsina = o.Povrsina;
			KontaktIme = o.KontaktIme;
			KontaktPrezime = o.KontaktPrezime;

			if (o.PolicijskaStanica != null) {
				PolicijskaStanicaId = o.PolicijskaStanica.Id;
				PolicijskaStanicaNaziv = o.PolicijskaStanica.Naziv;
			}
			else {
				PolicijskaStanicaId = -1;
				PolicijskaStanicaNaziv = null;
			}
		}
		public ObjekatView(int id, string tip, string adresa, int povrsina, string kontaktIme, string kontaktPrezime, int policijskaStanicaId, string policijskaStanicaNaziv)
        {
            Id = id;
            Tip = tip;
            Adresa = adresa;
            Povrsina = povrsina;
            KontaktIme = kontaktIme;
            KontaktPrezime = kontaktPrezime;
            PolicijskaStanicaId = policijskaStanicaId;
            PolicijskaStanicaNaziv = policijskaStanicaNaziv;
        }


        #endregion

    }
}
