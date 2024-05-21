using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.TehnickoLiceForme {
	public partial class IzmeniTehnickoLiceForm : Form {

		TehnickoLice tl;

		public IzmeniTehnickoLiceForm(TehnickoLice t) {
			InitializeComponent();
			tl = t;

			tbxIme.Text = tl.Ime;
			tbxPrezime.Text = tl.Prezime;

		}


		private void btnIzmeniTehnickoLice_Click(object sender, EventArgs e) {

			tl.Ime = tbxIme.Text;
			tl.Prezime = tbxPrezime.Text;


			DTOManager.izmeniTehnickoLice(tl.Ime, tl.Prezime, tl.Id);

			this.Close();
		}
	}
}
