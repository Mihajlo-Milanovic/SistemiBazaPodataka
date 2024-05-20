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
    public partial class Policajci : Form
    {
        public static List<Policajac> policajci;
        public Policajci()
        {
            InitializeComponent();
            PopuniTabelu();
        }

        public void PopuniTabelu()
        {
            ListaPolicajaca.Items.Clear();
            policajci = DTOManager.vratiSvePolicajce();

            foreach (Policajac p in policajci)
            {
                string Sefuje = p.SefujeStanicom != null ? p.SefujeStanicom.Id.ToString() : "NIJE SEF";
                string Zamenik = p.ZamenikStanice != null ? p.ZamenikStanice.Id.ToString() : "NIJE ZAMENIK";

                ListViewItem item = new ListViewItem(new string[] {p.Id.ToString(), p.Ime, p.Ime_roditelja, p.Prezime, p.JMBG, p.Datum_rodjenja.ToShortDateString(), p.Adresa,
                        p.DatumPrijemaUSluzbu.ToShortDateString(), p.Stanica.Naziv, Sefuje,Zamenik, p.Tip});
                ListaPolicajaca.Items.Add(item);

            }
            ListaPolicajaca.Refresh();
        }


        private void btnDodajPolicajca_Click(object sender, EventArgs e)
        {

        }









        //// OVO TREBA DA IDE U DTOManager I DA SE NAPRAVI NOVA KLASA PolicajacPregled !!!!!!!!
       

    }
}