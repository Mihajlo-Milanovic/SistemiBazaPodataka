using NHibernate.Linq.Visitors.ResultOperatorProcessors;
using PolicijskaUprava.Forme.PolicajciForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme {

    public partial class PocetnaStranicaForm : Form {

        public PocetnaStranicaForm() {
            InitializeComponent();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e) {
            return;
        }

        private void picPolicajskaStanica_Click(object sender, EventArgs e) {
            PolicijskeStaniceFrom PSF = new PolicijskeStaniceFrom();
            PSF.ShowDialog();
        }

        private void btnPolicajac_Click(object sender, EventArgs e) {
            Policajci P = new Policajci();
            P.ShowDialog();
        }

        private void btnObjekat_Click(object sender, EventArgs e) {
            MessageBox.Show("Ovde ide forma ObjekatFrom...");
        }

        private void btnPatrole_Click(object sender, EventArgs e) {
            MessageBox.Show("Ovde ide forma PatroleFrom...");
        }

        private void btnVozilo_Click(object sender, EventArgs e) {
           new VozilaForm().ShowDialog();
        }

        private void btnAlarmniSistem_Click(object sender, EventArgs e) {

            SviAlarmniSistemiForm SASF = new SviAlarmniSistemiForm();
            SASF.ShowDialog();
        }

        private void btnTehnickoLice_Click(object sender, EventArgs e) {
            SvaTehnickaLicaForm STLF = new SvaTehnickaLicaForm();
            STLF.ShowDialog();
        }
    }
}
