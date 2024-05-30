using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.PolicijskaStanicaForme {
	public partial class AzurirajPolicajcaStaniciForm : Form {

		PolicajacView policajac;
		//int pocetnaPozicija,
		int pozicija;

		public AzurirajPolicajcaStaniciForm(int policajacId) {
			InitializeComponent();

			lblPolicajac.Text = policajacId.ToString();

			policajac = DTOManager.vratiPolicajca(policajacId);

			if (policajac.SefujeStanicomId > 0) {
				rbtnSef.Checked = true;
				//pocetnaPozicija = 1;
			}
			else if (policajac.ZamenikStaniceId > 0) {
				rbtnZamenik.Checked = true;
				//pocetnaPozicija = 2;
			}
			else {
				rbtnZaposleni.Checked = true;
				//pocetnaPozicija = 0;
			}

		}

		private void button1_Click(object sender, EventArgs e) {

			if (DTOManager.izmeniZaposlenjePolicajca(policajac.Id, policajac.StanicaId, pozicija))
				MessageBox.Show("Uspesno izmenjen policajac sa ID: " + policajac.Id);
		}

		private void rbtnZaposleni_CheckedChanged(object sender, EventArgs e) {

			if (rbtnSef.Checked == true) {
				
				pozicija = 1;
			}
			else if (rbtnZamenik.Checked == true) {
				
				pozicija = 2;
			}
			else {
				pozicija = 0;
			}
		}
	}
}
