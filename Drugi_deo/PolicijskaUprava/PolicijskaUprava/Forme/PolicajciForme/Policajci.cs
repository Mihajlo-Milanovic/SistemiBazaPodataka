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
            List<Policajac> policajci = vratiSvePolicajce();

            foreach (Policajac p in policajci)
            {
                string Sefuje = p.SefujeStanicom != null ? p.SefujeStanicom.Id.ToString() : "NIJE SEF";
                string Zamenik = p.ZamenikStanice != null ? p.ZamenikStanice.Id.ToString() : "NIJE ZAMENIK";

                ListViewItem item = new ListViewItem(new string[] {p.Id.ToString(), p.Ime, p.Ime_roditelja, p.Prezime, p.JMBG, p.Datum_rodjenja.ToShortDateString(), p.Adresa,
                        p.Datum_prijema_u_sluzbu.ToShortDateString(), p.Stanica.Naziv, Sefuje,
                    Zamenik, p.Tip});
                ListaPolicajaca.Items.Add(item);

            }
            ListaPolicajaca.Refresh();
        }


        private void btnDodajPolicajca_Click(object sender, EventArgs e)
        {

        }









        //// OVO TREBA DA IDE U DTOManager I DA SE NAPRAVI NOVA KLASA PolicajacPregled !!!!!!!!
        public List<Policajac> vratiSvePolicajce()
        {
            List<Policajac> Policajci = new List<Policajac>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Policajac> sviPolicajci = s.CreateQuery("from Policajac").List<Policajac>();

                foreach (Policajac p in sviPolicajci)
                {
                    if (p.GetType() == typeof(P_za_vanredne_situacije))
                    {
                        P_za_vanredne_situacije policajac = (P_za_vanredne_situacije)p;
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(Patrolni_policajac))
                    {
                        Patrolni_policajac policajac = (Patrolni_policajac)p;
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(Policajac_pozornik))
                    {
                        Policajac_pozornik policajac = (Policajac_pozornik)p;
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(Radnik_u_upravi))
                    {
                        Radnik_u_upravi policajac = (Radnik_u_upravi)p;
                        Policajci.Add(policajac);
                    }
                    else //(p.GetType() == typeof(Skolski_policajac))
                    {
                        Skolski_policajac policajac = (Skolski_policajac)p;
                        Policajci.Add(policajac);
                    }
                   


                }

                s.Close();
            }
            catch (Exception ex)
            {
                ex.FormatExceptionMessage();
            }

            return Policajci;
        }


    }
}