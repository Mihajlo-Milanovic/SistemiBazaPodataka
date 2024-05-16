using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitavanjePolicajca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Policajac p = s.Load<Policajac>(8);

                MessageBox.Show(p.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void btnUcitajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>("NI420GA"); // ne radi :(, ispitati Vozilo i VoziloMapiranja

                MessageBox.Show(v.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void btnUcitavanjeTehnickogLica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tehnicko_lice tl = s.Load<Tehnicko_lice>(1); // ne radi :(, ispitati Vozilo i VoziloMapiranja

                MessageBox.Show(tl.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void btnUcitajStanicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Policijska_stanica ps = s.Load<Policijska_stanica>(1);

                MessageBox.Show(ps.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void btnUcitajPZaVanredneSituacije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                P_za_vanredne_situacije ps = s.Load<P_za_vanredne_situacije>(8);

                MessageBox.Show(ps.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitaj_Skolskog_policajca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Skolski_policajac ps = s.Load<Skolski_policajac>(10);

                MessageBox.Show(ps.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
