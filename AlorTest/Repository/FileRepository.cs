
using AlorTest.Model;
using AlorTest.Repository.DBModels;
using Microsoft.EntityFrameworkCore;

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

    public async Task<List<string>> GetFileList()
    {
        return await _context.DownloadedFiles.Select(file => file.FileName).ToListAsync();
    }

    public async Task<DownloadedFile?> GetFile(string fileName)
    {
        return await _context.DownloadedFiles.FirstOrDefaultAsync(file => file.FileName == fileName);
    }

}
