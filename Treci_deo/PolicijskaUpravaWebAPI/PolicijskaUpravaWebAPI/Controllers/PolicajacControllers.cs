using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;
using PolicijskaUpravaLibrary.Entiteti;


namespace PolicijskaUpravaLibrary;


[ApiController]
[Route("[controller]")]
public class PolicajacControllers : ControllerBase
{
    [HttpPost]
    [Route("DodajPolicajca")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddPolicajac([FromBody] PolicajacView pv)
    {
        var data = await DataProvider.SacuvajPolicajcaAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodaj policajac: {pv.Id}");
    }

    [HttpGet]
    [Route("PreuzmiSvePolicajce")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetPolicajce()
    {
        var policajci = await DataProvider.VratiSvePolicajceAsync();

        if (policajci.IsError)
        {
            return StatusCode(policajci.Error.StatusCode, policajci.Error.Message);
        }

        return Ok(policajci.Data);
    }

    [HttpGet]
    [Route("PreuzmiPolicajca/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetPolicajca(int id)
    {
        var policajc = await DataProvider.VratiPolicajcaAsync(id);

        if (policajc.IsError)
        {
            return StatusCode(policajc.Error.StatusCode, policajc.Error.Message);
        }

        return Ok(policajc.Data);
    }

    [HttpGet]
    [Route("PreuzmiPolicajceZaStanicu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetPolicajceZaStanicu(int idStanice)
    {
        var policajci = await DataProvider.VratiPolicajceZaStanicuAsync(idStanice);

        if (policajci.IsError)
        {
            return StatusCode(policajci.Error.StatusCode, policajci.Error.Message);
        }

        return Ok(policajci.Data);
    }

    [HttpPut]
    [Route("PromeniPolicajca")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangePolicajac([FromBody] PolicajacView pv)
    {
        (bool isError, var policajac, var error) = await DataProvider.IzmeniPolicajcaAsync(pv);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(pv);
    }


    [HttpDelete]
    [Route("IzbrisiPolicajca/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeletePolicajac(int id)
    {
        var data = await DataProvider.ObrisiPolicajcaAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan policajac: {data.Data}.");
    }
}

