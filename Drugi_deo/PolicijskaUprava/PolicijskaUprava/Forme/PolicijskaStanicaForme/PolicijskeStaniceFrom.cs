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

        private void btnDodajPolicijskeStanice_Click(object sender, EventArgs e)
        {
            DodajStanicuForma DSF = new DodajStanicuForma();
            DSF.ShowDialog();
            PopuniTabelu();

        }

        private void btnObrisiPolicijskuStanicu_Click(object sender, EventArgs e)
        {
            
            if (ListeStanice.SelectedItems.Count > 0)
            {
               
                // Uzmete prvu označenu vrstu
                ListViewItem selectedItem = ListeStanice.SelectedItems[0];

                // Pretpostavimo da je ID kolona prva kolona (indeks 0)
                int id = Int32.Parse(selectedItem.SubItems[0].Text);
                string poruka = $"Da li ste sigurni da zelite da obrisete policijsku stanicu sa ID-em: {id}?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if(result == DialogResult.OK)
                DTOManager.ObrisiPolicistkuStanicuID(id);
                PopuniTabelu();
            }
            else
            {
                MessageBox.Show("Mora da se selektuje neka policijska stanica!");
                return;
            }
        }
    }
}
