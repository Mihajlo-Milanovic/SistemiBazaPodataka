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

                Policajac p = s.Load<Policajac>(3);

                MessageBox.Show(p.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
                MessageBox.Show(ec.Message);
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
                MessageBox.Show(ec.Message);
            }
        }
    }
}
