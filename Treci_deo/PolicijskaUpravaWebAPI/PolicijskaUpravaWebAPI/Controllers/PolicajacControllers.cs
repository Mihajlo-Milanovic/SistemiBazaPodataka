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
    [Route("DodajPatrlonogPolicajca")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddPatrolnogPolicajac([FromBody] PatrolniPolicajacView pv)
    {
        var data = await DataProvider.SacuvajPatrolnogPolicajcaAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat patrolni policajac: {pv.Id}");
    }

    [HttpPost]
    [Route("DodajPolicajcaZaVanredneSituacije")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddPolicajcaZaVanrednePolicajce([FromBody] PZaVanredneSituacijeView pv)
    {
        var data = await DataProvider.SacuvajPolicajcaZaVanredneSituacijeAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat policajac za vanredne policajce: {pv.Id}");
    }

    [HttpPost]
    [Route("DodajSkolskogPolicajca")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddSkolskiPolicajac([FromBody] SkolskiPolicajacView pv)
    {
        var data = await DataProvider.SacuvajSkolskogPolicajcaAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat skolski policajac: {pv.Id}");
    }

    [HttpPost]
    [Route("DodajRanikUUpravi")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddRadnikaUUpravi([FromBody] RadnikUUpraviView pv)
    {
        var data = await DataProvider.SacuvajRadnikaUUpraviAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat radnik u upravi: {pv.Id}");
    }

    [HttpPost]
    [Route("DodajPolicajcaPozornika")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddPolicajacPozornik([FromBody] PolicajacPozornikView pv)
    {
        var data = await DataProvider.SacuvajPolicajcaPozornikaAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat policajac pozornik: {pv.Id}");
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
    /*
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
    */
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


    [HttpPost]
    [Route("IzmeniPatrlonogPolicajca")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangePatrolnogPolicajac([FromBody] PatrolniPolicajacView pv)
    {
        var data = await DataProvider.IzmeniPatrolnogPolicajcaAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(pv);
    }

    [HttpPost]
    [Route("IzmeniPolicajcaZaVanredneSituacije")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangePZaVanredneSituacije([FromBody] PZaVanredneSituacijeView pv)
    {
        var data = await DataProvider.IzmeniPolicajcaZaVanredneSituacijeAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(pv);
    }

    [HttpPost]
    [Route("IzmeniSkolskogPolicajca")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeSkolkiPolicajac([FromBody] SkolskiPolicajacView pv)
    {
        var data = await DataProvider.IzmeniSkolskogPolicajcaAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(pv);
    }

    [HttpPost]
    [Route("IzmeniRadnikUUpravi")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeRadnikUUpravi([FromBody] RadnikUUpraviView pv)
    {
        var data = await DataProvider.IzmeniRadnikaUUpraviAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok(pv);
    }

    [HttpPost]
    [Route("IzmeniPolicajcaPozornika")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangePolicajcaPozornika([FromBody] PolicajacPozornikView pv)
    {
        var data = await DataProvider.IzmeniPolicajcaPozornikaAsync(pv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
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