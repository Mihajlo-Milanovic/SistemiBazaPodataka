using Microsoft.AspNetCore.Mvc;
using PolicijskaUpravaLibrary;
//using WebAPI.Code;
using PolicijskaUpravaLibrary.DTOs;


namespace PolicijskaUpravaLibrary;


[ApiController]
[Route("[controller]")]
public class TehnickoLiceControllers : ControllerBase
{
    [HttpPost]
    [Route("DodajTehnickoLice")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> AddTehnickoLice([FromBody] TehnickoLiceView tlv)
    {
        var data = await DataProvider.SacuvajTehnickoLiceAsync(tlv);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspešno dodato vozilo: {tlv.Id}");
    }

    // TREBA DA SE DODA VAZOLO ZA NEKU PATROLU
    //[HttpPost]
    //[Route("DodajVozlio/{odeljenjeID}")]
    //[ProducesResponseType(StatusCodes.Status201Created)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(StatusCodes.Status403Forbidden)]
    //public async Task<IActionResult> AddSlagalicaToOdeljenje(int odeljenjeID, [FromBody] SlagalicaView s)
    //{
    //    (bool isError, int id, var error) = await DataProvider.SacuvajSlagalicuAsync(s);

    //    if (isError)
    //    {
    //        return StatusCode(error?.StatusCode ?? 400, error?.Message);
    //    }

    //    (bool isError2, var slagalica, var error2) = await DataProvider.VratiSlagalicuAsync(id);
    //    (bool isError3, var odeljenje, var error3) = await DataProvider.VratiOdeljenjeDo5Async(odeljenjeID);

    //    if (isError2 || isError3)
    //    {
    //        return StatusCode(error2?.StatusCode ?? 400, $"{error2?.Message}{Environment.NewLine}{error3?.Message}");
    //    }

    //    if (slagalica == null || odeljenje == null)
    //    {
    //        return BadRequest("Odeljenje ili slagalica nisu validni.");
    //    }

    //    var povezi = new ProdajeSeView
    //    {
    //        ProdajeOdeljenje = odeljenje,
    //        ProdajeProzivod = slagalica
    //    };

    //    var data = await DataProvider.SacuvajProdajeSeAsync(povezi);

    //    if (data.IsError)
    //    {
    //        return StatusCode(data.Error.StatusCode, data.Error.Message);
    //    }

    //    return StatusCode(201, $"Uspešno upisana slagalica i povezana sa odeljenjem: {data.Data}.");
    //}


    [HttpGet]
    [Route("PreuzmiSvaVozila")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetVozila()
    {
        var vozila = await DataProvider.VratiSvaVozilaAsync();

        if (vozila.IsError)
        {
            return StatusCode(vozila.Error.StatusCode, vozila.Error.Message);
        }

        return Ok(vozila.Data);
    }

    [HttpPut]
    [Route("PromeniVozilo")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeVozilo([FromBody] VoziloView v)
    {
        (bool isError, var vozilo, var error) = await DataProvider.IzmeniVoziloAsync(v);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(vozilo);
    }


    [HttpDelete]
    [Route("IzbrisiVozilo/{id}")]  // PROVERITI!!!
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeleteVozilo(int id)
    {
        var data = await DataProvider.ObrisiVoziloAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisano vozilo: {data.Data}.");
    }
}

