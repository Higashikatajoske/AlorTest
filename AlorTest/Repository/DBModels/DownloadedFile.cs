
namespace AlorTest.Repository.DBModels;

public partial class DownloadedFile
{
    public int Id { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileType { get; set; }
}
