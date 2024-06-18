using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
using PolicijskaUpravaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class OdrzavaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiIstorijuOdrzavanjaTehnickoLice/{tehnicarId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetIstorijaOdrzavanjaTehnickoLice(int tehnicarId)
    {
        var result = await DataProvider.VratiIstorijuOdrzavanjaZaTehnickoLiceAsync(tehnicarId);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok(result.Data);
    }

    [HttpGet]
    [Route("PreuzmiIstorijuOdrzavanjaAlarmniSistem/{alarmniSistemId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetIstorijaOdrzavanjaAlarmniSistem(int alarmniSistemId)
    {
        var result = await DataProvider.VratiIstorijuOdrzavanjaZaAlarmniSistemAsync(alarmniSistemId);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok(result.Data);
    }

    [HttpPost]
    [Route("DodajOdrzavanje")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddOdrzavanje([FromBody] OdrzavaView o)
    {
        var result = await DataProvider.SacuvajOdrzavaAsync(o);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodato održavanje za tehničara ID: {o.TehnickoLice.Id} i alarmni sistem ID: {o.AlarmniSistem.Id}");
    }


    [HttpDelete]
    [Route("IzbrisiOdrzavanje")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeleteOdrzavanje([FromBody] OdrzavaView o)
    {
        var result = await DataProvider.ObrisiOdrzavaAsync(o);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return NoContent();
    }
}
