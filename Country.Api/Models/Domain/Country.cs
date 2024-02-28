namespace Country.Api.Models.Domain;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class CountryV2
{
    public int Id { get; set; }
    public string CountryName { get; set; } = string.Empty;
}