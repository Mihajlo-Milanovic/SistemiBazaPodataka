using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.ObjekatForme
{
    /*public partial class AzurirajVoziloForm : Form
    {
        Vozilo v;
        string staraRegistracija = "";
        public AzurirajVoziloForm(Vozilo vv)
        {
            InitializeComponent();

            this.v = vv;

            txtRegOznaka.Text = v.RegOznaka;//implementirati !!!
            txtBoja.Text = v.Boja;
            txtModel.Text = v.Model;
            txtProizvodjac.Text = v.Proizvodjac;
            txtTip.Text = v.Tip;
            staraRegistracija = v.RegOznaka;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (!DTOManager.AzurirajVozilo(new Vozilo(txtRegOznaka.Text, txtBoja.Text, txtTip.Text,
                txtProizvodjac.Text, txtModel.Text), staraRegistracija))
                MessageBox.Show("Vec postoji vozilo sa unetom registracijom!");

            else
            {

                v.Boja = txtBoja.Text;
                v.Model = txtModel.Text;
                v.RegOznaka = txtRegOznaka.Text;
                v.Proizvodjac = txtProizvodjac.Text;
                v.Tip = txtTip.Text;

                MessageBox.Show("Uspesno ste azurirali vozilo !");
            }
        }
    }*/
    public partial class AzurirajObjekatForm : Form
    {
        public ObjekatView obj;
        public AzurirajObjekatForm()
        {
            InitializeComponent();
        }
        public AzurirajObjekatForm(ObjekatView o)
        {
            InitializeComponent();
            obj = o;

            txtIme.Text = o.KontaktIme;
            txtPrezime.Text = o.KontaktPrezime;
            txtTip.Text = o.Tip;
            txtAdresa.Text = o.Adresa;
            numPovrsina.Value = o.Povrsina;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (DTOManager.AzurirajObjekat(new ObjekatView(obj.Id,txtTip.Text,txtAdresa.Text,(int)numPovrsina.Value,
                txtIme.Text,txtPrezime.Text,obj.PolicijskaStanicaId,obj.PolicijskaStanicaNaziv)))
            {
                MessageBox.Show("Uspesno ste azurirali objekat!");
                obj.KontaktIme = txtIme.Text;
                obj.Tip = txtTip.Text;
                obj.Povrsina = (int)numPovrsina.Value;
                obj.Adresa = txtAdresa.Text;
                obj.KontaktPrezime = txtPrezime.Text;
                this.Close();
            }
            else
                MessageBox.Show("Pobrkali ste loncice kolega!");
            
        }
        
    }
}
