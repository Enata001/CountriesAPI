using Asp.Versioning;
using Country.Api.Data;
using Country.Api.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Country.Api.Controllers;
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
[ApiVersion("2.0")]


public class CountriesController : ControllerBase
{
    [HttpGet]
    [MapToApiVersion("1.0")]
    public IActionResult GetV1()
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
    
    [HttpGet]
    [MapToApiVersion("2.0")]
    public IActionResult GetV2()
    {
        var countriesDomainModel = CountriesData.Get();
        var response = new List<CountryDtoV2>();

        foreach (var countryDomain in countriesDomainModel)
        {
            response.Add(new CountryDtoV2()
            {
                Id = countryDomain.Id,
                CountryName = countryDomain.Name,
            });
        }
        
        return Ok(response);
    }
}