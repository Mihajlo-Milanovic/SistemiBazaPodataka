namespace PolicijskaUpravaLibrary;

public static class DataProvider {

	#region Vozilo


	public static async Task<Result<List<VoziloView>, ErrorMessage>> VratiSvaVozilaAsync() {

		List<VoziloView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Vozilo>().ListAsync()).Select(p => new VoziloView(p)).ToList();


		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o vozilima".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<int, ErrorMessage>> SacuvajVoziloAsync(VoziloView vozilo) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Vozilo v = vozilo.ToVozilo();
				
			
			await s.SaveAsync(v);
			await s.FlushAsync();

			id = v.Id;
		}
		catch (Exception ex) {
			return "Nemoguće sačuvati vozilo.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return id;
	}

	public async static Task<Result<VoziloView, ErrorMessage>> VratiVoziloAsync(int id) {
		ISession? s = null;
		VoziloView v = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Vozilo vozilo = await s.LoadAsync<Vozilo>(id);

			v = new VoziloView(vozilo);

		}
		catch (Exception) {
			return "Nemoguće vratiti vozilo.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return v;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniVoziloAsync(VoziloView vozilo) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Vozilo v = await s.LoadAsync<Vozilo>(vozilo.Id);

			v.RegOznaka = vozilo.RegOznaka;
			v.Tip = vozilo.Tip;
			v.Boja = vozilo.Boja;
			v.Proizvodjac = vozilo.Proizvodjac;
			v.Model = vozilo.Model;

			await s.SaveOrUpdateAsync(v);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti vozilo.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiVoziloAsync(int id) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Vozilo vozilo = await s.LoadAsync<Vozilo>(id);

			await s.DeleteAsync(vozilo);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja vozila".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}


	#endregion
	
	#region Tehnicko lice


	public static async Task<Result<List<TehnickoLiceView>, ErrorMessage>> VratiSvaTehnickaLicaAsync() {

		List<TehnickoLiceView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<TehnickoLice>().ListAsync()).Select(p => new TehnickoLiceView(p)).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o tehnickim licima".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<int, ErrorMessage>> SacuvajTehnickoLiceAsync(TehnickoLiceView tehnickoLice) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			TehnickoLice t = tehnickoLice.ToTehnickoLice();

			await s.SaveAsync(t);
			await s.FlushAsync();

			id = t.Id;
		}
		catch (Exception) {
			return "Nemoguće sačuvati tehnicko lice.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return id;
	}

	public async static Task<Result<TehnickoLiceView, ErrorMessage>> VratiTehnickoLiceAsync(int id) {
		ISession? s = null;
		TehnickoLiceView t = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			TehnickoLice tehnickoLice = await s.LoadAsync<TehnickoLice>(id);

			t = new TehnickoLiceView(tehnickoLice);

		}
		catch (Exception) {
			return "Nemoguće vratiti tehnicko lice.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return t;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniTehnickoLiceAsync(TehnickoLiceView tehnickoLice) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			TehnickoLice t = await s.LoadAsync<TehnickoLice>(tehnickoLice.Id);

			t.Ime = tehnickoLice.Ime;
			t.Prezime = tehnickoLice.Prezime;

			await s.SaveOrUpdateAsync(t);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti tehnicko lice.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiTehnickoLiceAsync(int id) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			IEnumerable<Odrzava> odrzava = from o in s.Query<Odrzava>()
										   where o.Id.Tehnicar.Id == id
										   select o;

			foreach (var o in odrzava)
				s.Delete(o);

			TehnickoLice tehnickoLice = await s.LoadAsync<TehnickoLice>(id);

			await s.DeleteAsync(tehnickoLice);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja tehnickog lica".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}


	#endregion

	#region Policajac


	public static async Task<Result<List<PolicajacView>, ErrorMessage>> VratiSvePolicajceAsync() {

		List<PolicajacView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Policajac>().ListAsync()).Select<Policajac, PolicajacView>(p => {

				var type = p.GetType();

				if (type == typeof(PatrolniPolicajac)) {
					return new((PatrolniPolicajac)p);
				}
				else if (type == typeof(PolicajacPozornik)) {
					return new((PolicajacPozornik)p);
				}
				else if (type == typeof(RadnikUUpravi)) {
					return new((RadnikUUpravi)p);
				}
				else if (type == typeof(SkolskiPolicajac)) {
					return new((SkolskiPolicajac)p);
				}
				else //if (type == typeof(PZaVanredneSituacije)) {
					return new((PZaVanredneSituacije)p);
				//}
				//else return null;

			}).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o policajcima".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<int, ErrorMessage>> SacuvajPolicajcaAsync(PolicajacView policajac) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Policajac p = new() {

				Ime = policajac.Ime,
				ImeRoditelja = policajac.ImeRoditelja,
				Prezime = policajac.Prezime,
				JMBG = policajac.JMBG,
				Adresa = policajac.Adresa,
				DatumRodjenja = policajac.DatumRodjenja,
				DatumPrijemaUSluzbu = policajac.DatumPrijemaUSluzbu,

				Stanica =
				(policajac.RadiUStanici != null) ? await s.LoadAsync<PolicijskaStanica>(policajac.RadiUStanici.Id) : null,

				SefujeStanicom =
				(policajac.SefujeStanicom != null) ? await s.LoadAsync<PolicijskaStanica>(policajac.SefujeStanicom.Id) : null,

				ZamenikStanice =
				(policajac.ZamenikStanice != null) ? await s.LoadAsync<PolicijskaStanica>(policajac.ZamenikStanice.Id) : null,

				Tip = policajac.Tip,

			};

			await s.SaveAsync(p);
			await s.FlushAsync();

			id = p.Id;
		}
		catch (Exception) {
			return "Nemoguće sačuvati policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return id;
	}

	public async static Task<Result<PolicajacView, ErrorMessage>> VratiPolicajcaAsync(int id) {
		ISession? s = null;
		PolicajacView p = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Policajac policajac = await s.LoadAsync<Policajac>(id);

			p = new PolicajacView(policajac);

		}
		catch (Exception) {
			return "Nemoguće vratiti policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return p;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniPolicajcaAsync(PolicajacView policajac) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Policajac p = await s.LoadAsync<Policajac>(policajac.Id);

			p.Ime = policajac.Ime;
			p.ImeRoditelja = policajac.ImeRoditelja;
			p.Prezime = policajac.Prezime;
			p.JMBG = policajac.JMBG;
			p.Adresa = policajac.Adresa;
			p.DatumRodjenja = policajac.DatumRodjenja;
			p.DatumPrijemaUSluzbu = policajac.DatumPrijemaUSluzbu;
		

			if (policajac.RadiUStanici != null)
				p.Stanica = await s.LoadAsync<PolicijskaStanica>(policajac.RadiUStanici.Id);
			else
				p.Stanica = null;

			if (policajac.SefujeStanicom != null)
				p.SefujeStanicom = await s.LoadAsync<PolicijskaStanica>(policajac.SefujeStanicom.Id);
			else
				p.SefujeStanicom = null;
			if (policajac.ZamenikStanice != null)
				p.ZamenikStanice = await s.LoadAsync<PolicijskaStanica>(policajac.ZamenikStanice.Id);
			else
				p.ZamenikStanice = null;

			p.Tip = policajac.Tip;

			await s.SaveOrUpdateAsync(p);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiPolicajcaAsync(int id) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Policajac policajac = await s.LoadAsync<Policajac>(id);

			IEnumerable<Unapredjenje> unapredjenja = from u in s.Query<Unapredjenje>()
													 where u.Id.Policajac.Id == policajac.Id
													 select u;

			IEnumerable<Obrazovanje> obrazovanja = from o in s.Query<Obrazovanje>()
												   where o.Id.PolicajacObrazovanje.Id == policajac.Id
												   select o;


			foreach (var u in unapredjenja)
				await s.DeleteAsync(u);

			foreach (var o in obrazovanja)
				await s.DeleteAsync(o);

			await s.DeleteAsync(policajac);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja policajca".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static async Task<Result<List<PolicajacView>, ErrorMessage>> VratiPolicajceZaStanicuAsync(int id) {

		List<PolicajacView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Policajac>()
				.Where(p => p.Stanica.Id == id)
				.ListAsync())
				.Select<Policajac, PolicajacView>(p => {

					var type = p.GetType();

					if (type == typeof(PatrolniPolicajac)) {
						return new((PatrolniPolicajac)p);
					}
					else if (type == typeof(PolicajacPozornik)) {
						return new((PolicajacPozornik)p);
					}
					else if (type == typeof(RadnikUUpravi)) {
						return new((RadnikUUpravi)p);
					}
					else if (type == typeof(SkolskiPolicajac)) {
						return new((SkolskiPolicajac)p);
					}
					else //if (type == typeof(PZaVanredneSituacije)) {
						return new((PZaVanredneSituacije)p);
					//}
					//else return null;

				}).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o policajcima za datu stanicu".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}


	/* TODO:
	 * OR NOT TODO
	 * THE QUESTION IS NOW	
	 */
	#region Patrolni policajac

	//...

	#endregion

	#region Policajac pozornik

	//...

	#endregion

	#region Policajac za vanredne situacije

	//...

	#endregion

	#region Radnik u upravi

	//...

	#endregion

	#region Skolski policajac

	//...

	#endregion

	#endregion

	#region Unapredjenja


	public static async Task<Result<List<UnapredjenjeView>, ErrorMessage>> VratiUnapredjenjaZaPolicajcaAsync(int policajacId) {

		List<UnapredjenjeView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Unapredjenje>()
					.Where(u => u.Id.Policajac.Id == policajacId)
					.ListAsync()
				).Select(u => new UnapredjenjeView(u)).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o unpredjenjima za datog policajca".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<bool, ErrorMessage>> SacuvajUnapredjenjeZaPolicajcaAsync(UnapredjenjeView uv, int policajacId) {

		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Unapredjenje u = new() {

				Cin = uv.Cin,
				Id = new UnapredjenjeId() { 
					
					DatumSticanja = uv.DatumSticanja,
					Policajac = await s.LoadAsync<Policajac>(policajacId)
				}
			};

			await s.SaveAsync(u);
			await s.FlushAsync();

		}
		catch (Exception) {
			return "Nemoguće sačuvati unapredjnje datog policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<UnapredjenjeView, ErrorMessage>> VratiUnapredjenjeAsync(int policajacId, DateTime datumSticanja) {
		ISession? s = null;
		UnapredjenjeView u = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Unapredjenje unapredjenje = await s.LoadAsync<Unapredjenje>(new UnapredjenjeId() {
				DatumSticanja = datumSticanja,
				Policajac = await s.LoadAsync<Policajac>(policajacId)
			});

			u = new UnapredjenjeView(unapredjenje);

		}
		catch (Exception) {
			return "Nemoguće vratiti unapredjenje datog policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return u;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniUnapredjenjeZaPolicajcaAsync(UnapredjenjeView unapredjenje, int policajacId) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Unapredjenje u = await s.LoadAsync<Unapredjenje>(new UnapredjenjeId() {
				Policajac = await s.LoadAsync<Policajac>(policajacId),
				DatumSticanja = unapredjenje.DatumSticanja
			});

			u.Cin = unapredjenje.Cin;

			await s.SaveOrUpdateAsync(u);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti unapredjenje datog policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiUnapredjenjeZaPolicajcaAsync(UnapredjenjeView uv, int policajacId) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Unapredjenje u = await s.LoadAsync<Unapredjenje>(new UnapredjenjeId {
				DatumSticanja = uv.DatumSticanja,
				Policajac = await s.LoadAsync<Policajac>(policajacId)
			});

			await s.DeleteAsync(u);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja unapredjenja za datog policajca".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}


	#endregion

	#region Obrazovanje


	public static async Task<Result<List<ObrazovanjeView>, ErrorMessage>> VratiSvaObrazovanjaZaPolicajcaAsync(int policajacId) {

		List<ObrazovanjeView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Obrazovanje>()
						.Where(o => o.Id.PolicajacObrazovanje.Id == policajacId)
						.ListAsync()
					).Select(o => new ObrazovanjeView(o)).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o obrazovanju za datog policajca".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<bool, ErrorMessage>> SacuvajObrazovanjeZaPolicajcaAsync(ObrazovanjeView ov, int policajacId) {

		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Obrazovanje o = new() {

				Id = new ObrazovanjeId() {

					DatumDiplomiranja = ov.DatumDipolomirnja,
					Skola = ov.Skola,
					PolicajacObrazovanje = await s.LoadAsync<Policajac>(policajacId)
				}
				
			};

			await s.SaveAsync(o);
			await s.FlushAsync();

		}
		catch (Exception) {
			return "Nemoguće sačuvati obrazovanje datog policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}


	//NEMA SMISLA
	/*
	public async static Task<Result<UnapredjenjeView, ErrorMessage>> VratiUnapredjenjeAsync(int policajacId, DateTime datumSticanja) {
		ISession? s = null;
		UnapredjenjeView u = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Unapredjenje unapredjenje = await s.LoadAsync<Unapredjenje>(new UnapredjenjeId() {
				DatumSticanja = datumSticanja,
				Policajac = await s.LoadAsync<Policajac>(policajacId)
			});

			u = new UnapredjenjeView(unapredjenje);

		}
		catch (Exception) {
			return "Nemoguće vratiti unapredjenje datog policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return u;
	}
	*/

	//NEMA SMISLA
	/*
	public async static Task<Result<bool, ErrorMessage>> IzmeniObrazovanjeZaPolicajcaAsync(ObrazovanjeView staroObrazovanje,
																							Obrazovanje novoObrazovanje,
																							int policajacId) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Obrazovanje o = await s.LoadAsync<Obrazovanje>(new ObrazovanjeId() {
				PolicajacObrazovanje = await s.LoadAsync<Policajac>(policajacId),
				DatumDiplomiranja = staroObrazovanje.DatumDipolomirnja,
				Skola = staroObrazovanje.Skola
			});

			o.Cin = unapredjenje.Cin;

			await s.SaveOrUpdateAsync(u);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti obrazovanje datog policajca.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}
	*/

	public async static Task<Result<bool, ErrorMessage>> ObrisiObrazovanjeZaPolicajcaAsync(ObrazovanjeView ov, int policajacId) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Obrazovanje o = await s.LoadAsync<Obrazovanje>(new ObrazovanjeId{
				DatumDiplomiranja = ov.DatumDipolomirnja,
				Skola = ov.Skola,
				PolicajacObrazovanje = await s.LoadAsync<Policajac>(policajacId)
			});

			await s.DeleteAsync(o);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja obrazovanja za datog policajca".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}


	#endregion

	#region Policijska stanica


	public static async Task<Result<List<PolicijskaStanicaView>, ErrorMessage>> VratiSvePolicijskeStaniceLicaAsync() {

		List<PolicijskaStanicaView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<PolicijskaStanica>().ListAsync()).Select(p => new PolicijskaStanicaView(p)).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o policijskim stanicama".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<int, ErrorMessage>> SacuvajPolicijskuStanicuAsync(PolicijskaStanicaView policijskaStanica) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			PolicijskaStanica p = new() {

				Naziv = policijskaStanica.Naziv,
				Opstina = policijskaStanica.Opstina,
				Adresa = policijskaStanica.Adresa,
				DatumOsnivanja = policijskaStanica.DatumOsnivanja,
				BrojVozila = policijskaStanica.BrojVozila
			};

			await s.SaveAsync(p);
			await s.FlushAsync();

			id = p.Id;
		}
		catch (Exception) {
			return "Nemoguće sačuvati policijsku stanicu.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return id;
	}

	public async static Task<Result<PolicijskaStanicaView, ErrorMessage>> VratiPolicijskuStanicuAsync(int id) {
		ISession? s = null;
		PolicijskaStanicaView p = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			PolicijskaStanica policijskaStanica = await s.LoadAsync<PolicijskaStanica>(id);

			p = new PolicijskaStanicaView(policijskaStanica);

		}
		catch (Exception) {
			return "Nemoguće vratiti policijsku stanicu.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return p;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniPolicijskuStanicuAsync(PolicijskaStanicaView policijskaStanica) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			PolicijskaStanica ps = await s.LoadAsync<PolicijskaStanica>(policijskaStanica.Id);

			ps.Naziv = policijskaStanica.Naziv;
			ps.Opstina = policijskaStanica.Opstina;
			ps.Adresa = policijskaStanica.Adresa;
			ps.DatumOsnivanja = policijskaStanica.DatumOsnivanja;
			ps.BrojVozila = policijskaStanica.BrojVozila;

			await s.SaveOrUpdateAsync(ps);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti policijsku stanicu.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiPolicijskuStanicuAsync(int id) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			PolicijskaStanica policijskaStanica = await s.LoadAsync<PolicijskaStanica>(id);

			IEnumerable<Objekat> objekti = from o in s.Query<Objekat>()
										   where o.PolicijskaStanica.Id == id
										   select o;

			foreach (var o in objekti) {

				IEnumerable<BrojTelefona> brojeviTelefona = from bt in s.Query<BrojTelefona>()
															where bt.Id.ObjekatZaBroj.Id == o.Id
															select bt;

				foreach (var bt in brojeviTelefona)
					await s.DeleteAsync(bt);


				IEnumerable<AlarmniSistem> alarmniSistemi = from aa in s.Query<AlarmniSistem>()
															where aa.PripadaObjektu.Id == o.Id
															select aa;

				foreach (var a in alarmniSistemi) {

					IEnumerable<Odrzava> odrzavanja = from od in s.Query<Odrzava>()
													  where od.Id.AlarmniSistem.Id == a.Id
													  select od;

					foreach (var od in odrzavanja) {
						await s.DeleteAsync(od);
					}

					await s.DeleteAsync(a);
				}

				await s.DeleteAsync(o);
			}

			await s.DeleteAsync(policijskaStanica);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja policijske stanice".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ProveriDaLiStanicaImaSefaAsync(int stanicaId) {

		ISession? s = null;
		bool ans= true;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			ans = (await s.QueryOver<Policajac>()
				.Where(p => p.SefujeStanicom.Id == stanicaId)
				.ListAsync()).IsEmpty();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom postojanja sefa za datu stanicu".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return ans;
	}


	#endregion

	#region Objekat


	public static async Task<Result<List<ObjekatView>, ErrorMessage>> VratiSveObjekteAsync() {

		List<ObjekatView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Objekat>().ListAsync()).Select(o => new ObjekatView(o)).ToList();


		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o objektima".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<int, ErrorMessage>> SacuvajObjekatAsync(ObjekatView objekat) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Objekat o = new() {

				Tip = objekat.Tip,
				Adresa = objekat.Adresa,
				Povrsina = objekat.Povrsina,
				KontaktIme = objekat.KontaktIme,
				KontaktPrezime = objekat.KontaktPrezime,

				PolicijskaStanica = await s.LoadAsync<PolicijskaStanica>(objekat.PolicijskaStanica.Id),
			};

			await s.SaveAsync(o);
			await s.FlushAsync();

			id = o.Id;
		}
		catch (Exception) {
			return "Nemoguće sačuvati objekat.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return id;
	}

	public async static Task<Result<ObjekatView, ErrorMessage>> VratiObjekatAsync(int id) {
		ISession? s = null;
		ObjekatView o = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Objekat objekat = await s.LoadAsync<Objekat>(id);

			o = new ObjekatView(objekat);

		}
		catch (Exception) {
			return "Nemoguće vratiti objekat.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return o;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniObjekatAsync(ObjekatView objekat) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Objekat o = await s.LoadAsync<Objekat>(objekat.Id);

			o.Tip = objekat.Tip;
			o.Adresa = objekat.Adresa;
			o.Povrsina = objekat.Povrsina;
			o.KontaktIme = objekat.KontaktIme;
			o.KontaktPrezime = objekat.KontaktPrezime;
			o.PolicijskaStanica = await s.LoadAsync<PolicijskaStanica>(objekat.PolicijskaStanica.Id);

			await s.SaveOrUpdateAsync(o);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti objekat.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiObjekatAsync(int id) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Objekat objekat = await s.LoadAsync<Objekat>(id);



			IEnumerable<BrojTelefona> brojeviTelefona = from bt in s.Query<BrojTelefona>()
														where bt.Id.ObjekatZaBroj.Id == id
														select bt;

			foreach (var bt in brojeviTelefona)
				await s.DeleteAsync(bt);


			IEnumerable<AlarmniSistem> alarmniSistemi = from aa in s.Query<AlarmniSistem>()
														where aa.PripadaObjektu.Id == id
														select aa;

			foreach (var a in alarmniSistemi) {

				IEnumerable<Odrzava> odrzavanja = from od in s.Query<Odrzava>()
												  where od.Id.AlarmniSistem.Id == a.Id
												  select od;

				foreach (var od in odrzavanja) {
					await s.DeleteAsync(od);
				}

				await s.DeleteAsync(a);
			}

			await s.DeleteAsync(objekat);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja objekta".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<List<ObjekatView>, ErrorMessage>> VratiObjekteZaPolicijskuStanicuAsync(int stanicaId) {

		List<ObjekatView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Objekat>()
						.Where(o => o.PolicijskaStanica.Id == stanicaId)
						.ListAsync()
					).Select(o => new ObjekatView(o)).ToList();


		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o objektima za datu stanicu".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}


	#endregion

	#region Telefoni za objekat


	public static async Task<Result<List<BrojTelefonaView>, ErrorMessage>> VratiSveTelefoneZaObjekatAsync(int objekatId) {

		List<BrojTelefonaView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<BrojTelefona>().ListAsync()).Select(bt => new BrojTelefonaView(bt)).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o brojevima telefona za dati objekat".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<bool, ErrorMessage>> SacuvajBrojTelefonaZaObjekatAsync(BrojTelefonaView btv, int objekatId) {

		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			BrojTelefona bt = new() {

				Id = new() {
					Broj = btv.Broj,
					ObjekatZaBroj = await s.LoadAsync<Objekat>(objekatId)
				}
			};

			await s.SaveAsync(bt);
			await s.FlushAsync();

		}
		catch (Exception) {
			return "Nemoguće sačuvati broj telefona.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	//NEMA SMISLA
	/*
	public async static Task<Result<VoziloView, ErrorMessage>> VratiBrojTelefonaAsync(int id) {
		ISession? s = null;
		VoziloView v = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Vozilo vozilo = await s.LoadAsync<Vozilo>(id);

			v = new VoziloView(vozilo);

		}
		catch (Exception) {
			return "Nemoguće vratiti vozilo.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return v;
	}
	*/

	//NEMA SMISLA
	/*
	public async static Task<Result<bool, ErrorMessage>> IzmeniBrojTelefonaZaObjekatAsync(BrojTelefonaView noviBroj,
																							BrojTelefonaView stariBroj,
																							int objekatId) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			BrojTelefona bt = await s.LoadAsync<BrojTelefona>(new BrojTelefonaId() { 
				ObjekatZaBroj = await s.LoadAsync<Objekat>(objekatId),
				Broj = stariBroj.Broj
			});

			bt.Id.Broj = noviBroj.Broj;

			await s.SaveOrUpdateAsync(bt);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti broj telefona za dati objekat.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}
	*/

	public async static Task<Result<bool, ErrorMessage>> ObrisiBrojTelefonaZaObjekatAsync(BrojTelefonaView btv, int objekatId) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			BrojTelefona bt = await s.LoadAsync<BrojTelefona>(new BrojTelefonaId() { 
				Broj = btv.Broj,
				ObjekatZaBroj = await s.LoadAsync<Objekat>(objekatId)
			});

			await s.DeleteAsync(bt);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja broja telefona datog objekta".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}


	#endregion

	#region Patrola


	public static async Task<Result<List<PatrolaView>, ErrorMessage>> VratiSvePatroleAsync() {

		List<PatrolaView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Patrola>().ListAsync()).Select(p => new PatrolaView(p)).ToList();


		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o patrolama".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<int, ErrorMessage>> SacuvajPatroluAsync(PatrolaView patrolaView) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Patrola p = patrolaView.ToPatrola();

			await s.SaveAsync(p);
			await s.FlushAsync();

			id = p.RedniBroj;
		}
		catch (Exception) {
			return "Nemoguće sačuvati vozilo.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return id;
	}

	public async static Task<Result<PatrolaView, ErrorMessage>> VratiPatroluAsync(int id) {
		ISession? s = null;
		PatrolaView p = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Patrola patrola = await s.LoadAsync<Patrola>(id);

			p = new PatrolaView(patrola);

		}
		catch (Exception) {
			return "Nemoguće vratiti patrolu.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return p;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniPatroluAsync(PatrolaView patrola) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Patrola p = await s.LoadAsync<Patrola>(patrola.RedniBroj);

			p.RedniBroj = patrola.RedniBroj;
			p.DuziVozilo = patrola.Vozilo.ToVozilo();
			p.Sef = patrola.Sef.ToPatrolniPolicajac();
			p.Pomocnik = patrola.Pomocnik.ToPatrolniPolicajac();

			await s.SaveOrUpdateAsync(p);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti patrolu.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiPatroluAsync(int id) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Patrola patrola = await s.LoadAsync<Patrola>(id);

			await s.DeleteAsync(patrola);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja patrole".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}


	#endregion

	#region Alarmni sistem


	public static async Task<Result<int, ErrorMessage>> SacuvajAlarmniSistemAsync(AlarmniSistemView asv) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			AlarmniSistem a = asv.ToAlarmniSistem();

			await s.SaveAsync(a);
			await s.FlushAsync();

			id = a.Id;
		}
		catch (Exception) {
			return "Nemoguće sačuvati alarmni sistem.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return id;
	}

	public async static Task<Result<AlarmniSistemView, ErrorMessage>> VratiAlarmniSistemAsync(int id) {
		ISession? s = null;
		AlarmniSistemView asv = default!;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			AlarmniSistem a = await s.LoadAsync<AlarmniSistem>(id);

			var type = a.GetType();

			if (type == typeof(UltrazvucniAS)) {
				asv =  new UltrazvucniASView((UltrazvucniAS)a);
			}
			else if (type == typeof(ASDetekcijePokreta)) {
				asv =  new ASDetekcijePokretaView((ASDetekcijePokreta)a);
			}
			else //if (type == typeof(ASDetekcijeToplotnogOdraza)) {
				asv =  new ASDetekcijeToplotnogOdrazaView((ASDetekcijeToplotnogOdraza)a);
			//}
			//else return null;

		}
		catch (Exception) {
			return "Nemoguće vratiti alarmni sistem.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return asv;
	}

	public async static Task<Result<bool, ErrorMessage>> IzmeniAlarmniSistemAsync(AlarmniSistemView asv) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			AlarmniSistem a = await s.LoadAsync<AlarmniSistem>(asv.Id);

			a.SerijskiBroj = asv.SerijskiBroj;
			a.Proizvodjac = asv.Proizvodjac;
			a.Model = asv.Model;
			a.GodinaProizvodnje = asv.GodinaProizvodnje;
			a.DatumPoslednjegServisiranja = asv.DatumPoslednjegServisiranja;
			a.DatumInstalacije = asv.DatumInstalacije;
			a.DatumPoslednjegAtesta = a.DatumPoslednjegAtesta;
			a.OpisOtklonjenogKvara = asv.OpisOtklonjenogKvara;

			a.PripadaObjektu = asv.PripadaObjektu.ToObjekat();

			a.Tip = asv.VratiTip();

			switch (asv.Tip) {
				case TipAlarmnogSistema.Ultrazvucni:
				((UltrazvucniAS)a).GornjaGranica = ((UltrazvucniASView)asv).GornjaGranica;
				((UltrazvucniAS)a).DonjaGranica = ((UltrazvucniASView)asv).DonjaGranica;
				break;
				case TipAlarmnogSistema.DetekcijePokreta:
				((ASDetekcijePokreta)a).Osetljivost = ((ASDetekcijePokretaView)asv).Osetljivost;
				break;
				case TipAlarmnogSistema.DetekcijeToplotnogOdraza:
				((ASDetekcijeToplotnogOdraza)a).HorRezIcKamere = ((ASDetekcijeToplotnogOdrazaView)asv).HorRezIcKamere;
				((ASDetekcijeToplotnogOdraza)a).VerRezIcKamere = ((ASDetekcijeToplotnogOdrazaView)asv).VerRezIcKamere;
				break;

			}

			await s.SaveOrUpdateAsync(a);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti alarmni sistem.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiAlarmniSistemAsync(int id) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			AlarmniSistem a = await s.LoadAsync<AlarmniSistem>(id);

			IEnumerable<Odrzava> odrzavanja = from od in s.Query<Odrzava>()
											  where od.Id.AlarmniSistem.Id == a.Id
											  select od;

			foreach (var od in odrzavanja) {
				await s.DeleteAsync(od);
			}

			await s.DeleteAsync(a);

			await s.DeleteAsync(a);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja alarmnog sistema".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static async Task<Result<List<AlarmniSistemView>, ErrorMessage>> VratiAlarmneSistemeZaObjekatAsync(int objekatId) {

		List<AlarmniSistemView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<AlarmniSistem>()
				.Where(p => p.PripadaObjektu.Id == objekatId)
				.ListAsync())
				.Select<AlarmniSistem, AlarmniSistemView>(a => {

					var type = a.GetType();

					if (type == typeof(UltrazvucniAS)) {
						return new UltrazvucniASView((UltrazvucniAS)a);
					}
					else if (type == typeof(ASDetekcijePokreta)) {
						return new ASDetekcijePokretaView((ASDetekcijePokreta)a);
					}
					else //if (type == typeof(ASDetekcijeToplotnogOdraza)) {
						return new ASDetekcijeToplotnogOdrazaView((ASDetekcijeToplotnogOdraza)a);
					//}
					//else return null;

				}).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o alarnmnim sistemima za dati objekat".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}


	#endregion

	#region Odrzava


	public static async Task<Result<bool, ErrorMessage>> SacuvajOdrzavaAsync(OdrzavaView ov) {

		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Odrzava o = ov.ToOdrzava();

			await s.SaveAsync(o);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće sačuvati odrzavanje.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiOdrzavaAsync(OdrzavaView ov) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Odrzava o = await s.LoadAsync<Odrzava>(new OdrzavaId() { 
				AlarmniSistem = await s.LoadAsync<AlarmniSistem>(ov.AlarmniSistem.Id),
				PocetniDatum = ov.Pocetak,
				Tehnicar = await s.LoadAsync<TehnickoLice>(ov.TehnickoLice.Id),			
			});

			await s.DeleteAsync(o);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Greška prilikom brisanja odrzavanja".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static async Task<Result<List<OdrzavaView>, ErrorMessage>> VratiIstorijuOdrzavanjaZaTehnickoLiceAsync(int tehnicarId) {

		List<OdrzavaView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Odrzava>()
						.Where(p => p.Id.Tehnicar.Id == tehnicarId)
						.ListAsync()
					)
					.Select<Odrzava, OdrzavaView>(o => new OdrzavaView(o)).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o istoriji odrzavanja za dato tehnicko lice".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<List<OdrzavaView>, ErrorMessage>> VratiIstorijuOdrzavanjaZaAlarmniSistemAsync(int alarmniSistemId) {

		List<OdrzavaView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Odrzava>()
						.Where(p => p.Id.AlarmniSistem.Id == alarmniSistemId)
						.ListAsync()
					)
					.Select<Odrzava, OdrzavaView>(o => new OdrzavaView(o)).ToList();

		}
		catch (Exception) {

			return "Došlo je do greške prilikom prikupljanja informacija o istoriji odrzavanja za dati alarmni sistem".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return data;
	}


    #endregion
}