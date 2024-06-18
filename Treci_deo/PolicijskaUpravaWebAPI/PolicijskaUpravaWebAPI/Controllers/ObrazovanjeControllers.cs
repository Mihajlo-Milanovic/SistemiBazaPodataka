using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ObrazovanjeControllers : ControllerBase
{
    [HttpPost]
    [Route("DodajObrazovanje/{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> SacuvajObrazovanjeZaPolicajca([FromBody] ObrazovanjeView ov,int id)
    {
        var data = await DataProvider.SacuvajObrazovanjeZaPolicajcaAsync(ov,id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodato obrazovanje za policajca : {id}");
    }

    [HttpGet]
    [Route("PreuzmiSvaObrazovanjaZaPolicajca/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> VratiSvaObrazovanjaZaPolicajca(int id)
    {
        var data = await DataProvider.VratiSvaObrazovanjaZaPolicajcaAsync(id);

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
    public async Task<IActionResult> ObrisiObrazovanjeZaPolicajca([FromBody] ObrazovanjeView ov,int id)
    {
        var data = await DataProvider.ObrisiObrazovanjeZaPolicajcaAsync(ov,id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisano obrazovanje: {data.Data}.");
    }

}

