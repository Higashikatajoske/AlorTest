
using AlorTest.Model;
using AlorTest.Repository.DBModels;

namespace AlorTest.Repository;

public class FileRepository: IFileRepository
{
    private readonly TestContext _context;
    public FileRepository(TestContext context)
    {
        _context = context;
    }

    public void SaveFile(DownloadedFile file)
    {
        _context.DownloadedFiles.Add(file);
        _context.SaveChanges();
    }

}
