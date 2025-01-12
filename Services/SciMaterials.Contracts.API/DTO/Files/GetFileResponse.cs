namespace SciMaterials.Contracts.API.DTO.Files;

public class GetFileResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Url { get; set; }
    public long Size { get; set; }
    public string Hash { get; set; }
    public Guid? ContentTypeId { get; set; }
    public Guid? FileGroupId { get; set; }
    public string Tags { get; set; }
    public string Categories { get; set; }

    // [JsonIgnore]
    public string ContentTypeName { get; set; }
}