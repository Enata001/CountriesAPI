using Country.Api.V2.Models.Domain;

namespace Country.Api.V1.Data;

public static class CountriesDataV2
{
    public static List<CountryV2> Get()
    {
        var countries = new[]
        {
            new { Id = 1, Name = "Ghana" },
            new { Id = 2, Name = "Nigeria" },
            new { Id = 3, Name = "Brazil" },
            new { Id = 4, Name = "Jamaica" },
            new { Id = 5, Name = "England" },
            new { Id = 6, Name = "South Africa" },
            new { Id = 7, Name = "Mexico" },
            new { Id = 8, Name = "Japan" },
            new { Id = 9, Name = "Russia" },
            new { Id = 10, Name = "Australia" },
        };

        return countries.Select(c => new CountryV2() {Id = c.Id, CountryName = c.Name}).ToList();
    }
}