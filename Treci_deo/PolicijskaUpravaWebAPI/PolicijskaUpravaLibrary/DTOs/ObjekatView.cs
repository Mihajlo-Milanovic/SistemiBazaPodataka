namespace PolicijskaUpravaLibrary.DTOs {
	public class ObjekatView {

		#region Properties

		public virtual int Id { get; set; }
		public virtual string Tip { get; set; }
		public virtual string Adresa { get; set; }
		public virtual int Povrsina { get; set; }
		public virtual string KontaktIme { get; set; }
		public virtual string KontaktPrezime { get; set; }

		public virtual PolicijskaStanicaView PolicijskaStanica { get; set; }
		//public virtual List<AlarmniSistem> AlarmniSistemi { get; set; }

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
				PolicijskaStanica = new PolicijskaStanicaView(o.PolicijskaStanica);
			}
			else {
				PolicijskaStanica = null;
			}
		}

		public ObjekatView(int id, string tip, string adresa, int povrsina, string kontaktIme, string kontaktPrezime, PolicijskaStanicaView policijskaStanica)
        {
            Id = id;
            Tip = tip;
            Adresa = adresa;
            Povrsina = povrsina;
            KontaktIme = kontaktIme;
            KontaktPrezime = kontaktPrezime;
            PolicijskaStanica = policijskaStanica;
        }


        #endregion

    }
}
