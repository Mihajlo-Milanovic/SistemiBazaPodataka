﻿namespace PolicijskaUprava.DTOs {

	public class TehnickoLiceView {

		#region Properties

		public virtual int Id { get; set; }
		public virtual string Ime { get; set; }
		public virtual string Prezime { get; set; }

		#endregion


		#region Constructors

		public TehnickoLiceView() { }

		public TehnickoLiceView(TehnickoLice t) {
			Id = t.Id;
			Ime = t.Ime;
			Prezime = t.Prezime;
		}

		#endregion




	}
}
