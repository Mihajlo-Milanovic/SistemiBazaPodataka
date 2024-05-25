using PolicijskaUprava.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.PatroleForme {
	public partial class ListaPatrolnihPolicajacaForm : Form {

		PatrolaView pv;
		bool jeSef;

		public ListaPatrolnihPolicajacaForm(PatrolaView pv, bool jeSef) {
			InitializeComponent();
			this.pv = pv;
			this.jeSef = jeSef;
			dataGridView1.DataSource = DTOManager.vratiSvePatrolnePolicajce();
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {

			int rid = dataGridView1.SelectedCells[0].RowIndex;

			if (jeSef) {

				pv.SefId = (int)dataGridView1.Rows[rid].Cells[1].Value;
				pv.SefImeIPrezime = (string)dataGridView1.Rows[rid].Cells[2].Value
					+ " " + (string)dataGridView1.Rows[rid].Cells[4].Value;
			}
			else {
				pv.PomocnikId = (int)dataGridView1.Rows[rid].Cells[1].Value;
				pv.PomocnikImeIPrezime = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value
					+ " " + (string)dataGridView1.Rows[rid].Cells[4].Value;
			}

			this.Close();

		}
	}
}
