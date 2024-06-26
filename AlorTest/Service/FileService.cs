using AlorTest.Configure;
using Microsoft.Extensions.Options;

namespace AlorTest.Service;

public class FileService: IFileService
{
    private readonly StorageOptions _storageOptions;

    public FileService(IOptions<StorageOptions> storageOptions)
    {
        _storageOptions = storageOptions.Value;  
    }

    public void SaveFile()
    {
        
    }
}
