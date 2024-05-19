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
        public Policajci()
        {
            InitializeComponent();
            //PopuniTabelu();
        }

        //public void PopuniTabelu()
        //{
        //    ListaPolicajaca.Items.Clear();
        //    List<Policajac> podaci = vratiSvePolicajce();

        //    foreach (Policajac p in podaci)
        //    {
        //        ListViewItem item = new ListViewItem(new string[] { p.Ime, p.Ime_roditelja, p.Prezime,p.Datum_rodjenja.ToShortDateString(), p.Adresa, p.JMBG,
        //                p.Datum_prijema_u_sluzbu.ToShortDateString(), p.Stanica.Naziv, p.SefujeStanicom.Naziv == null ? p.SefujeStanicom.Naziv: " ", 
        //            p.ZamenikStanice.Naziv == null ? p.ZamenikStanice.Naziv : " ", p.Tip});
        //        ListaPolicajaca.Items.Add(item);

        //    }



        //    ListaPolicajaca.Refresh();
        //}

        private void btnDodajPolicajca_Click(object sender, EventArgs e)
        {

        }













        //// OVO TREBA DA IDE U DTOManager I DA SE NAPRAVI NOVA KLASA PolicajacPregled !!!!!!!!
        //public static List<Policajac> vratiSvePolicajce()
        //{
        //    List<Policajac> policajci = new List<Policajac>();
        //    try
        //    {
        //        ISession s = DataLayer.GetSession();

        //        IEnumerable<Policajac> sviProdavnici = from o in s.Query<Policajac>()
        //                                                                    select o;

        //        foreach (Policajac p in sviProdavnici)
        //        {
        //            if (p is P_za_vanredne_situacije PZVS)
        //            {
        //                P_za_vanredne_situacije pzvs = new P_za_vanredne_situacije(p.Id, p.Ime, p.Ime_roditelja,
        //                    p.Prezime, p.Datum_rodjenja, p.JMBG, p.Adresa, p.Datum_prijema_u_sluzbu, p.Stanica, p.SefujeStanicom
        //                    , p.ZamenikStanice, p.Tip, PZVS.Kurs, PZVS.Vestina, PZVS.Datum_zavrsetka_kursa, PZVS.Sertifikat,
        //                    PZVS.Datum_sticanja_sertifikata);

        //                policajci.Add(pzvs);
        //            }

        //        }

        //        s.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        //handle exceptions
        //    }

        //    return policajci;
        //}
    }
}