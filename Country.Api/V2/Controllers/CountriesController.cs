using Country.Api.V1.Data;
using Country.Api.V1.Models.DTO;
using Country.Api.V2.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Country.Api.V2.Controllers;
[ApiController]
[Route("api/v2/[controller]")]


public class CountriesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var countriesDomainModel = CountriesDataV2.Get();
        var response = new List<CountryDtoV2>();

        foreach (var countryDomain in countriesDomainModel)
        {
                response.Add(new CountryDtoV2()
                {
                    Id = countryDomain.Id,
                    CountryName = countryDomain.CountryName
                });
        }
        
        return Ok(response);
    }
}