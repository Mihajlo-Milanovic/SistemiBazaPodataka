using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Forme.OdrzavaForme {

	public partial class OdrzavaForm : Form {

		delegate List<OdrzavaView> DataSource(int id);
		delegate void loadForm(int id);
		int id;
		DataSource ds;
		loadForm lf;
		BindingSource bs;


		public OdrzavaForm(int tehId, int ASId, bool izUglaTehnickogLica) {
			InitializeComponent();
			bs = new();

			if (izUglaTehnickogLica == true) {

				this.id = tehId;
				lf = tehAddOdrzavanje;
				ds = DTOManager.vratiIstorijuOdrzavanjaZaTehnickoLice;
			}
			else {

				this.id = ASId;
				lf = ASAddOdrzavanje;
				ds = DTOManager.vratiIstorijuOdrzavanjaZaAlarmniSistem;
			}

			bs.DataSource = ds(id);
			dgvOdrzava.DataSource = bs;
		}

		private void btnDodaj_Click(object sender, EventArgs e) {

			this.lf(id);
		}

		private void btnObrisi_Click(object sender, EventArgs e) {

			int rIndex = dgvOdrzava.SelectedCells[0].RowIndex;

			Odrzava o = new();
			o.Id = new();
			o.Id.Tehnicar = new();
			o.Id.AlarmniSistem = new();

			o.Id.Tehnicar.Id = (int)dgvOdrzava.Rows[rIndex].Cells[0].Value;
			o.Id.AlarmniSistem.Id = (int)dgvOdrzava.Rows[rIndex].Cells[1].Value;
			o.Id.PocetniDatum = (DateTime)dgvOdrzava.Rows[rIndex].Cells[2].Value;

			if(DTOManager.obrisiOdrzava(o))
				bs.RemoveAt(rIndex); ;
		}

		private void tehAddOdrzavanje(int id) {

			new DodajTehOdrzavanjeForm(id).ShowDialog();

			dgvOdrzava.DataSource = ds(id);
		}

		private void ASAddOdrzavanje(int id) {

			new DodajASOdrzavanjeForm(id).ShowDialog();

			dgvOdrzava.DataSource = ds(id);
		}


	}
}
