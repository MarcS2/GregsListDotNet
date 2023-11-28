using Microsoft.AspNetCore.Http.HttpResults;

namespace GregsListDotNet.Controllers;
[ApiController]
[Route("api/[controller]")]

public class HousesController
{
    private readonly HousesService _housesService;

    HousesController(HousesService housesService)
    {
        _housesService = housesService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
        try
        {
            List<House> houses = _housesService.GetHouses();
            return Ok(houses);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}
