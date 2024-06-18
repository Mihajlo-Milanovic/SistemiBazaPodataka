using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
using PolicijskaUpravaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class PatrolaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiPatrolu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetPatrola(int id)
    {
        var patrola = await DataProvider.VratiPatroluAsync(id);

        if (patrola.IsError)
        {
            return StatusCode(patrola.Error.StatusCode, patrola.Error.Message);
        }

        return Ok(patrola.Data);
    }


    [HttpGet]
    [Route("PreuzmiSvePatrole")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetPatrole()
    {
        var patrole = await DataProvider.VratiSvePatroleAsync();

        if (patrole.IsError)
        {
            return StatusCode(patrole.Error.StatusCode, patrole.Error.Message);
        }

        return Ok(patrole.Data);
    }


    [HttpPost]
    [Route("DodajPatrolu")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddPatrola([FromBody] PatrolaView p)
    {
        var data = await DataProvider.SacuvajPatroluAsync(p);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodata patrola: {p.RedniBroj}");
    }

    [HttpPut]
    [Route("PromeniPatrolu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangePatrola([FromBody] PatrolaView p)
    {
        (bool isError, var patrola, var error) = await DataProvider.IzmeniPatroluAsync(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(patrola);
    }

    [HttpDelete]
    [Route("IzbrisiPatrolu/{id}")]  // PROVERITI!!!
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeletePatrola(int id)
    {
        var data = await DataProvider.ObrisiPatroluAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisana patrola: {data.Data}.");
    }
}

