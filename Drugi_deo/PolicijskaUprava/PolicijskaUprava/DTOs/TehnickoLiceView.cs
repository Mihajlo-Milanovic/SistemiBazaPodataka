namespace PolicijskaUprava.DTOs {

	public class TehnickoLiceView {

		public virtual int Id { get; set; }
		public virtual string Ime { get; set; }
		public virtual string Prezime { get; set; }

		public TehnickoLiceView() { }	

		public TehnickoLiceView(TehnickoLice t) {
			Id = t.Id;
			Ime = t.Ime;
			Prezime = t.Prezime;
		}
	}
}
