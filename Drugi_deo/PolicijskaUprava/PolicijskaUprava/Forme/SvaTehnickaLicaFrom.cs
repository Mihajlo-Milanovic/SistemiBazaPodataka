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
    public partial class SvaTehnickaLicaFrom : Form
    {
        public SvaTehnickaLicaFrom()
        {
            InitializeComponent();
        }

        private void btnObrisiTehnickaLica_Click(object sender, EventArgs e)
        {
            if (this.lvLista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite tehnicko lice koga zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete tehnicko lice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                //DTOManager.obrisiRadnikaIzSistema(idZaposleni);
                MessageBox.Show("Brisanje tehnickog lica je uspesno obavljeno!");
                //this.popuniPodacima();
            }
        }
    }
}
