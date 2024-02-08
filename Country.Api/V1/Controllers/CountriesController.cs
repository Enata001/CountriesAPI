using Country.Api.V1.Data;
using Country.Api.V1.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Country.Api.V1.Controllers;
[ApiController]
[Route("api/v1/[controller]")]


public class CountriesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var countriesDomainModel = CountriesDataV1.Get();
        var response = new List<CountryDto>();

        foreach (var countryDomain in countriesDomainModel)
        {
                response.Add(new CountryDto()
                {
                    Id = countryDomain.Id,
                    Name = countryDomain.Name,
                });
        }
        
        return Ok(response);
    }
}