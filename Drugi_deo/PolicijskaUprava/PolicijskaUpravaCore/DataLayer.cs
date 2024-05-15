namespace PolicijskaUprava {

	class DataLayer {
		private static ISessionFactory? _factory;
		private static object lockObj;

		static DataLayer() {
			_factory = null;
			lockObj = new object();
		}


		//funkcija na zahtev otvara sesiju
		public static ISession GetSession() {
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
		private static ISessionFactory CreateSessionFactory() {
			//        try
			//        {

			//System.Windows.Forms.MessageBox.Show("1");
			//var cfg = OracleManagedDataClientConfiguration.Oracle10
			//            .ShowSql()
			//            .ConnectionString(c =>
			//                c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18972;Password=vorkraft1"));
			//System.Windows.Forms.MessageBox.Show("2");
			//return Fluently.Configure()
			//                .Database(cfg)
			//                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PolicajacMapiranja>())
			//                .BuildSessionFactory();
			//        }
			//        catch (Exception ec)
			//        {
			//            System.Windows.Forms.MessageBox.Show("Ovde: " + ec.Message);
			//            return null;
			//        }

			try {
				// ShowSql prikazuje SQL koji je generisan, ali u .NET Core aplikacijama se prikazuju u konzoli.
				// Ako se aplikacija pokrene sa dotnet bin\Debug\net8.0-windows\ProdavnicaIgracaka.dll, mogu da se vide
				string cs = "Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18972;Password=vorkraft1";//*/ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;
				var cfg = OracleManagedDataClientConfiguration.Oracle10
							.ShowSql()
							.ConnectionString(c => c.Is(cs));

				return Fluently.Configure()
						.Database(cfg)
						.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapiranja.PolicajacMapiranja>())
						//.ExposeConfiguration(BuildSchema)
						.BuildSessionFactory();
			}
			catch (Exception e) {
				MessageBox.Show(e.FormatExceptionMessage());
				return null;
			}

		}
	}
}
