using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
using PolicijskaUpravaLibrary.DTOs;
using PolicijskaUpravaLibrary.Entiteti;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class AlarmniSistemController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiAlarmniSistem/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAlarmniSistem(int id)
    {
        var alarmnisistem = await DataProvider.VratiAlarmniSistemAsync(id);

        if (alarmnisistem.IsError)
        {
            return StatusCode(alarmnisistem.Error.StatusCode, alarmnisistem.Error.Message);
        }

        return Ok(alarmnisistem.Data);
    }

    [HttpGet]
    [Route("PreuzmiSveAlarmneSisteme")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAlarmniSistemi(int id)
    {
        var a = await DataProvider.VratiAlarmneSistemeZaObjekatAsync(id);

        if (a.IsError)
        {
            return StatusCode(a.Error.StatusCode, a.Error.Message);
        }

        return Ok(a.Data);
    }

    //[HttpPost]
    //[Route("DodajAlarmniSistem")]
    //[ProducesResponseType(StatusCodes.Status201Created)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(StatusCodes.Status403Forbidden)]
    //public async Task<IActionResult> AddAlarmniSistem([FromBody] AlarmniSistemView a)
    //{
    //    var data = await DataProvider.SacuvajAlarmniSistemAsync(a);

    //    if (data.IsError)
    //    {
    //        return StatusCode(data.Error.StatusCode, data.Error.Message);
    //    }

    //    return StatusCode(201, $"Uspešno dodat alarmni sistem: {a.Id}");
    //}

    [HttpPost]
    [Route("DodajUltrazvucniAlarmniSistem")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajUltrazvucniAlarmniSistem([FromBody] UltrazvucniASView asv)
    {
        asv.Tip = TipAlarmnogSistema.Ultrazvucni;

        var result = await DataProvider.SacuvajAlarmniSistemAsync(asv);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat ultrazvučni alarmni sistem sa ID: {result.Data}");
    }

    [HttpPost]
    [Route("DodajAlarmniSistemDetekcijePokreta")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajAlarmniSistemDetekcijePokreta([FromBody] ASDetekcijePokretaView asv)
    {
        asv.Tip = TipAlarmnogSistema.DetekcijePokreta;

        var result = await DataProvider.SacuvajAlarmniSistemAsync(asv);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat alarmni sistem detekcije pokreta sa ID: {result.Data}");
    }

    [HttpPost]
    [Route("DodajAlarmniSistemDetekcijeToplotnogOdraza")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajAlarmniSistemDetekcijeToplotnogOdraza([FromBody] ASDetekcijeToplotnogOdrazaView asv)
    {
        asv.Tip = TipAlarmnogSistema.DetekcijeToplotnogOdraza;

        var result = await DataProvider.SacuvajAlarmniSistemAsync(asv);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodat alarmni sistem detekcije toplotnog odraza sa ID: {result.Data}");
    }

    [HttpPut]
    [Route("PromeniUltrazvucniAlarmniSistem")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeUltrazvucniAlarmniSistem([FromBody] UltrazvucniASView asv)
    {
        asv.Tip = TipAlarmnogSistema.Ultrazvucni;

        var result = await DataProvider.IzmeniAlarmniSistemAsync(asv);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok(result.Data);
    }

    [HttpPut]
    [Route("PromeniAlarmniSistemDetekcijePokreta")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeAlarmniSistemDetekcijePokreta([FromBody] ASDetekcijePokretaView asv)
    {
        asv.Tip = TipAlarmnogSistema.DetekcijePokreta;

        var result = await DataProvider.IzmeniAlarmniSistemAsync(asv);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok(result.Data);
    }

    [HttpPut]
    [Route("PromeniAlarmniSistemDetekcijeToplotnogOdraza")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeAlarmniSistemDetekcijeToplotnogOdraza([FromBody] ASDetekcijeToplotnogOdrazaView asv)
    {
        asv.Tip = TipAlarmnogSistema.DetekcijeToplotnogOdraza;

        var result = await DataProvider.IzmeniAlarmniSistemAsync(asv);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok(result.Data);
    }


    [HttpDelete]
    [Route("IzbrisiAlarmniSistem/{id}")]  // PROVERITI!!!
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeleteAlarmniSistem(int id)
    {
        var data = await DataProvider.ObrisiAlarmniSistemAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisan alarmni sistem: {data.Data}.");
    }
}

