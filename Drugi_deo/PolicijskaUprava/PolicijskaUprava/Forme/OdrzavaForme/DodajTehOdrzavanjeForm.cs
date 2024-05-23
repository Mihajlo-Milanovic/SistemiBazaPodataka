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

	public partial class DodajTehOdrzavanjeForm : Form {

		AlarmniSistemView a;
		OdrzavaView o;
		TehnickoLiceView t;

		public DodajTehOdrzavanjeForm(int tehId) {
			InitializeComponent();
			t = new();
			t.Id = tehId;
		}

		private void btnDodaj_Click(object sender, EventArgs e) {

			if (a != null) {

				o = new();
				o.AlarmniSistemId = a.Id;
				o.TehnickoLiceId = t.Id;
				o.Pocetak = dtpPocetak.Value;
				o.Kraj = dtpKraj.Value;

				if (DTOManager.dodajOdrzava(o))
					MessageBox.Show("Uspesno dodato odrzavanje alarmnog sistema ");
			}
		}

		private void btnIzborAS_Click(object sender, EventArgs e) {

			a = new();
			a.Id = -1;

			SpisakAlarmnihSistemaForm ssas = new(a);
			ssas.ShowDialog();

			if(a.Id > 0)
				btnIzborAS.Text = a.Id.ToString();
		}
	}
}
