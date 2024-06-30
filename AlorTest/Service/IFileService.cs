
using AlorTest.Model;
using AlorTest.Repository.DBModels;

namespace AlorTest.Service;

public interface IFileService
{
    Task<DownloadedFile?> SaveFile(UploadFileModel uploadFileModel);
}
