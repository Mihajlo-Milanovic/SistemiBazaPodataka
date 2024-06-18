using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PolicijskaStanicaControllers : ControllerBase
{
    [HttpPost]
    [Route("DodajStanicu")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajStanicu([FromBody] PolicijskaStanicaView ov)
    {
        var data = await DataProvider.SacuvajPolicijskuStanicuAsync(ov);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodata stanica sa idjem: {data.Data}");
    }

    [HttpGet]
    [Route("VratiSveStanice")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiSveStanice()
    {
        var data = await DataProvider.VratiSvePolicijskeStaniceLicaAsync();

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }

    [HttpGet]
    [Route("VratiPolicijskuStanicu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiPolicijskuStanicu(int id)
    {
        var data = await DataProvider.VratiPolicijskuStanicuAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }


    [HttpPut]
    [Route("PromeniStanicu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PromeniStanicu([FromBody] PolicijskaStanicaView v)
    {
        (bool isError, var stanica, var error) = await DataProvider.IzmeniPolicijskuStanicuAsync(v);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(stanica);
    }


    [HttpDelete]
    [Route("ObrisiPolicijskuStanicu/{id}")]  
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ObrisiPolicijskuStanicu(int id)
    {
        var data = await DataProvider.ObrisiPolicijskuStanicuAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisana stanica: {data.Data}.");
    }

    [HttpGet]
    [Route("VratiObjekteZaPolicijskuStanicu/{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiObjekteZaPolicijskuStanicu(int id)
    {
        var data = await DataProvider.VratiObjekteZaPolicijskuStanicuAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }

    [HttpGet]
    [Route("VratiPolicajceZaStanicu/{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiPolicajceZaStanicu(int id)
    {
        var data = await DataProvider.VratiPolicajceZaStanicuAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }

    [HttpGet]
    [Route("ProveriDaLiStanicaImaSefa/{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ProveriDaLiStanicaImaSefa(int id)
    {
        var data = await DataProvider.ProveriDaLiStanicaImaSefaAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }


}

