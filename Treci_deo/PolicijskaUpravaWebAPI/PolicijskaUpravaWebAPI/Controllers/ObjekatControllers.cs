using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ObjekatControllers : ControllerBase
{
    [HttpPost]
    [Route("DodajObjekat")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> SacuvajObjekat([FromBody] ObjekatView ov)
    {
        var data = await DataProvider.SacuvajObjekatAsync(ov);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodato objekat");
    }

    [HttpGet]
    [Route("VratiSveObjekte")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiSveObjekte()
    {
        var data = await DataProvider.VratiSveObjekteAsync();

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }

    [HttpGet]
    [Route("VratiObjekat /{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiObjekat(int id)
    {
        var data = await DataProvider.VratiObjekatAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }


    [HttpPut]
    [Route("PromeniObjekat")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PromeniObjekat([FromBody] ObjekatView v)
    {
        (bool isError, var objekat, var error) = await DataProvider.IzmeniObjekatAsync(v);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(objekat);
    }


    [HttpDelete]
    [Route("ObrisiObrazovanjeZaPolicajca/{id}")]  // PROVERITI!!!
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ObrisiObrazovanjeZaPolicajca([FromBody] ObrazovanjeView ov, int id)
    {
        var data = await DataProvider.ObrisiObrazovanjeZaPolicajcaAsync(ov, id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisano objekat: {data.Data}.");
    }

}

