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

namespace PolicijskaUprava {
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

                Policajac p = s.Load<Policajac>(9);

                MessageBox.Show(p.ToString());


                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
        }

        private void btnUcitajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>("BG-456-CD");

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

                Tehnicko_lice tl = s.Load<Tehnicko_lice>(102);

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

                PolicijskaStanica ps = s.Load<PolicijskaStanica>(202);

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

                PZaVanredneSituacije ps = s.Load<PZaVanredneSituacije>(10);

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

                SkolskiPolicajac ps = s.Load<SkolskiPolicajac>(11);

                MessageBox.Show(ps.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajRadnikaUUpravi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RadnikUUpravi ruu = s.Load<RadnikUUpravi>(13);

                MessageBox.Show(ruu.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void btnObjekti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(403);

                MessageBox.Show(o.ToString());


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUnapredjenje_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                UnapredjenjeId uid = new UnapredjenjeId();
                uid.Policajac = s.Load<Policajac>(301);
                uid.DatumSticanja = new DateTime(2022, 3, 1);

                Unapredjenje u = s.Load<Unapredjenje>(uid);

                MessageBox.Show(u.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void btnBrojTelefona_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                BrojTelefonaId bid = new BrojTelefonaId();
                bid.Broj = "5";
                Objekat ps = s.Load<Objekat>(1);
                bid.ObjekatZaBroj = ps;
                BrojTelefona bt = s.Load<BrojTelefona>(bid);

                MessageBox.Show(bt.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }



        private void UcitajPatrolnogPolBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                PatrolniPolicajac pp = s.Load<PatrolniPolicajac>(9);

                MessageBox.Show(pp.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void UcitajPatroluBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Patrola p = s.Load<Patrola>(3);

                MessageBox.Show(p.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void UcitajAlarmniSistemBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

               // IList<Alarmni_sistem> alarmniSistemi = s.QueryOver<Alarmni_sistem>().List<Alarmni_sistem>();

                AlarmniSistem al = s.Load<AlarmniSistem>(4);

                //foreach(Alarmni_sistem a in alarmniSistemi)
                //{
                //    if(a.GetType() == typeof(AS_detekcije_toplotnog_odraza))
                //    {
                //        AS_detekcije_toplotnog_odraza to = (AS_detekcije_toplotnog_odraza)a;
                //    }
                //    else if(a.GetType() == typeof(AS_detekcije_pokreta))
                //    {
                //        AS_detekcije_pokreta dp = (AS_detekcije_pokreta)a;
                //    }
                //    else
                //    {
                //        Ultrazvucni_AS u = (Ultrazvucni_AS)a;
                //    }
                //}

                MessageBox.Show(al.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }

        private void UcitajPPozornikaBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                PolicajacPozornik pp = s.Load<PolicajacPozornik>(15);

                MessageBox.Show(pp.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }
    }

}
