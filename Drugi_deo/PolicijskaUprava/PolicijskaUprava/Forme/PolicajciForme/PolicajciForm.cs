using PolicijskaUprava.Entiteti;
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

        private void btnDodajPolicajca_Click_1(object sender, EventArgs e)
        {
            
        }









        //// OVO TREBA DA IDE U DTOManager I DA SE NAPRAVI NOVA KLASA PolicajacPregled !!!!!!!!


    }
}