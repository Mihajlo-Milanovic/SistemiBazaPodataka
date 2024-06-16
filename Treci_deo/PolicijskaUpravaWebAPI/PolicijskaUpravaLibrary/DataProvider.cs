using ProdavnicaLibrary;
using System.Globalization;

namespace PolicijskaUpravaLibrary;

public static class DataProvider {

	#region Vozilo

	public static async Task<Result<List<VoziloView>, ErrorMessage>> VratiSvaVozilaAsync() {

		List<VoziloView> data = new();

		ISession? s = null;

		try {

			s = DataLayer.GetSession();

			if(!(s?.IsConnected ?? false)) {

				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.QueryOver<Vozilo>().ListAsync()).Select(p => new VoziloView(p)).ToList(); 


		}catch(Exception) {

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

			Vozilo v = new() {

				RegOznaka = vozilo.RegOznaka,
				Model = vozilo.Model,
				Boja = vozilo.Boja,
				Proizvodjac = vozilo.Proizvodjac,
				Tip = vozilo.Tip
			};

			await s.SaveAsync(v);
			await s.FlushAsync();

			id = v.Id;
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

	public static async Task<Result<int, ErrorMessage>> SacuvajTehnickoLiceAsync(TehnickoLice tehnickoLice) {

		ISession? s = null;
		int id = default;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			TehnickoLice t = new() {

				Ime = tehnickoLice.Ime,
				Prezime = tehnickoLice.Prezime
			};

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

			TehnickoLice tehnickoLice= await s.LoadAsync<TehnickoLice>(id);

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

	internal static async Task<Result<int, ErrorMessage>> SacuvajPolicajcaLiceAsync(PolicajacView policajac) {

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
	
	internal async static Task<Result<PolicajacView, ErrorMessage>> VratiPolicajcaAsync(int id) {
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

		return t;
	}

	internal async static Task<Result<bool, ErrorMessage>> IzmeniPolicajcaAsync(PolicajacView policajac) {
		ISession? s = null;

		if(policajac == null)
			return "Losi podaci.".ToError(422);

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
			//Izmeniti View 

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
	
	internal async static Task<Result<bool, ErrorMessage>> ObrisiPolicajcaAsync(int id) {
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


	//provera ima li sefa

	#region Patrolni policajci

		//...

	#endregion


	#endregion
}