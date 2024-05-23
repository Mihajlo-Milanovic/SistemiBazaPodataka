using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.OdrzavaForme {

	public partial class SpisakAlarmnihSistemaForm : Form {

		AlarmniSistemView alarmniSistem;

		public SpisakAlarmnihSistemaForm(AlarmniSistemView a) {
			InitializeComponent();
			alarmniSistem = a;
			dataGridView1.DataSource = DTOManager.vratiSveAlarmneSisteme();
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {

			alarmniSistem.Id = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
			/*
			//alarmniSistem.SerijskiBroj = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
			//alarmniSistem.Proizvodjac = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
			//alarmniSistem.Model = (string)dataGridView1.SelectedRows[0].Cells[3].Value;
			//alarmniSistem.GodinaProizvodnje = (DateTime)dataGridView1.SelectedRows[0].Cells[4].Value;
			//alarmniSistem.DatumInstalacije = (DateTime)dataGridView1.SelectedRows[0].Cells[5].Value;
			//alarmniSistem.DatumPoslednjegAtesta = (DateTime)dataGridView1.SelectedRows[0].Cells[6].Value;
			//alarmniSistem.DatumPoslednjegServisiranja = (DateTime)dataGridView1.SelectedRows[0].Cells[7].Value;
			//alarmniSistem.OpisOtklonjenogKvara = (string)dataGridView1.SelectedRows[0].Cells[8].Value;

			//if (dataGridView1.SelectedRows[0].Cells[9].Value == "ULTRAZVUCNI") {

			//	alarmniSistem.Tip = (string)dataGridView1.SelectedRows[0].Cells[9].Value;
			//	setUltrazvuciAS();
			//}
			//else if (dataGridView1.SelectedRows[0].Cells[9].Value == "DETEKCIJE POKRETA") {

			//	alarmniSistem.Tip = (string)dataGridView1.SelectedRows[0].Cells[9].Value;
			//	setASDetekcijePokreta();
			//}
			//else {

			//	setASDetekcijeToplotnogOdraza();
			//}
			*/

			this.Close();
		}

		private void setUltrazvuciAS() {

			//((UltrazvucniAS)alarmniSistem).GornjaGranica = (int)numGornjaGranica.Value;
			//((UltrazvucniAS)alarmniSistem).DonjaGranica = (int)numDonjaGranica.Value;
		}

		private void setASDetekcijePokreta() {

			//((ASDetekcijePokreta)alarmniSistem).Osetljivost = tbxOsetljivost.Text;
		}

		private void setASDetekcijeToplotnogOdraza() {

			//((ASDetekcijeToplotnogOdraza)alarmniSistem).HorRezIcKamere = (int)numHorRezIcKamere.Value;
			//((ASDetekcijeToplotnogOdraza)alarmniSistem).VerRezIcKamere = (int)numVerRezIcKamere.Value;
		}
	}

}
