namespace PolicijskaUprava.Forme {

    public partial class PocetnaStranica : Form {

        public PocetnaStranica() {
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
            PolicajciForm P = new PolicajciForm();
            P.ShowDialog();
        }

        private void btnObjekat_Click(object sender, EventArgs e) {
            MessageBox.Show("Ovde ide forma ObjekatFrom...");
        }

        private void btnPatrole_Click(object sender, EventArgs e) {
            MessageBox.Show("Ovde ide forma PatroleFrom...");
        }

        private void btnVozilo_Click(object sender, EventArgs e) {
            MessageBox.Show("Ovde ide forma VozilaFrom...");
        }

        private void btnAlarmniSistem_Click(object sender, EventArgs e) {

            SviAlarmniSistemiFrom SASF = new SviAlarmniSistemiFrom();
            SASF.ShowDialog();
        }

        private void btnTehnickoLice_Click(object sender, EventArgs e) {
            //SvaTehnickaLicaFrom STLF = new SvaTehnickaLicaFrom();
            TehnickaLicaForm STLF = new();
            STLF.ShowDialog();
            
        }
    }
}
