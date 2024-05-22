using System.Drawing;
using System.Runtime.InteropServices.JavaScript;

namespace PolicijskaUprava.Forme.AlarmniSistemForme {
	public partial class DodajAlarmniSistemForm : Form {
		List<string> vrsteSistema, ASTypes;
		List<Point> gbxLocations;
		int objekatId;

		public DodajAlarmniSistemForm(int objekatId) {
			InitializeComponent();

			this.objekatId = objekatId;

			init();
			changeActiveGBX();
		}

		private void cbxTip_SelectedIndexChanged(object sender, EventArgs e) {

			changeActiveGBX();
		}

		private void changeActiveGBX() {
			switch (cbxTip.SelectedIndex) {

				case 0:
				gbxUltrazvucni.Location = gbxLocations[0];
				gbxUltrazvucni.Visible = true;
				gbxUltrazvucni.Enabled = true;

				gbxDetekcijePokreta.Location = gbxLocations[2];
				gbxDetekcijePokreta.Visible = false;
				gbxDetekcijePokreta.Enabled = false;

				gbxDetekcijeToplotnogOdraza.Location = gbxLocations[3];
				gbxDetekcijeToplotnogOdraza.Visible = false;
				gbxDetekcijeToplotnogOdraza.Enabled = false;

				break;

				case 1:
				gbxUltrazvucni.Location = gbxLocations[1];
				gbxUltrazvucni.Visible = false;
				gbxUltrazvucni.Enabled = false;

				gbxDetekcijePokreta.Location = gbxLocations[0];
				gbxDetekcijePokreta.Visible = true;
				gbxDetekcijePokreta.Enabled = true;

				gbxDetekcijeToplotnogOdraza.Location = gbxLocations[3];
				gbxDetekcijeToplotnogOdraza.Visible = false;
				gbxDetekcijeToplotnogOdraza.Enabled = false;
				break;

				case 2:
				gbxUltrazvucni.Location = gbxLocations[1];
				gbxUltrazvucni.Visible = false;
				gbxUltrazvucni.Enabled = false;

				gbxDetekcijePokreta.Location = gbxLocations[2];
				gbxDetekcijePokreta.Visible = false;
				gbxDetekcijePokreta.Enabled = false;

				gbxDetekcijeToplotnogOdraza.Location = gbxLocations[0];
				gbxDetekcijeToplotnogOdraza.Visible = true;
				gbxDetekcijeToplotnogOdraza.Enabled = true;
				break;

			}
		}

		private void init() {

			BindingSource bs = new BindingSource();
			vrsteSistema = ["Ultazvucni",
							"Detekcije pokreta",
							"Detekcije toplotnog odraza"];

			ASTypes = ["ULTRAZVUCNI",
						"DETEKCIJAE POKRETA",
						"DETEKCIJA TOPLOTNOG ODRAZA"];

			bs.DataSource = vrsteSistema;
			cbxTip.DataSource = vrsteSistema;

			gbxLocations = new List<Point>();
			gbxLocations.Add(new Point(10, 240));
			gbxLocations.Add(new Point(200, 600));
			gbxLocations.Add(new Point(200, 800));
			gbxLocations.Add(new Point(200, 1000));
		}

		private void btnDodajAlarmniSistem_Click(object sender, EventArgs e) {

			AlarmniSistem a;

			if (cbxTip.SelectedIndex == 0) {

				a = makeUltrazvuciAS();
				a.Tip = ASTypes[0];
			}

			else if (cbxTip.SelectedIndex == 1) {

				a = makeASDetekcijePokreta();
				a.Tip = ASTypes[1];

			}
			else {
				a = makeASDetekcijeToplotnogOdraza();
				a.Tip = ASTypes[2];
			}

			a.SerijskiBroj = tbxSerijskiBroj.Text;
			a.Proizvodjac = tbxProizvodjac.Text;
			a.Model = tbxModel.Text;
			a.GodinaProizvodnje = dtpGodinaProizvodnje.Value;
			a.DatumInstalacije = dtpDatumInstalacije.Value;
			a.DatumPoslednjegAtesta = dtpDatumPoslednjegAtesta.Value;
			a.DatumPoslednjegServisiranja = dtpDatumPoslednjegServisiranja.Value;
			a.OpisOtklonjenogKvara = tbxOpisOtklonjenogKvara.Text;

			a.PripadaObjektu = new();
			a.PripadaObjektu.Id = objekatId;


			if (DTOManager.dodajAlarmniSistem(a))
				MessageBox.Show("Dodat je alarmni sitem:\n\n" + a.ToString());
		}

		private UltrazvucniAS makeUltrazvuciAS() {

			UltrazvucniAS a = new();
			a.GornjaGranica = (int)numGornjaGranica.Value;
			a.DonjaGranica = (int)numDonjaGranica.Value;

			return a;
		}

		private ASDetekcijePokreta makeASDetekcijePokreta() {

			ASDetekcijePokreta a = new();
			a.Osetljivost = tbxOsetljivost.Text;

			return a;
		}

		private ASDetekcijeToplotnogOdraza makeASDetekcijeToplotnogOdraza() {

			ASDetekcijeToplotnogOdraza a = new();
			a.HorRezIcKamere = (int)numHorRezIcKamere.Value;
			a.VerRezIcKamere = (int)numVerRezIcKamere.Value;

			return a;
		}
	}
}
