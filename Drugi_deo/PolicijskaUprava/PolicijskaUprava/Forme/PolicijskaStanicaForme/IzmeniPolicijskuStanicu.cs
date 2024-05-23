

namespace PolicijskaUprava.Forme.PolicijskaStanicaForme
{
    public partial class IzmeniPolicijskuStanicu : Form
    {

        PolicijskaStanicaView Stanica;
        public IzmeniPolicijskuStanicu()
        {
            InitializeComponent();
        }

        public IzmeniPolicijskuStanicu(PolicijskaStanicaView stanica)
        {
            InitializeComponent();
            Stanica = stanica;
            popuniPodatke();
        }

        private void popuniPodatke()
        {
            txbNaziv.Text = Stanica.Naziv;
            tbxOpstina.Text = Stanica.Opstina;
            tbxAdresa.Text = Stanica.Adresa;
            dtpDatumOsnivanja.Value = Stanica.DatumOsnivanja;
            nudBrojVozila.Value = Stanica.BrojVozila;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (txbNaziv.Text == "" || tbxOpstina.Text == "" || tbxAdresa.Text == "" || (int)(nudBrojVozila.Value) == 0)
            {
                MessageBox.Show("Svi parametri su neobhodni !!!!");
                return;
            }
            string poruka = $"Da li zelite da izmenite policijsku stanicu sa ID-em {Stanica.Id}?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                int kurac = 0;
                PolicijskaStanica stanica = new PolicijskaStanica(Stanica.Id, txbNaziv.Text, tbxOpstina.Text, tbxAdresa.Text,
                    dtpDatumOsnivanja.Value, (int)(nudBrojVozila.Value), null, null);

                DTOManager.DodajPolicijskuStanicu(stanica);
                this.Close();
            }
            
        }
    }
}
