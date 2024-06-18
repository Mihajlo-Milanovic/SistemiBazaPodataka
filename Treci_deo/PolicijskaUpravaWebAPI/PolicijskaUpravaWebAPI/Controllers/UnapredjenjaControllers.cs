using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;
using PolicijskaUpravaLibrary.Entiteti;


namespace PolicijskaUpravaLibrary;


[ApiController]
[Route("[controller]")]
public class UnapredjenjeControllers : ControllerBase
{
    [HttpPost]
    [Route("DodajUnapredjenjeZaPolicajca/{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddUnapredjenjeZaPolicajca([FromBody] UnapredjenjeView uv,int id)
    {
        var data = await DataProvider.SacuvajUnapredjenjeZaPolicajcaAsync(uv,id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok($"Uspešno dodato unapredjenje: {data.Data} za policajca: {id}.");
    }

    [HttpGet] // PROVERITI!!!!
    [Route("PreuzmiSvaUnapredjenja/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetUnapredjenja(int id)
    {
        (bool isError, var unapredjenja, var error) = await DataProvider.VratiUnapredjenjaZaPolicajcaAsync(id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(unapredjenja);
    }


    [HttpPut]
    [Route("VratiUnapredenjeZaPolicajcaIDatum/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetUnapredjnje(int idPolicajca,[FromBody] DateTime datumSticanja)
    {
        (bool isError, var unapredjenje, var error) = await DataProvider.VratiUnapredjenjeAsync(idPolicajca, datumSticanja);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(unapredjenje);
    }

    [HttpPut]
    [Route("IzmeniUnapredenjeZaPolicajca/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetUnapredjnje(int id,[FromBody] UnapredjenjeView uv)
    {
        (bool isError, var unapredjenje, var error) = await DataProvider.IzmeniUnapredjenjeZaPolicajcaAsync(uv, id);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(unapredjenje);
    }

    [HttpDelete]
    [Route("IzbrisiUnapredjenje/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeleteUnapredjenje(int id, [FromBody] UnapredjenjeView uv)
    {
        var data = await DataProvider.ObrisiUnapredjenjeZaPolicajcaAsync(uv, id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan policajac: {data.Data}.");
    }
}

