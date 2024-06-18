using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VoziloControllers : ControllerBase
{
    [HttpPost]
    [Route("DodajVozilo")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddVozilo([FromBody] VoziloView v)
    {
        var data = await DataProvider.SacuvajVoziloAsync(v);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodato vozilo: {v.RegOznaka}");
    }

    [HttpGet]
    [Route("PreuzmiSvaVozila")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetVozila()
    {
        var vozila = await DataProvider.VratiSvaVozilaAsync();

        if (vozila.IsError)
        {
            return StatusCode(vozila.Error.StatusCode, vozila.Error.Message);
        }

        return Ok(vozila.Data);
    }

    [HttpGet]
    [Route("PreuzmiVozilo/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetVozilo(int id)
    {
        var vozilo = await DataProvider.VratiVoziloAsync(id);

        if (vozilo.IsError)
        {
            return StatusCode(vozilo.Error.StatusCode, vozilo.Error.Message);
        }

        return Ok(vozilo.Data);
    }

    [HttpPut]
    [Route("PromeniVozilo")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeVozilo([FromBody] VoziloView v)
    {
        (bool isError, var vozilo, var error) = await DataProvider.IzmeniVoziloAsync(v);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok($"Uspesno je izmenjeno vozilo: {v.RegOznaka}");
    }

    [HttpDelete]
    [Route("IzbrisiVozilo/{id}")]  // PROVERITI!!!
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeleteVozilo(int id)
    {
        var data = await DataProvider.ObrisiVoziloAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisano vozilo: {data.Data}.");
    }

}

