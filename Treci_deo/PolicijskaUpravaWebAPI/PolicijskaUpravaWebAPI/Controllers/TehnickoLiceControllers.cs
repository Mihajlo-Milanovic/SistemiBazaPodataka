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

        return StatusCode(201, $"Uspešno dodato tehnicko lice: {tlv.Id}");
    }

    [HttpGet]
    [Route("PreuzmiSvaTehnickaLica")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetTehnickaLica()
    {
        var tehnickoLice= await DataProvider.VratiSvaTehnickaLicaAsync();

        if (tehnickoLice.IsError)
        {
            return StatusCode(tehnickoLice.Error.StatusCode, tehnickoLice.Error.Message);
        }

        return Ok(tehnickoLice.Data);
    }

    [HttpPut]
    [Route("PromeniTehnickoLice")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ChangeTehnickoLice([FromBody] TehnickoLiceView tlv)
    {
        (bool isError, var tehnickoLice, var error) = await DataProvider.IzmeniTehnickoLiceAsync(tlv);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(tlv);
    }


    [HttpDelete]
    [Route("IzbrisiTehnickoLice/{id}")] 
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DeleteTehnickoLice(int id)
    {
        var data = await DataProvider.ObrisiTehnickoLiceAsync(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspešno obrisano tehnicko lice: {data.Data}.");
    }
}

