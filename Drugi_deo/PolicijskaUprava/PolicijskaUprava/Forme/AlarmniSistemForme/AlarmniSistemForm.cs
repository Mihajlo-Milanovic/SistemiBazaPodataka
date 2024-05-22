using NHibernate.Criterion;

namespace PolicijskaUprava.Forme.AlarmniSistemForme {
	public partial class AlarmniSistemForm : Form {

		int objekatId;

		public AlarmniSistemForm(int objekatId) {
			InitializeComponent();


			this.objekatId = objekatId;
			bsAS.DataSource = DTOManager.vratiSveAlarmneSistemeZaObjekat(objekatId);
			dataGridView1.DataSource = bsAS;
		}

		private void btnDodajAS_Click(object sender, EventArgs e) {


			DodajAlarmniSistemForm dasForm = new(objekatId);

			dasForm.ShowDialog();

			bsAS.DataSource = DTOManager.vratiSveAlarmneSistemeZaObjekat(objekatId);

		}

		private void btnObrisiAS_Click(object sender, EventArgs e) {

			int rIndex = dataGridView1.SelectedCells[0].RowIndex;
			int id = (int)dataGridView1.Rows[rIndex].Cells[0].Value;

			UltrazvucniAS a = new();
			a.Id = id;

			if (DTOManager.obrisiAlarmniSistem(a))
				bsAS.RemoveAt(rIndex);

		}

		private void btnIzmeniAS_Click(object sender, EventArgs e) {


			AlarmniSistem a = new();

			int rIndex = dataGridView1.SelectedCells[0].RowIndex;

			a = DTOManager.vratiAlarmniSistem((int)dataGridView1.Rows[rIndex].Cells[0].Value);

			if (a != null) {

				IzmeniAlarmniSistemForm itlForma = new(a);
				itlForma.ShowDialog();

				bsAS.RemoveAt(rIndex);
				bsAS.Add(new AlarmniSistemView(a));
			}
			else
				MessageBox.Show("Doslo je do greske pri ucitavanju alarmnog sistema!!!");

			
		}
	}
}
