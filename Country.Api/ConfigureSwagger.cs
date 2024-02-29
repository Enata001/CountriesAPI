using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Country.Api;

public class ConfigureSwagger: IConfigureNamedOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _apiVersionDescriptionProvider;

    public ConfigureSwagger(IApiVersionDescriptionProvider apiVersionDescriptionProvider)
    {
        _apiVersionDescriptionProvider = apiVersionDescriptionProvider;
    }
    public void Configure(SwaggerGenOptions options)
    {
       Configure(options);
    }

    public void Configure(string name, SwaggerGenOptions options)
    {
        foreach (var item in _apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(item.GroupName,CreateVersionInfo(item));
        }
    }

    private OpenApiInfo CreateVersionInfo(ApiVersionDescription description)
    {
        var info = new OpenApiInfo()
        {
            Title = "Your Versioned Api",
            Version = description.ApiVersion.ToString()
        };
        return info;
    }
}
