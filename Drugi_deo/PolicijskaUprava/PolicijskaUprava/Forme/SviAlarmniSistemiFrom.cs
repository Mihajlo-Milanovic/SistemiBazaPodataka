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
    public partial class SviAlarmniSistemiFrom : Form
    {
        public SviAlarmniSistemiFrom()
        {
            InitializeComponent();
            PopuniTabelu();
        }

        public void PopuniTabelu()
        {
            string[] AS1 = { "123", "1999" };
            string[] AS2 = { "1233", "2000" };
            ListView lista = this.lvLista;
            ListViewItem LVI1 = new ListViewItem(AS1);
            ListViewItem LVI2 = new ListViewItem(AS2);
            lista.Items.Add(LVI1);
            lista.Items.Add(LVI2);
  
        }

        private void btnObrisiAlarmniSistem_Click(object sender, EventArgs e)
        {
            if (this.lvLista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite alarmni sistem koga zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete alarmni sistem?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                //DTOManager.obrisiRadnikaIzSistema(idZaposleni);
                MessageBox.Show("Brisanje zaposlenog je uspesno obavljeno!");
                //this.popuniPodacima();
            }
        }
    }
}
