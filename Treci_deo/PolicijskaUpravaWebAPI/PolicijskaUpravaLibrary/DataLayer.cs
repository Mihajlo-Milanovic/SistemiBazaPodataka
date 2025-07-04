﻿namespace PolicijskaUpravaLibrary {

	public class DataLayer {
		private static ISessionFactory? _factory = null;
		private static object lockObj = new();

		//static DataLayer() {
		//	_factory = null;
		//	lockObj = new object();
		//}

		//funkcija na zahtev otvara sesiju
		public static ISession? GetSession() {
			if (_factory == null) {
				lock (lockObj) {
					if (_factory == null) {
						_factory = CreateSessionFactory();
					}
				}
			}

			return _factory?.OpenSession();
		}

		//konfiguracija i kreiranje session factory
		private static ISessionFactory? CreateSessionFactory() {			

			try {
				
				string cs = Vuksain;//definisano na dnu klase radi lakse izmene baze sa kojom se radi
						//ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;

				var cfg = OracleManagedDataClientConfiguration.Oracle10
							.ShowSql()
							.ConnectionString(c => c.Is(cs));

				return Fluently.Configure()
						.Database(cfg)
						.Mappings(m => m.FluentMappings.AddFromAssemblyOf<PolicijskaUpravaLibrary.Mapiranja.PolicajacMapiranja>())
						//.ExposeConfiguration(BuildSchema)
						.BuildSessionFactory();
			}
			catch (Exception e) {
				
				string erorr = e.HandleError();
				return null;
			}

		}

		#region Connection Strings

		private const string Mihajlo = "Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18747;Password=Miki747M";//Baza je ostala za 2. deo projekta
		private const string Vuksain = "Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18972;Password=vorkraft1";//Baza sa najnovijim izmenama 
		private const string Filip = "Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18842;Password=S18842"; //Nije u upotrebi

		#endregion
	}
}
