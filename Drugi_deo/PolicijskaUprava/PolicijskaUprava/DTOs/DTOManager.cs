

using NHibernate.Criterion;
using NHibernate.Util;

namespace PolicijskaUprava.DTOs {
    public class DTOManager {
        public static List<PolicajacView> vratiSvePolicajce() {
            List<PolicajacView> Policajci = new();
            try {
                ISession s = DataLayer.GetSession();

                IList<Policajac> sviPolicajci = s.CreateQuery("from Policajac").List<Policajac>();

                foreach (var p in sviPolicajci) {

                    if (p.GetType() == typeof(PatrolniPolicajac)) {
                        PatrolniPolicajacView policajac = new((PatrolniPolicajac)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(PolicajacPozornik)) {
                        PolicajacPozornikView policajac = new((PolicajacPozornik)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(RadnikUUpravi)) {
                        RadnikUUpraviView policajac = new((RadnikUUpravi)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(SkolskiPolicajac)) {
                        SkolskiPolicajacView policajac = new((SkolskiPolicajac)p);
                        Policajci.Add(policajac);
                    }
                    else if (p.GetType() == typeof(PZaVanredneSituacije)) {
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

        public static void DodajPolicijskuStanicu(PolicijskaStanica stanica) {

            try {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(stanica);
            }
            catch (Exception ec) {
                ec.FormatExceptionMessage();

            }

        }

        public static bool obrisiTehnickoLice(int id) {

            TehnickoLice tl = new();
            tl.Id = id;

            try {
                ISession s = DataLayer.GetSession();

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

        public static void ObrisiPolicistkuStanicuID(int ID) {
            try {
                ISession s = DataLayer.GetSession();

                PolicijskaStanica PS = s.Load<PolicijskaStanica>(ID);

                s.Delete(PS);
                s.Flush();

                s.Close();
            }
            catch (Exception ec) {
                ec.FormatExceptionMessage();
            }
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

				string hql = "from AlarmniSistem a where a.Id = :value";
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
	}
}
