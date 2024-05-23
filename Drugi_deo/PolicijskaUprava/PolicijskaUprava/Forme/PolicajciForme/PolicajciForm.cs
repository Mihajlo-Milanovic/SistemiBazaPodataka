using PolicijskaUprava.Entiteti;
using PolicijskaUprava.Forme.UnapredjenjeForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme
{
    public partial class PolicajciForm : Form
    {
        public static List<PolicajacView> policajci;
        public PolicajciForm()
        {
            InitializeComponent();
            PopuniTabelu();
        }

        public void PopuniTabelu()
        {
            btnUnapredjenja.Enabled = false;
            btnObrazovanje.Enabled = false; 
            ListaPolicajaca.Items.Clear();
            policajci = DTOManager.vratiSvePolicajce();

            foreach (var p in policajci)
            {
                ListViewItem item = new ListViewItem(new string[] {p.Id.ToString(), p.Ime, p.ImeRoditelja, p.Prezime, p.JMBG, p.DatumRodjenja.ToShortDateString(), p.Adresa,
                        p.DatumPrijemaUSluzbu.ToShortDateString(), p.StanicaNaziv, p.SefujeStanicomNaziv,p.ZamenikStaniceNaziv, p.Tip});
                ListaPolicajaca.Items.Add(item);

            }
            ListaPolicajaca.Refresh();
        }

        private void btnObrisiPolicajca_Click_1(object sender, EventArgs e)
        {
            if (ListaPolicajaca.SelectedItems.Count > 0)
            {

                // Uzmete prvu označenu vrstu
                ListViewItem selectedItem = ListaPolicajaca.SelectedItems[0];

                // Pretpostavimo da je ID kolona prva kolona (indeks 0)
                int id = Int32.Parse(selectedItem.SubItems[0].Text);
                string poruka = $"Da li ste sigurni da zelite da obrisete policajca sa ID-em: {id}?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                    DTOManager.ObrisiPolicajcaID(id);
                PopuniTabelu();
            }
            else
            {
                MessageBox.Show("Mora da se selektuje neki policajac!");
                return;
            }
        }

        #region UnapredjenjeBtn
        private void btnUnapredjenja_Click(object sender, EventArgs e)
        {
            if (ListaPolicajaca.SelectedItems.Count == 1)
                new UnapredjenjeForm(Int32.Parse(ListaPolicajaca.SelectedItems[0].SubItems[0].Text)).ShowDialog();

        }
        private void ListaPolicajaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaPolicajaca.SelectedItems.Count == 1)
            {
                btnObrazovanje.Enabled = true;
                btnUnapredjenja.Enabled = true;
            }
            else
            {
                btnObrazovanje.Enabled = false;
                btnUnapredjenja.Enabled = false;
            }
        }
        #endregion

        #region ObrazovanjeBtn
        private void btnObrazovanje_Click(object sender, EventArgs e)
        {
            if (ListaPolicajaca.SelectedItems.Count == 1)
                new ObrazovanjeForm(Int32.Parse(ListaPolicajaca.SelectedItems[0].SubItems[0].Text)).ShowDialog();
        }
        #endregion
    }
}