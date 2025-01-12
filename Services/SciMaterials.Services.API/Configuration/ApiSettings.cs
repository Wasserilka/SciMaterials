using SciMaterials.Contracts.API.Settings;

namespace SciMaterials.Services.API.Configuration;

public class ApiSettings : IApiSettings
{
    public const string SectionName = "ApiSettings";
    public string BasePath { get; set; } = string.Empty;
    public long MaxFileSize { get; set; }
    public string Separator { get; set; } = ",";
}