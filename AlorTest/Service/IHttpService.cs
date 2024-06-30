
using AlorTest.Model;

namespace AlorTest.Service;

public interface IHttpService
{
    Task<UploadFileModel?> GetFile(string url);
}
