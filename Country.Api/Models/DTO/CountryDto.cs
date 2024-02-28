namespace Country.Api.Models.DTO;

public class CountryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}


public class CountryDtoV2
{
    public int Id { get; set; }
    public string CountryName { get; set; } = string.Empty;
}