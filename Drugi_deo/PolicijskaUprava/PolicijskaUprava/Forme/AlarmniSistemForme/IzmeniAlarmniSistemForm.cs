using PolicijskaUprava.Entiteti;
using System.CodeDom;
using System.Drawing;

namespace PolicijskaUprava.Forme.AlarmniSistemForme {
	public partial class IzmeniAlarmniSistemForm : Form {

		AlarmniSistem alarmniSistem;
		List<string> vrsteSistema;
		List<string> ASTypes;
		List<Point> gbxLocations;

		public IzmeniAlarmniSistemForm(AlarmniSistem a) {
			InitializeComponent();

			alarmniSistem = a;
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
						"DETEKCIJE POKRETA",
						"DETEKCIJE TOPLOTNOG ODRAZA"];

			bs.DataSource = vrsteSistema;

			cbxTip.DataSource = vrsteSistema;

			gbxLocations = new List<Point>();
			gbxLocations.Add(new Point(10, 240));
			gbxLocations.Add(new Point(200, 600));
			gbxLocations.Add(new Point(200, 800));
			gbxLocations.Add(new Point(200, 1000));

			if(alarmniSistem.GetType()  == typeof(UltrazvucniAS)) { 
				cbxTip.SelectedItem = vrsteSistema[0];
			}
			else if(alarmniSistem.GetType() == typeof(ASDetekcijePokreta)) {
				cbxTip.SelectedItem = vrsteSistema[1];
			}else if (alarmniSistem.GetType() == typeof(ASDetekcijeToplotnogOdraza)) {
				cbxTip.SelectedItem = vrsteSistema[2];
			}

			setStartingValues();

		}

		private void setStartingValues() {


			tbxSerijskiBroj.Text = alarmniSistem.SerijskiBroj;
			tbxProizvodjac.Text = alarmniSistem.Proizvodjac;
			tbxModel.Text = alarmniSistem.Model;
			dtpGodinaProizvodnje.Value = alarmniSistem.GodinaProizvodnje;
			dtpDatumInstalacije.Value = alarmniSistem.DatumInstalacije;
			dtpDatumPoslednjegAtesta.Value = alarmniSistem.DatumPoslednjegAtesta;
			dtpDatumPoslednjegServisiranja.Value = alarmniSistem.DatumPoslednjegServisiranja;
			tbxOpisOtklonjenogKvara.Text = alarmniSistem.OpisOtklonjenogKvara;

			if (alarmniSistem.GetType() == typeof(UltrazvucniAS)) {

				cbxTip.SelectedIndex = 0;
				alarmniSistem.Tip = ASTypes[0];
				setUltrazvuciASControls();

			}
			else if (alarmniSistem.GetType() == typeof(ASDetekcijePokreta)) {

				cbxTip.SelectedIndex = 1;
				alarmniSistem.Tip = ASTypes[1];
				setASDetekcijePokretaControls();
			}
			else {
				cbxTip.SelectedIndex = 2;
				alarmniSistem.Tip = ASTypes[2];
				setASDetekcijeToplotnogOdrazaControls();
			}

		}

		private void btnIzmeniAlarmniSistem_Click(object sender, EventArgs e) {


			alarmniSistem.SerijskiBroj = tbxSerijskiBroj.Text;
			alarmniSistem.Proizvodjac = tbxProizvodjac.Text;
			alarmniSistem.Model = tbxModel.Text;
			alarmniSistem.GodinaProizvodnje = dtpGodinaProizvodnje.Value;
			alarmniSistem.DatumInstalacije = dtpDatumInstalacije.Value;
			alarmniSistem.DatumPoslednjegAtesta = dtpDatumPoslednjegAtesta.Value;
			alarmniSistem.DatumPoslednjegServisiranja = dtpDatumPoslednjegServisiranja.Value;
			alarmniSistem.OpisOtklonjenogKvara = tbxOpisOtklonjenogKvara.Text;

			if (cbxTip.SelectedIndex == 0) {

				setUltrazvuciAS();
			}
			else if (cbxTip.SelectedIndex == 1) {
	
				setASDetekcijePokreta();
			}
			else {

				setASDetekcijeToplotnogOdraza();
			}

			if (DTOManager.izmeniAlarmniSistem(alarmniSistem))
				MessageBox.Show("Alarmni sitem sa ID: " + alarmniSistem.Id + " uspesno je izmenjen.");
		}



		private void setUltrazvuciAS() {

			((UltrazvucniAS)alarmniSistem).GornjaGranica = (int)numGornjaGranica.Value;
			((UltrazvucniAS)alarmniSistem).DonjaGranica = (int)numDonjaGranica.Value;
		}

		private void setASDetekcijePokreta() {

			((ASDetekcijePokreta)alarmniSistem).Osetljivost = tbxOsetljivost.Text;
		}

		private void setASDetekcijeToplotnogOdraza() {

			((ASDetekcijeToplotnogOdraza)alarmniSistem).HorRezIcKamere = (int)numHorRezIcKamere.Value;
			((ASDetekcijeToplotnogOdraza)alarmniSistem).VerRezIcKamere = (int)numVerRezIcKamere.Value;
		}



		private void setUltrazvuciASControls() {

			numGornjaGranica.Value = ((UltrazvucniAS)alarmniSistem).GornjaGranica;
			numDonjaGranica.Value = ((UltrazvucniAS)alarmniSistem).DonjaGranica;
		}

		private void setASDetekcijePokretaControls() {

			tbxOsetljivost.Text = ((ASDetekcijePokreta)alarmniSistem).Osetljivost;
		}

		private void setASDetekcijeToplotnogOdrazaControls() {

			numHorRezIcKamere.Value = ((ASDetekcijeToplotnogOdraza)alarmniSistem).HorRezIcKamere;
			numVerRezIcKamere.Value = ((ASDetekcijeToplotnogOdraza)alarmniSistem).VerRezIcKamere;
		}
	}
}
