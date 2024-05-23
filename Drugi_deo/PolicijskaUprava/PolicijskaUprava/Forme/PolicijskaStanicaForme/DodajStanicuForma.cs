

namespace PolicijskaUprava.Forme.PolicijskaStanicaForme
{
    public partial class DodajStanicuForma : Form
    {
        public DodajStanicuForma()
        {
            InitializeComponent();
        }
        public void DodajPolicajcaForm_Load()
        {

        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if(txbNaziv.Text == "" || tbxOpstina.Text == "" || tbxAdresa.Text == "" || (int)(nudBrojVozila.Value) == 0)
            {
                MessageBox.Show("Svi parametri su neobhodni !!!!");
                return;
            }
            string poruka = "Da li zelite da dodate novu policijsku stanicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                int kurac = 0;
                PolicijskaStanica stanica = new PolicijskaStanica(kurac , txbNaziv.Text, tbxOpstina.Text, tbxAdresa.Text,
                    dtpDatumOsnivanja.Value, (int)(nudBrojVozila.Value), null, null);

                DTOManager.DodajPolicijskuStanicu(stanica);

                this.Close();
            }
           
        }
    }
}
