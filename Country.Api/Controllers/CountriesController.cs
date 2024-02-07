using Country.Api.Data;
using Country.Api.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Country.Api.Controllers;
[ApiController]
[Route("api/[controller]")]


public class CountriesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var countriesDomainModel = CountriesData.Get();
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