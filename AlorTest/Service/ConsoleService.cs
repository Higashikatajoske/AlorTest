
using AlorTest.Model;
using AlorTest.Repository;
using Microsoft.IdentityModel.Tokens;
using AlorTest.Repository.DBModels;

namespace AlorTest.Service;

public class ConsoleService: IConsoleService
{
    private readonly IHttpService _httpService;
    private readonly IFileService _fileService;
    private readonly IFileRepository _fileRepository;
    public ConsoleService(IHttpService httpService, IFileService fileService,
        IFileRepository fileRepository)
    {
        _httpService = httpService;
        _fileService = fileService;
        _fileRepository = fileRepository;
    }

    public async Task StartProgram()
    {
        CreateStartView();
        int choiceNumber = int.Parse(Console.ReadLine());

        switch(choiceNumber)
        {
            case 1:
                await DownloadFileView();
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }

    private void CreateStartView()
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1.Скачать файл по ссылке");
        Console.WriteLine("2.Показать список загруженных файлов");
        Console.WriteLine("3.Распарсить xml-файлов");
    }

    private async Task DownloadFileView()
    {
        Console.WriteLine("Укажите ссылку на файл");
        string? url = Console.ReadLine();
        if (!url.IsNullOrEmpty())
        {
            UploadFileModel uploadFileModel = await _httpService.GetFile(url!);
            DownloadedFile? downloadedFile = await _fileService.SaveFile(uploadFileModel);

            if (downloadedFile != null )
            {
               _fileRepository.SaveFile(downloadedFile);
            }
        }
        else
            Console.WriteLine("Строка пуста");

    }
}
