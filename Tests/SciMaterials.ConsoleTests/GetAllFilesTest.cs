using SciMaterials.DAL.Contexts;
using SciMaterials.DAL.UnitOfWork;
using SciMaterials.WebApi.Clients.Files;

namespace SciMaterials.ConsoleTests;

public class GetAllFilesTest
{
    private readonly IFilesClient _FilesClient;

    public GetAllFilesTest(IFilesClient FilesClient, IUnitOfWork<SciMaterialsContext> UnitOfWork)
    {
        _FilesClient = FilesClient;
    }

    public async Task Get()
    {
        var result = await _FilesClient.GetAllAsync();
        if (result.Succeeded)
            foreach (var item in result.Data)
                Console.WriteLine($"{item.Id} >>> {item.Name}");
        else
            Console.WriteLine(string.Join(";", result.Messages));
    }
}
