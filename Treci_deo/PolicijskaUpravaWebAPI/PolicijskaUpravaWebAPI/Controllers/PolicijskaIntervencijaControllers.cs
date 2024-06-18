using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary.DTOs;
using PolicijskaUpravaLibrary;

namespace PolicijskaUpravaWebAPI.Controllers {

	[ApiController]
	[Route("[controller]")]
	public class PolicijskaIntervencijaControllers : ControllerBase {

		[HttpGet]
		[Route("PreuzmiPolicijskeIntervencijeZaPatrolu/{patrolaId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<IActionResult> GetPolicijskeIntervencijeZaPatrolu(int patrolaId) {

			var result = await DataProvider.VratiPolicijskeIntervencijeZaPatroluAsync(patrolaId);

			if (result.IsError) {
				return StatusCode(result.Error.StatusCode, result.Error.Message);
			}

			return Ok(result.Data);
		}

		[HttpGet]
		[Route("PreuzmiPolicijskeIntervencijeZaObjekat/{objekatId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<IActionResult> GetPolicijskeIntervencijeZaObjekat(int objeaktId) {

			var result = await DataProvider.VratiPolicijskeIntervencijeZaObjekatAsync(objeaktId);

			if (result.IsError) {
				return StatusCode(result.Error.StatusCode, result.Error.Message);
			}

			return Ok(result.Data);
		}

		[HttpGet]
		[Route("PreuzmiPolicijskeIntervencijeZaPatroluIObjekat/{patrolaId}/{objekatId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<IActionResult> GetPolicijskeIntervencijeZaPatroluIObjekat(int patrolaId, int objeaktId) {

			var result = await DataProvider.VratiPolicijskeIntervencijeZaPatroluIObjekatAsync(patrolaId, objeaktId);

			if (result.IsError) {
				return StatusCode(result.Error.StatusCode, result.Error.Message);
			}

			return Ok(result.Data);
		}





		[HttpGet]
		[Route("PreuzmiPolicijskuIntervenciju/{patrolaId}/{objekatId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<IActionResult> GetIstorijaOdrzavanjaAlarmniSistem(int patrolaId, int objekatId, [FromBody] DateTime datumIVreme) {
			var result = await DataProvider.VratiPolicijskuIntervencijuAsync(patrolaId, objekatId, datumIVreme);

			if (result.IsError) {
				return StatusCode(result.Error.StatusCode, result.Error.Message);
			}

			return Ok(result.Data);
		}

		[HttpPost]
		[Route("DodajPolicijskuIntervenciju")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<IActionResult> AddOdrzavanje([FromBody] PolicijskaIntervencijaView o) {
			var result = await DataProvider.SacuvajPolicijskuIntervencijuAsync(o);

			if (result.IsError) {
				return StatusCode(result.Error.StatusCode, result.Error.Message);
			}

			return StatusCode(201, $"Uspešno dodata intervencija za patrolu ID: {o.Patrola.RedniBroj} i objeakt ID: {o.Objekat.Id}");
		}

		[HttpPut]
		[Route("PromeniPolicijskeIntervenciju")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<IActionResult> PromeniPolicijskuIntervenciju([FromBody] PolicijskaIntervencijaView v) {
			(bool isError, var objekat, var error) = await DataProvider.IzmeniPolicijskuIntervencijuAsync(v);

			if (isError) {
				return StatusCode(error?.StatusCode ?? 400, error?.Message);
			}

			return Ok(objekat);
		}

		[HttpDelete]
		[Route("IzbrisiPolicijskeIntervenciju")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<IActionResult> DeleteOdrzavanje([FromBody] PolicijskaIntervencijaView o) {
			var result = await DataProvider.ObrisiPolicijskuIntervencijuAsync(o);

			if (result.IsError) {
				return StatusCode(result.Error.StatusCode, result.Error.Message);
			}

			return NoContent();
		}
	}


}
