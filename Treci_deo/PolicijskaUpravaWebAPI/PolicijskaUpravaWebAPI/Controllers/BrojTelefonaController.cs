using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BrojTelefonaControllers : ControllerBase
{
    [HttpPost]
    [Route("SacuvajBrojTelefonaZaObjekat/{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> SacuvajBrojTelefonaZaObjekat([FromBody] BrojTelefonaView ov, int id)
    {
        var data = await DataProvider.SacuvajBrojTelefonaZaObjekatAsync(ov, id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat broj telefona za objekat : {id}");
    }

    [HttpGet]
    [Route("VratiSveTelefoneZaObjekat/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiSveTelefoneZaObjekat(int id)
    {
        var data = await DataProvider.VratiSveTelefoneZaObjekatAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(data.Data);
    }

    [HttpDelete]
    [Route("ObrisiObrazovanjeZaPolicajca/{id}")]  // PROVERITI!!!
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ObrisiObrazovanjeZaPolicajca([FromBody] BrojTelefonaView ov, int id)
    {
        var data = await DataProvider.ObrisiBrojTelefonaZaObjekatAsync(ov, id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan broj telefona: {data.Data}.");
    }

}

