
#region Policajci


//		public static List<PatrolniPolicajacView> vratiSvePatrolnePolicajce(){

//			List<PatrolniPolicajacView> ppv = new();

//			try {
//				ISession s = DataLayer.GetSession();

//				IEnumerable<PatrolniPolicajac> patPol = from pp in s.Query<PatrolniPolicajac>()
//														select pp;

//				foreach(var p in patPol) {
//					ppv.Add(new PatrolniPolicajacView(p));
//				}

//				return ppv;

//			} catch(Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//				return ppv;
//			}
//		}


/* Pravicu se da ovo nisam video   
 * 

//		public static List<PolicajacView> vratiSveSlobodnePolicajce() {

//			List<PolicajacView> pv = new();

//			try {
//				ISession s = DataLayer.GetSession();

//				IEnumerable<Policajac> policajci = from p in s.Query<Policajac>()
//												   where p.SefujeStanicom == null
//														&& p.ZamenikStanice == null
//												   select p;

//				foreach(var p in policajci) {
//					pv.Add(new PolicajacView(p));
//				}

//				return pv;
//			}catch(Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//				return null;
//			}
//		}
*/

#endregion

#region Tehnicka lica

// DONE

#endregion

#region Policijske stanice

// DONE

#endregion

#region Vozila

// DONE		

#endregion

#region Objekat

// DONE

#endregion

#region Telefoni za objekat

// DONE

#endregion

#region Unapredjenja

// DONE

#endregion

#region Obrazovanje

// DONE

#endregion


#region Alarmni sistemi

//		public static List<AlarmniSistemView> vratiSveAlarmneSisteme() {

//			List<AlarmniSistemView> asv = new();

//			try {
//				ISession s = DataLayer.GetSession();

//				IEnumerable<AlarmniSistem> alarmniSistemi = from aa in s.Query<AlarmniSistem>() 
//															select aa;

//				foreach (var a in alarmniSistemi) {

//					asv.Add(new AlarmniSistemView(a));

//					//if (a.GetType() == typeof(AlarmniSistemId))
//					//	asv.Add(new AlarmniSistemView(a));
//					//else if (a.GetType() == typeof(UltrazvucniAS))
//					//	asv.Add(new UltrazvucniASView((UltrazvucniAS)a));
//					//else if (a.GetType() == typeof(ASDetekcijePokreta))
//					//	asv.Add(new ASDetekcijePokretaView((ASDetekcijePokreta)a));
//					//else if (a.GetType() == typeof(ASDetekcijeToplotnogOdraza))
//					//	asv.Add(new ASDetekcijeToplotnogOdrazaView((ASDetekcijeToplotnogOdraza)a));

//				}

//				s.Close();
//			}
//			catch (Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//			}

//			return asv;

//		}

//		public static List<AlarmniSistemView> vratiSveAlarmneSistemeZaObjekat(int id) {

//			List<AlarmniSistemView> asv = new();

//			Objekat o = new();
//			o.Id = id;

//			try {
//				ISession s = DataLayer.GetSession();

//				IList<AlarmniSistem> alarmniSistemi = s.CreateCriteria<AlarmniSistem>()
//														.Add(Restrictions.Eq("PripadaObjektu", o))
//														.List<AlarmniSistem>();

//				foreach (var aa in alarmniSistemi)
//					asv.Add(new AlarmniSistemView(aa));


//				s.Close();
//			}
//			catch (Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//			}

//			return asv;
//		}

//		public static AlarmniSistem vratiAlarmniSistem(int id) {

//			IList<AlarmniSistem> a = null;

//			try {
//				ISession s = DataLayer.GetSession();

//				string hql = "from AlarmniSistemId a where a.Id = :value";
//				IQuery query = s.CreateQuery(hql);
//				query.SetParameter("value", id);

//				a = query.List<AlarmniSistem>();

//				s.Close();
//			}
//			catch (Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//			}

//			if (a != null)
//				return a.First();
//			else
//				return null;
//		}

//		public static bool dodajAlarmniSistem(AlarmniSistem a) {


//			try {
//				ISession s = DataLayer.GetSession();

//				s.Save(a);

//				s.Flush();

//				s.Close();

//				return true;
//			}
//			catch (Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//				return false;
//			}
//		}

//		public static bool izmeniAlarmniSistem(AlarmniSistem a) {


//			try {
//				ISession s = DataLayer.GetSession();

//				s.SaveOrUpdate(a);

//				s.Flush();

//				s.Close();

//				return true;
//			}
//			catch (Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//				return false;
//			}
//		}

//		public static bool obrisiAlarmniSistem(AlarmniSistem a) {

//			try {

//				ISession s = DataLayer.GetSession();

//				s.Delete(a);


//				s.Flush();

//				s.Close();

//				return true;
//			}
//			catch (Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//				return false;
//			}

//		}

#endregion


#region Odrzavanja

//		public static List<OdrzavaView> vratiIstorijuOdrzavanjaZaTehnickoLice(int tehId) {

//			List<OdrzavaView> ov = null;

//			try {
//				ISession s = DataLayer.GetSession();

//				IEnumerable<Odrzava> odrzava = from o in s.Query<Odrzava>()
//											   where o.Id.Tehnicar.Id == tehId
//											   select o;

//				ov = new();

//				foreach (var i in odrzava) 
//					ov.Add(new OdrzavaView(i));


//				s.Close();

//				return ov;
//			}
//			catch (Exception ex) {

//				MessageBox.Show(ex.FormatExceptionMessage());
//				return null;
//			}
//		}

//		public static List<OdrzavaView> vratiIstorijuOdrzavanjaZaAlarmniSistem(int ASId) {

//			List<OdrzavaView> ov = null;

//			try {
//				ISession s = DataLayer.GetSession();

//				IEnumerable<Odrzava> odrzava = from o in s.Query<Odrzava>()
//											   where o.Id.AlarmniSistem.Id == ASId
//											   select o;

//				ov = new();
//				foreach (var i in odrzava)
//					ov.Add(new OdrzavaView(i));


//				s.Close();

//				return ov;
//			}
//			catch (Exception ex) {

//				MessageBox.Show(ex.FormatExceptionMessage());
//				return null;
//			}
//		}

//		public static bool dodajOdrzava(OdrzavaView ov) {

//			Odrzava o = new();
//			o.Id = new();
//			o.Id.AlarmniSistem = new();
//			o.Id.AlarmniSistem.Id = ov.AlarmniSistemId;
//			o.Id.Tehnicar = new();
//			o.Id.Tehnicar.Id = ov.TehnickoLiceId;
//			o.Id.PocetniDatum = ov.Pocetak;
//			o.KrajnjiDatum = ov.Kraj;

//			try {
//				ISession s = DataLayer.GetSession();

//				s.Save(o);

//				s.Flush();

//				s.Close();

//				return true;

//			}catch(Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//				return false;
//			}

//		}

//		public static bool obrisiOdrzava(Odrzava o) {

//			try {

//				ISession s = DataLayer.GetSession();

//				s.Delete(o);

//				s.Flush();

//				s.Close();

//				return true;
//			}
//			catch (Exception ex) {
//				MessageBox.Show(ex.FormatExceptionMessage());
//				return false;
//			}
//		}
#endregion


#region Patrole

// DONE

#endregion

