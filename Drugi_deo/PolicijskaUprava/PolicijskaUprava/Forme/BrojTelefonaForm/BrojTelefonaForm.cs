using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.BrojTelefonaForm
{
    public partial class BrojTelefonaForm : Form
    {
        public int idObjekta;
        public BrojTelefonaForm()
        {
            InitializeComponent();
        }
        public BrojTelefonaForm(int idObjekta)
        {
            InitializeComponent();
            this.idObjekta = idObjekta;
            refresh();
        }
        private void BrojTelefonaForm_Load(object sender, EventArgs e)
        {

        }
        public void refresh()
        {
            dgvBrojevi.DataSource = DTOManager.VratiTelefoneZaObjekat(idObjekta);
            bindingSource1.DataSource = dgvBrojevi;
        }
    }
}
