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
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnUcitavanjePolicajca_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();

				Policajac p = s.Load<Policajac>(304);

				MessageBox.Show(p.ToString());

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}
		}

		private void btnUcitajVozilo_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();

				Vozilo v = s.Load<Vozilo>("BG-456-CD");

				MessageBox.Show(v.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
			}
		}

		private void btnUcitavanjeTehnickogLica_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();

				Tehnicko_lice tl = s.Load<Tehnicko_lice>(102);

				MessageBox.Show(tl.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
			}
		}

		private void btnUcitajStanicu_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();

				Policijska_stanica ps = s.Load<Policijska_stanica>(202);

				MessageBox.Show(ps.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
			}
		}

		private void btnUcitajPZaVanredneSituacije_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();

				P_za_vanredne_situacije ps = s.Load<P_za_vanredne_situacije>(8);

				MessageBox.Show(ps.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.Message);
			}
		}

		private void btnUcitaj_Skolskog_policajca_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();

				Skolski_policajac ps = s.Load<Skolski_policajac>(11);

				MessageBox.Show(ps.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.Message);
			}
		}

		private void btnUcitajRadnikaUUpravi_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();
				Radnik_u_upravi ruu = s.Load<Radnik_u_upravi>(13);

				MessageBox.Show(ruu.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.Message);
			}
		}
		private void btnObjekti_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();

				Objekat o = s.Load<Objekat>(403);

				MessageBox.Show(o.ToString());


				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.Message);
			}
		}

		private void btnUnapredjenje_Click(object sender, EventArgs e) {

			try {
				ISession s = DataLayer.GetSession();

				UnapredjenjeId uid = new UnapredjenjeId();
				uid.Policajac = s.Load<Policajac>(301);
				uid.DatumSticanja = new DateTime(2022, 3, 1);

				Unapredjenje u = s.Load<Unapredjenje>(uid);

				MessageBox.Show(u.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.Message);
			}
		}


		private void btnBrojTelefona_Click(object sender, EventArgs e) {
			try {
				ISession s = DataLayer.GetSession();
				BrojTelefonaId bid = new BrojTelefonaId();
				bid.Broj = 5;
				Objekat ps = s.Load<Objekat>(1);
				bid.ObjekatZaBroj = ps;
				BrojTelefona bt = s.Load<BrojTelefona>(bid);

				MessageBox.Show(bt.ToString());

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.Message);
			}

		}
	}

}
