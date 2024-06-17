
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


// ALMOST DONE

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

/*OVO MISLIM DA NE TREBA 
 * 
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
*/

//	ALMOST DONE	

#endregion


#region Odrzavanja

// DONE

#endregion


#region Patrole

// DONE

#endregion

