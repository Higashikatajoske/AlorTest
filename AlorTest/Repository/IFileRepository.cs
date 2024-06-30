
using AlorTest.Repository.DBModels;

namespace AlorTest.Repository;

public interface IFileRepository
{
    void SaveFile(DownloadedFile file);

    Task<List<string>> GetFileList();

    Task<DownloadedFile?> GetFile(string fileName);
}
