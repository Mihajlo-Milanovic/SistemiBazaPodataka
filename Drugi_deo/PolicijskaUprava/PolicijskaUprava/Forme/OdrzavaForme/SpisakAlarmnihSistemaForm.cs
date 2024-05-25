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
