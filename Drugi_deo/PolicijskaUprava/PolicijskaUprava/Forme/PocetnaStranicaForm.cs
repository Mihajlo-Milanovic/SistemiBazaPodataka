using PolicijskaUprava.Forme.AlarmniSistemForme;

namespace PolicijskaUprava.Forme {
    public partial class PocetnaStranicaForm : Form {


        public PocetnaStranicaForm() {
            InitializeComponent();
        }

        private void picPolicajskaStanica_Click(object sender, EventArgs e) {
            PolicijskeStaniceFrom PSF = new PolicijskeStaniceFrom();
            PSF.ShowDialog();
        }

        private void btnPolicajac_Click(object sender, EventArgs e) {
            PolicajciForm P = new PolicajciForm();
            P.ShowDialog();
        }

        private void btnPatrole_Click(object sender, EventArgs e) {
            new PatroleForme.PatroleForm().ShowDialog();
        }

        private void btnVozilo_Click(object sender, EventArgs e) {
           new VozilaForm().ShowDialog();
        }

        private void btnTehnickoLice_Click(object sender, EventArgs e) {

            TehnickaLicaForm tlf = new();
            tlf.ShowDialog();
            
        }
    }
}
