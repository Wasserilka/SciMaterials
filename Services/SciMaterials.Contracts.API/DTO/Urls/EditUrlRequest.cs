namespace SciMaterials.Contracts.API.DTO.Urls;

public class EditUrlRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Url { get; set; }
    public string Tags { get; set; }
    public string Categories { get; set; }
}