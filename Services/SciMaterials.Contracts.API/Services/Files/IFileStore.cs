using SciMaterials.Contracts.API.Models;

namespace SciMaterials.Contracts.API.Services.Files;

public interface IFileStore
{
    Task<FileWriteResult> WriteAsync(string path, Stream stream, CancellationToken cancellationToken = default);
    Task<FileWriteResult> WriteAsync(string path, string text, CancellationToken cancellationToken = default);
    Stream OpenRead(string path);
    void Delete(string path);
}