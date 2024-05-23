using PolicijskaUprava.Forme.PolicajciForme;

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
            lvListeStanice.Items.Clear();
            Stanice = DTOManager.vratiSvePolicijskeStanice();

            foreach (var s in Stanice)
            {
                ListViewItem item = new ListViewItem(new string[] { s.Id.ToString(), s.Naziv, s.Opstina, s.Adresa, s.DatumOsnivanja.ToShortDateString(), s.BrojVozila.ToString() });
                lvListeStanice.Items.Add(item);
            }
            lvListeStanice.Refresh();
        }

        private void btnDodajPolicijskeStanice_Click(object sender, EventArgs e)
        {
            DodajStanicuForma DSF = new DodajStanicuForma();
            DSF.ShowDialog();
            PopuniTabelu();

        }

        private void btnObrisiPolicijskuStanicu_Click(object sender, EventArgs e)
        {

            if (lvListeStanice.SelectedItems.Count > 0)
            {

                // Uzmete prvu označenu vrstu
                ListViewItem selectedItem = lvListeStanice.SelectedItems[0];

                // Pretpostavimo da je ID kolona prva kolona (indeks 0)
                int id = Int32.Parse(selectedItem.SubItems[0].Text);
                string poruka = $"Da li ste sigurni da zelite da obrisete policijsku stanicu sa ID-em: {id}?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                    DTOManager.ObrisiPolicistkuStanicuID(id);
                PopuniTabelu();
            }
            else
            {
                MessageBox.Show("Mora da se selektuje neka policijska stanica!");
                return;
            }
        }

        private void btnIzmeniStanicu_Click(object sender, EventArgs e)
        {
            if (lvListeStanice.SelectedItems.Count > 0)
            {

                // Uzmete prvu označenu vrstu
                ListViewItem selectedItem = lvListeStanice.SelectedItems[0];

                PolicijskaStanicaView stanica = new PolicijskaStanicaView
                {
                    Id = Convert.ToInt32(selectedItem.SubItems[0].Text),
                    Naziv = selectedItem.SubItems[1].Text,
                    Opstina = selectedItem.SubItems[2].Text,
                    Adresa = selectedItem.SubItems[3].Text,
                    DatumOsnivanja = DateTime.Parse(selectedItem.SubItems[4].Text),
                    BrojVozila = Convert.ToInt32(selectedItem.SubItems[5].Text)
                };
                IzmeniPolicijskuStanicu forma = new(stanica);
                forma.ShowDialog();
                PopuniTabelu();
            }
        }

        private void btnDodajPolicajca_Click(object sender, EventArgs e)
        {
            if (lvListeStanice.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = lvListeStanice.SelectedItems[0];

                int IDStanice = Convert.ToInt32(selectedItem.SubItems[0].Text);

                DodajPolicajcaForm forma = new DodajPolicajcaForm(IDStanice);
                forma.ShowDialog();
            }
        }

        private void btnVidiObjekte_Click(object sender, EventArgs e) {

            if (lvListeStanice.SelectedItems.Count == 1) {

                new ObjekatForm(Int32.Parse((lvListeStanice.SelectedItems[0].SubItems[0].Text))).ShowDialog();
            }
            else if (lvListeStanice.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite stanicu !");
            }
            else MessageBox.Show("Izaberite 1 stanicu!");
        }
    }
}
