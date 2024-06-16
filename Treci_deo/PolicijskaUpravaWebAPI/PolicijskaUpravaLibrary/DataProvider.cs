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

	public static async Task<Result<string, ErrorMessage>> SacuvajVoziloAsync(VoziloView vozilo) {

		ISession? s = null;
		string? id = null;

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

			id = v.RegOznaka;
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

	public async static Task<Result<bool, ErrorMessage>> IzmeniVoziloAsync(VoziloView vozilo) {
		ISession? s = null;

		try {
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false)) {
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Vozilo v = await s.LoadAsync<Vozilo>(vozilo.RegOznaka);

			v.Tip = vozilo.Tip;
			v.Boja = vozilo.Boja;
			v.Proizvodjac = vozilo.Proizvodjac;
			v.Model = vozilo.Model;

			await s.SaveOrUpdateAsync(v);
			await s.FlushAsync();
		}
		catch (Exception) {
			return "Nemoguće izmeniti odeljenje do 5 godina.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public async static Task<Result<bool, ErrorMessage>> ObrisiVoziloAsync(string id) {
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
			return "Greška prilikom brisanja odeljenja.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return true;
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
			return "Nemoguće vratiti odeljenja.".ToError(400);
		}
		finally {
			s?.Close();
			s?.Dispose();
		}

		return v;
	}


	#endregion



}