
using AlorTest.Model;

namespace AlorTest.Service;

public interface IFileService
{
    Task<string> SaveFile(UploadFileModel fileModel);
}
