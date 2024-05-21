namespace PolicijskaUprava.Forme
{
    public partial class PolicijskeStaniceFrom : Form
    {
        public static List<PolicijskaStanicaView> Stanice;

        public PolicijskeStaniceFrom()
        {
            InitializeComponent();
            PopuniTabelu();
        }

        public void PopuniTabelu()
        {
            ListeStanice.Items.Clear();
            Stanice = DTOManager.vratiSvePolicijskeStanice();

            foreach (var s in Stanice)
            {
                ListViewItem item = new ListViewItem(new string[] { s.Id.ToString(), s.Naziv, s.Opstina, s.Adresa, s.DatumOsnivanja.ToShortDateString(), s.BrojVozila.ToString() });
                ListeStanice.Items.Add(item);
            }
            ListeStanice.Refresh();
        }

        private void btnDodajPolicijskeStenice_Click(object sender, EventArgs e)
        {
            DodajStanicuForma DSF = new DodajStanicuForma();
            DSF.ShowDialog();
        }
    }
}
