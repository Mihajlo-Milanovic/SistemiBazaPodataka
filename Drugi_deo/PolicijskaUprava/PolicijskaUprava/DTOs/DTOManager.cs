using NHibernate.Criterion;
using PolicijskaUprava.Entiteti;
using PolicijskaUprava.Entiteti.VezeViseNaVise;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace PolicijskaUprava.DTOs {

	public class DTOManager {

		#region Policajci

		public static List<PolicajacView> vratiSvePolicajce() {


			List<PolicajacView> Policajci = new();
			try {
				ISession s = DataLayer.GetSession();

				IList<Policajac> sviPolicajci = s.CreateQuery("from Policajac").List<Policajac>();

				foreach (var p in sviPolicajci) {

					var type = p.GetType();

                    if (type == typeof(PatrolniPolicajac)) {
						PatrolniPolicajacView policajac = new((PatrolniPolicajac)p);
						Policajci.Add(policajac);
					}
					else if (type == typeof(PolicajacPozornik)) {
						PolicajacPozornikView policajac = new((PolicajacPozornik)p);
						Policajci.Add(policajac);
					}
					else if (type == typeof(RadnikUUpravi)) {
						RadnikUUpraviView policajac = new((RadnikUUpravi)p);
						Policajci.Add(policajac);
					}
					else if (type == typeof(SkolskiPolicajac)) {
						SkolskiPolicajacView policajac = new((SkolskiPolicajac)p);
						Policajci.Add(policajac);
					}
					else if (type == typeof(PZaVanredneSituacije)) {
						PZaVanredneSituacijeView policajac = new((PZaVanredneSituacije)p);
						Policajci.Add(policajac);
					}

				}

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			return Policajci;
		}

		public static void ObrisiPolicajcaID(int id) {
			try {
				ISession s = DataLayer.GetSession();

				Policajac p = s.Load<Policajac>(id);

                IEnumerable<Unapredjenje> unapredjenja = from u in s.Query<Unapredjenje>()
                                               where u.Id.Policajac.Id == p.Id
                                               select u;

                IEnumerable<Obrazovanje> obrazovanja = from o in s.Query<Obrazovanje>()
                                                         where o.Id.PolicajacObrazovanje.Id == p.Id
                                                         select o;

				//if()

                foreach (var u in unapredjenja)
                    s.Delete(u);

                foreach (var o in obrazovanja)
                    s.Delete(o);



                s.Delete(p);
				s.Flush();

				s.Close();
			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
			}
		}
        
        public static bool DodajPolicajca(Policajac p) {

			try {
				ISession s = DataLayer.GetSession();

				s.Save(p);
				return true;
			}

			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
				return false;
			}
		}

		public static Policajac VratiPolicajca(int policajacID) {
			try {
				ISession s = DataLayer.GetSession();
				Policajac policajac;
				//PolicijskaStanica ps = s.Load<PolicijskaStanica>(stanicaID);

				IEnumerable<Policajac> Policajac = from P in s.Query<Policajac>()
												   where P.Id == policajacID
												   select P;

				policajac = Policajac.First();

				s.Flush();
				s.Close();
				return policajac;
			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
				return null;
			}
		}

		public static bool UpdatePolicajca(Policajac policajac) {
			try {
				ISession s = DataLayer.GetSession();

				//PolicijskaStanica ps = s.Load<PolicijskaStanica>(stanicaID);

				s.Update(policajac);

				s.Flush();
				s.Close();
				return true;

			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
				return false;
			}
		}

		public static List<PolicajacView> vratiPolicajceZaPolicijskuStanicu(int idStanice) {
			List<PolicajacView> pv = null;

			try {

				ISession s = DataLayer.GetSession();

				IEnumerable<Policajac> policajac = from o in s.Query<Policajac>()
												   where o.Stanica.Id == idStanice
												   select o;

				pv = new();
				foreach (var i in policajac)
					pv.Add(new PolicajacView(i));

				s.Close();

				return pv;

			}
			catch (Exception ex) {

				MessageBox.Show(ex.FormatExceptionMessage());
				return pv;
			}
		}

		public static int ProveriDaliimaSefa(int stanicaId) {
			List<Policajac> policajci = new();

			using (ISession s = DataLayer.GetSession()) {
				IList<Policajac> Ipolicajaci = s.Query<Policajac>()
											.Where(p => p.Stanica.Id == stanicaId)
											.ToList();



				foreach (var p in Ipolicajaci) {
					if (p.SefujeStanicom != null && p.SefujeStanicom.Id == stanicaId)
						return p.Id;
				}
				return -1;
			}

		}

		public static List<PatrolniPolicajacView> vratiSvePatrolnePolicajce(){

			List<PatrolniPolicajacView> ppv = new();

			try {
				ISession s = DataLayer.GetSession();

				IEnumerable<PatrolniPolicajac> patPol = from pp in s.Query<PatrolniPolicajac>()
														select pp;

				foreach(var p in patPol) {
					ppv.Add(new PatrolniPolicajacView(p));
				}

				return ppv;

			} catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return ppv;
			}
		}

		public static List<PolicajacView> vratiSveSlobodnePolicajce() {

			List<PolicajacView> pv = new();

			try {
				ISession s = DataLayer.GetSession();

				IEnumerable<Policajac> policajci = from p in s.Query<Policajac>()
												   where p.SefujeStanicom == null
														&& p.ZamenikStanice == null
												   select p;

				foreach(var p in policajci) {
					pv.Add(new PolicajacView(p));
				}

				return pv;
			}catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return null;
			}
		}

		public static PolicajacView vratiPolicajca(int policajacId) {
			try {
				ISession s = DataLayer.GetSession();
				PolicajacView policajac;

				policajac = new PolicajacView(s.Get<Policajac>(policajacId));

				s.Flush();
				s.Close();
				return policajac;
			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
				return null;
			}
		}

		public static bool izmeniZaposlenjePolicajca(int pId, int sId, int poz) {


			try {

				ISession s = DataLayer.GetSession();

				Policajac p = s.Get<Policajac>(pId);
				PolicijskaStanica ps = s.Get<PolicijskaStanica>(sId);

				p.SefujeStanicom = null;
				p.ZamenikStanice = null;

				switch (poz) {
					case 1:
						p.SefujeStanicom = ps;
					break;
					case 2:
						p.ZamenikStanice = ps;
					break;
				}
				s.SaveOrUpdate(p);
				s.Flush();
				s.Close();

				return true;

			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		public static bool ukloniPolicajcaIzStanice(int pId) {
			try {

				ISession s = DataLayer.GetSession();

				Policajac p = s.Get<Policajac>(pId);

				p.SefujeStanicom = null;
				p.ZamenikStanice = null;
				p.Stanica = null;

				s.SaveOrUpdate(p);
				s.Flush();
				s.Close();

				return true;

			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		#endregion


		#region Tehnicka lica


		public static List<TehnickoLiceView> vratiSvaTehnickaLica() {

			List<TehnickoLiceView> tlv = new();
			try {
				ISession s = DataLayer.GetSession();

				IList<TehnickoLice> svaTehnickaLica = s.CreateQuery("from TehnickoLice").List<TehnickoLice>();

				foreach (var t in svaTehnickaLica) {
					tlv.Add(new TehnickoLiceView(t));
				}

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			return tlv;
		}

		public static bool dodajTehnickoLice(string ime, string prezime) {

			TehnickoLice tl = new(ime, prezime);

			try {
				ISession s = DataLayer.GetSession();

				s.Save(tl);

				s.Flush();

				s.Close();

				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;

			}
		}

		public static bool obrisiTehnickoLice(int id) {

			TehnickoLice tl = new();
			tl.Id = id;

			try {
				ISession s = DataLayer.GetSession();

				IEnumerable<Odrzava> odrzava = from o in s.Query<Odrzava>()
											   where o.Id.Tehnicar.Id == tl.Id
											   select o;

				foreach (var o in odrzava)
					s.Delete(o);

				s.Delete(tl);

				s.Flush();

				s.Close();

				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		public static bool izmeniTehnickoLice(TehnickoLice t) {

			try {
				ISession s = DataLayer.GetSession();

				s.Update(t);

				s.Flush();

				s.Close();

				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		#endregion


		#region Policijske stanice

		public static List<PolicijskaStanicaView> vratiSvePolicijskeStanice() {
			List<PolicijskaStanicaView> Stanice = new();
			try {
				ISession s = DataLayer.GetSession();

				IList<PolicijskaStanica> sveStanice = s.CreateQuery("from PolicijskaStanica").List<PolicijskaStanica>();

				foreach (var sS in sveStanice) {
					Stanice.Add(new PolicijskaStanicaView(sS));
				}

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			return Stanice;
		}

		public static void DodajPolicijskuStanicu(PolicijskaStanica stanica) {

			try {
				ISession s = DataLayer.GetSession();

				s.SaveOrUpdate(stanica);
			}
			catch (Exception ec) {
				ec.FormatExceptionMessage();

			}

		}

		public static void ObrisiPolicistkuStanicuID(int id) {
			try {
				ISession s = DataLayer.GetSession();

				PolicijskaStanica ps = s.Load<PolicijskaStanica>(id);

				IEnumerable<Objekat> objekti = from o in s.Query<Objekat>()
											   where o.PolicijskaStanica.Id == id
											   select o;

				foreach (var o in objekti)
					s.Delete(o);

			    s.Delete(ps);
				s.Flush();

				s.Close();
			}
			catch (Exception ec) {
				ec.FormatExceptionMessage();
			}
		}

		public static PolicijskaStanica VratiStanicu(int stanicaID) {
			try {
				ISession s = DataLayer.GetSession();
				PolicijskaStanica p;
				//PolicijskaStanica ps = s.Load<PolicijskaStanica>(stanicaID);

				IEnumerable<PolicijskaStanica> stanica = from ps in s.Query<PolicijskaStanica>()
														 where ps.Id == stanicaID
														 select ps;

				p = stanica.First();

				s.Flush();
				s.Close();

				return p;
			}
			catch (Exception ec) {
				MessageBox.Show(ec.FormatExceptionMessage());
				return null;
			}
		}

		public static bool dodajPolicajcaStanici(int pId, int sId, int pozicija) {

			try {

				ISession s = DataLayer.GetSession();

				Policajac p = s.Get<Policajac>(pId);
				PolicijskaStanica ps = s.Get<PolicijskaStanica>(sId);

				p.Stanica = ps;
				switch (pozicija) {
					case 1:
					p.SefujeStanicom = ps;
					break;
					default:
					p.ZamenikStanice = ps;
					break;
				}
				s.SaveOrUpdate(p);
				s.Flush();
				s.Close();

				return true;

			}catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		public static bool izmeniPolicijskuStanicu(PolicijskaStanica ps) {

			try {
				ISession s = DataLayer.GetSession();
	
				s.Update(ps);
				s.Flush();
				s.Close();
				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}

		}

		#endregion


		#region Alarmni sistemi

		public static List<AlarmniSistemView> vratiSveAlarmneSisteme() {

			List<AlarmniSistemView> asv = new();

			try {
				ISession s = DataLayer.GetSession();

				IEnumerable<AlarmniSistem> alarmniSistemi = from aa in s.Query<AlarmniSistem>() 
															select aa;

				foreach (var a in alarmniSistemi) {

					asv.Add(new AlarmniSistemView(a));

					//if (a.GetType() == typeof(AlarmniSistemId))
					//	asv.Add(new AlarmniSistemView(a));
					//else if (a.GetType() == typeof(UltrazvucniAS))
					//	asv.Add(new UltrazvucniASView((UltrazvucniAS)a));
					//else if (a.GetType() == typeof(ASDetekcijePokreta))
					//	asv.Add(new ASDetekcijePokretaView((ASDetekcijePokreta)a));
					//else if (a.GetType() == typeof(ASDetekcijeToplotnogOdraza))
					//	asv.Add(new ASDetekcijeToplotnogOdrazaView((ASDetekcijeToplotnogOdraza)a));

				}

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			return asv;

		}

		public static List<AlarmniSistemView> vratiSveAlarmneSistemeZaObjekat(int id) {

			List<AlarmniSistemView> asv = new();

			Objekat o = new();
			o.Id = id;

			try {
				ISession s = DataLayer.GetSession();

				IList<AlarmniSistem> alarmniSistemi = s.CreateCriteria<AlarmniSistem>()
														.Add(Restrictions.Eq("PripadaObjektu", o))
														.List<AlarmniSistem>();

				foreach (var aa in alarmniSistemi)
					asv.Add(new AlarmniSistemView(aa));


				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			return asv;
		}

		public static AlarmniSistem vratiAlarmniSistem(int id) {

			IList<AlarmniSistem> a = null;

			try {
				ISession s = DataLayer.GetSession();

				string hql = "from AlarmniSistemId a where a.Id = :value";
				IQuery query = s.CreateQuery(hql);
				query.SetParameter("value", id);

				a = query.List<AlarmniSistem>();

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			if (a != null)
				return a.First();
			else
				return null;
		}

		public static bool dodajAlarmniSistem(AlarmniSistem a) {


			try {
				ISession s = DataLayer.GetSession();

				s.Save(a);

				s.Flush();

				s.Close();

				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		public static bool izmeniAlarmniSistem(AlarmniSistem a) {


			try {
				ISession s = DataLayer.GetSession();

				s.SaveOrUpdate(a);

				s.Flush();

				s.Close();

				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		public static bool obrisiAlarmniSistem(AlarmniSistem a) {

			try {

				ISession s = DataLayer.GetSession();

				s.Delete(a);


				s.Flush();

				s.Close();

				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}

		}

		#endregion


		#region Vozila

		public static List<VoziloView> vratiSvaVozila() {
			List<VoziloView> Vozila = new();
			try
			{
				ISession s = DataLayer.GetSession();

				IList<Vozilo> svaVozila = s.CreateQuery("from Vozilo").List<Vozilo>();

				foreach (var v in svaVozila) {
					Vozila.Add(new VoziloView(v));
				}

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			return Vozila;
		}

		public static void DodajVozilo(Vozilo vozilo) {

			try
			{
				ISession s = DataLayer.GetSession();

				s.SaveOrUpdate(vozilo);

				s.Flush();

				s.Close();
			}
			catch (Exception ec) {
				ec.FormatExceptionMessage();
			}

		}

		public static void ObrisiVozilo(string registracija) {
			try
			{
				ISession s = DataLayer.GetSession();

				Vozilo v = new Vozilo(registracija, "", "", "", "");

				s.Delete(v);
				s.Flush();

				s.Close();
			}
			catch (Exception ec) {
				ec.FormatExceptionMessage();
			}
		}

		public static bool AzurirajVozilo(Vozilo vozilo, string staraRegistracija) {
			try
			{
				ISession s = DataLayer.GetSession();
				if (vozilo.RegOznaka == staraRegistracija) {
					s.Update(vozilo);
				}
				else {
					IEnumerable<Vozilo> vozila = from v in s.Query<Vozilo>()
												 where v.RegOznaka == vozilo.RegOznaka
												 select v;
					if (vozila.Count() > 0)
						return false;

					s.Delete(new Vozilo(staraRegistracija, "", "", "", ""));
					s.Save(vozilo);
				}
				s.Flush();
				s.Close();
				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		#endregion


		#region Objekat

		public static List<ObjekatView> vratiSveObjekte() {
			List<ObjekatView> objekti = new();
			try
			{
				ISession s = DataLayer.GetSession();

				IList<Objekat> svaVozila = s.CreateQuery("from Objekat").List<Objekat>();

				foreach (var o in svaVozila) {
					objekti.Add(new ObjekatView(o));
				}

				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

			return objekti;
		}

		public static void dodajObjekatStanici(ObjekatView o, int idStanice) {
			try
			{
				ISession s = DataLayer.GetSession();

				Objekat obj = new Objekat();
				obj.KontaktIme = o.KontaktIme;
				obj.KontaktPrezime = o.KontaktPrezime;
				obj.Povrsina = o.Povrsina;
				obj.Adresa = o.Adresa;
				obj.Tip = o.Tip;

				obj.PolicijskaStanica = s.Load<PolicijskaStanica>(idStanice);
				s.SaveOrUpdate(obj);

				s.Flush();
				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}
		}

		public static void ObrisiObjekat(int id) {
			try
			{
				ISession s = DataLayer.GetSession();

				Objekat o = new Objekat(id);

                IEnumerable<BrojTelefona> brojeviTelefona = from bt in s.Query<BrojTelefona>()
                                                       where bt.Id.ObjekatZaBroj.Id == o.Id
                                                       select bt;
                IEnumerable<AlarmniSistem> alarmniSistemi = from aa in s.Query<AlarmniSistem>()
                                                            where  aa.PripadaObjektu.Id == o.Id
                                                            select aa;

                foreach (var bt in brojeviTelefona)
					s.Delete(bt);

                foreach (var aa in alarmniSistemi)
                    s.Delete(aa);

                s.Delete(o);
				s.Flush();

				s.Close();
			}
			catch (Exception ec) {
				ec.FormatExceptionMessage();
			}
		}

		public static bool AzurirajObjekat(ObjekatView o) {
			try
			{
				ISession s = DataLayer.GetSession();
				Objekat ob = s.Load<Objekat>(o.Id);

				ob.Povrsina = o.Povrsina;
				ob.Adresa = o.Adresa;
				ob.KontaktIme = o.KontaktIme;
				ob.KontaktPrezime = o.KontaktPrezime;
				ob.Tip = o.Tip;

				s.Update(ob);
				s.Flush();
				s.Close();
				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		public static List<ObjekatView> vratiObjekteZaPolicijskuStanicu(int stanicaId) {

			List<ObjekatView> ov = null;

			try {

				ISession s = DataLayer.GetSession();

				IEnumerable<Objekat> objekat = from o in s.Query<Objekat>()
											   where o.PolicijskaStanica.Id == stanicaId
											   select o;

				ov = new();
				foreach (var i in objekat)
					ov.Add(new ObjekatView(i));

				s.Close();

				return ov;

			} catch (Exception ex) {

				MessageBox.Show(ex.FormatExceptionMessage());
			}


			return null;
		}

		#endregion


		#region Telefoni za objekat

		public static List<BrojTelefonaView> VratiTelefoneZaObjekat(int idObjekta) {
			try
			{
				ISession s = DataLayer.GetSession();
				List<BrojTelefonaView> list = new List<BrojTelefonaView>();

				IEnumerable<BrojTelefona> brojevi = from bt in s.Query<BrojTelefona>()
													where bt.Id.ObjekatZaBroj.Id == idObjekta
													select bt;

				foreach (BrojTelefona bt in brojevi)
					list.Add(new BrojTelefonaView(bt));

				s.Flush();
				s.Close();

				return list;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return null;
			}
		}

		public static void dodajBrojTelefonaZaObjekat(BrojTelefonaView btv, int idObjekta) {
			try
			{
				ISession s = DataLayer.GetSession();
				BrojTelefona bt = new BrojTelefona();
				bt.Id.Broj = btv.Broj;
				bt.Id.ObjekatZaBroj = s.Load<Objekat>(idObjekta);

				s.Save(bt);
				s.Flush();
				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}

		}

		public static void ObrisiBroj(string broj, int idObjekta) {
			try
			{
				ISession s = DataLayer.GetSession();

				BrojTelefona bt = new BrojTelefona();
				bt.Id.Broj = broj;
				bt.Id.ObjekatZaBroj = s.Load<Objekat>(idObjekta);

				s.Delete(bt);
				s.Flush();
				s.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
			}
		}
		#endregion


		#region Odrzavanja

		public static List<OdrzavaView> vratiIstorijuOdrzavanjaZaTehnickoLice(int tehId) {

			List<OdrzavaView> ov = null;

			try {
				ISession s = DataLayer.GetSession();

				IEnumerable<Odrzava> odrzava = from o in s.Query<Odrzava>()
											   where o.Id.Tehnicar.Id == tehId
											   select o;

				ov = new();

				foreach (var i in odrzava) 
					ov.Add(new OdrzavaView(i));


				s.Close();

				return ov;
			}
			catch (Exception ex) {

				MessageBox.Show(ex.FormatExceptionMessage());
				return null;
			}
		}

		public static List<OdrzavaView> vratiIstorijuOdrzavanjaZaAlarmniSistem(int ASId) {

			List<OdrzavaView> ov = null;

			try {
				ISession s = DataLayer.GetSession();

				IEnumerable<Odrzava> odrzava = from o in s.Query<Odrzava>()
											   where o.Id.AlarmniSistem.Id == ASId
											   select o;

				ov = new();
				foreach (var i in odrzava)
					ov.Add(new OdrzavaView(i));


				s.Close();

				return ov;
			}
			catch (Exception ex) {

				MessageBox.Show(ex.FormatExceptionMessage());
				return null;
			}
		}

		public static bool dodajOdrzava(OdrzavaView ov) {

			Odrzava o = new();
			o.Id = new();
			o.Id.AlarmniSistem = new();
			o.Id.AlarmniSistem.Id = ov.AlarmniSistemId;
			o.Id.Tehnicar = new();
			o.Id.Tehnicar.Id = ov.TehnickoLiceId;
			o.Id.PocetniDatum = ov.Pocetak;
			o.KrajnjiDatum = ov.Kraj;

			try {
				ISession s = DataLayer.GetSession();

				s.Save(o);

				s.Flush();

				s.Close();

				return true;

			}catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
			
		}

		public static bool obrisiOdrzava(Odrzava o) {

			try {

				ISession s = DataLayer.GetSession();

				s.Delete(o);

				s.Flush();

				s.Close();

				return true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}
        #endregion


        #region Unapredjenja

        public static List<UnapredjenjeView> vratiUnapredjenjaZaPolicajca(int policajacId)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<UnapredjenjeView> ret = new List<UnapredjenjeView>();

                IEnumerable<Unapredjenje> unapredjenja = from u in s.Query<Unapredjenje>()
                                                         where u.Id.Policajac.Id == policajacId
                                                         select u;
                foreach (var u in unapredjenja)
                    ret.Add(new UnapredjenjeView(u));

                s.Flush();
                s.Close();

                return ret;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.FormatExceptionMessage());
                return null;
            }
        }

        public static void dodajUnapredjenjeZaPolicajca(UnapredjenjeView uv, int policajacId)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Unapredjenje u = new Unapredjenje();
				u.Cin = uv.Cin;
				u.Id.DatumSticanja = uv.DatumSticanja;
				u.Id.Policajac = s.Load<Policajac>(policajacId);

				s.Save(u);
				s.Flush();
				s.Close();
			}
			catch (Exception ex)
			{
				ex.FormatExceptionMessage();
			}
		}

		public static void obrisiUnapredjenje(DateTime datum, int policajacId)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Unapredjenje u = new Unapredjenje();
				u.Id.DatumSticanja = datum;
				u.Id.Policajac = s.Load<Policajac>(policajacId);

				s.Delete(u);
				s.Flush();
				s.Close();
			}
			catch (Exception ex)
			{
				ex.FormatExceptionMessage();
			}
		}

        #endregion


        #region Obrazovanje

        public static List<ObrazovanjeView> vratiObrazovanjaZaPolicajca(int policajacId)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<ObrazovanjeView> ret = new List<ObrazovanjeView>();

                IEnumerable<Obrazovanje> obrazovanja = from o in s.Query<Obrazovanje>()
                                                       where o.Id.PolicajacObrazovanje.Id == policajacId
                                                       select o;
                foreach (var o in obrazovanja)
                    ret.Add(new ObrazovanjeView(o));

                s.Flush();
                s.Close();

                return ret;
            }
            catch (Exception ex)
            {
                ex.FormatExceptionMessage();
                return null;
            }
        }

        public static void dodajObrazovanjeZaPolicajca(ObrazovanjeView ov, int policajacId)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Obrazovanje o = new Obrazovanje();
				o.Id.DatumDiplomiranja = ov.DatumDipolomirnja;
				o.Id.Skola = ov.Skola;
				o.Id.PolicajacObrazovanje = s.Load<Policajac>(policajacId);

				s.Save(o);
				s.Flush();
				s.Close();
			}
			catch (Exception ex)
			{
				ex.FormatExceptionMessage();
			}
		}

		public static void obrisiObrazovanje(string skola, DateTime datum, int policajacId)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Obrazovanje o = new Obrazovanje();
				o.Id.DatumDiplomiranja = datum;
				o.Id.Skola = skola;
				o.Id.PolicajacObrazovanje = s.Load<Policajac>(policajacId);

				s.Delete(o);
				s.Flush();
				s.Close();
			}
			catch (Exception ex)
			{
				ex.FormatExceptionMessage();
			}
		}

		#endregion


		#region Patrole

		public static List<PatrolaView> vratiSvePatrole() {

			List<PatrolaView> pv = null;
			try {
				ISession s = DataLayer.GetSession();

				IEnumerable<Patrola> patrole = from p in s.Query<Patrola>() select p;

				pv = new List<PatrolaView>();
				foreach(Patrola p in patrole) {
					pv.Add(new PatrolaView(p));
				}

				s.Close();

				return pv;

			}catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return pv;
			}
		}

		public static bool dodajPatrolu(PatrolaView pv) {


				Patrola patrola = new();
				patrola.RedniBroj = pv.RedniBroj;
				patrola.DuziVozilo = new();
				patrola.DuziVozilo.RegOznaka = pv.RegOznakaVozila;
				patrola.SefId = new();
				patrola.SefId.Id = pv.SefId;
				patrola.PomocnikId = new();
				patrola.PomocnikId.Id = pv.PomocnikId;

			try {

				ISession s = DataLayer.GetSession();

				s.Save(patrola);

				s.Flush();

				s.Close();

				return true;
			}catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		public static bool obrisiPatrolu(PatrolaView pv) {

			Patrola p = new();
			p.RedniBroj = pv.RedniBroj;

			try {
				ISession s = DataLayer.GetSession();

				s.Delete(p);

				s.Flush();

				s.Close();

				return true;

			}catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}

		}

		public static bool izmeniPatrolu(PatrolaView pv) {

			Patrola p = new();

			p.RedniBroj = pv.RedniBroj;

			try {
				ISession s = DataLayer.GetSession();

				p.DuziVozilo = s.Load<Vozilo>(pv.RegOznakaVozila);
				p.SefId = s.Load<PatrolniPolicajac>(pv.SefId);
				p.PomocnikId = s.Load<PatrolniPolicajac>(pv.PomocnikId);

				s.Update(p);

				s.Flush();

				s.Close();

				return true;

			}catch(Exception ex) {
				MessageBox.Show(ex.FormatExceptionMessage());
				return false;
			}
		}

		#endregion
	}
}
