
using AlorTest.Model;
using AlorTest.Repository;
using Microsoft.IdentityModel.Tokens;
using AlorTest.Repository.DBModels;
using System.Xml.Serialization;

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
        bool isFinished = false;
        while (!isFinished)
        {
            CreateStartView();
            int choiceNumber = int.Parse(Console.ReadLine());

            switch (choiceNumber)
            {
                case 1:
                    await DownloadFileView();
                    break;
                case 2:
                    await ShowFileList();
                    break;
                case 3:
                    await FindFile();
                    break;
                case 0:
                    isFinished = true;
                    Console.WriteLine("Выход");
                    break;
            }
        }
    }

    private void CreateStartView()
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1.Скачать файл по ссылке");
        Console.WriteLine("2.Показать список загруженных файлов");
        Console.WriteLine("3.Распарсить xml-файл");
        Console.WriteLine("0.Выход из программы\n");
    }

    private async Task DownloadFileView()
    {
        Console.WriteLine("Укажите ссылку на файл");
        string? url = Console.ReadLine();
        if (!url.IsNullOrEmpty())
        {
            Console.WriteLine("Идёт загрузка файла");
            UploadFileModel uploadFileModel = await _httpService.GetFile(url!);
            Console.WriteLine($"Файл типа {uploadFileModel.Extension} загружен");
            DownloadedFile? downloadedFile = await _fileService.SaveFile(uploadFileModel);

            if (downloadedFile != null )
            {
                Console.WriteLine($"Файл с именем {downloadedFile.FileName} записан на компьютер");
                _fileRepository.SaveFile(downloadedFile);
                Console.WriteLine($"Информация о файле записана в БД");
            }
        }
        else
            Console.WriteLine("Строка пуста");

    }

    private async Task ShowFileList()
    {
        Console.WriteLine("Список файлов");
        List<string> fileList = await _fileRepository.GetFileList();

        foreach (string file in fileList)
        {
            Console.WriteLine($"{file}");
        }
        Console.WriteLine();
    }

    private async Task FindFile()
    {
        Console.WriteLine("Напишите название файла");
        string? fileName = "test.xml";
        if (!fileName.IsNullOrEmpty())
        {
            XmlRootAttribute xmlRootAttribute = new XmlRootAttribute();
            xmlRootAttribute.ElementName = "INDIVIDUAL";
            MemoryStream stream = await _fileService.GetFile(fileName!);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Individual), xmlRootAttribute);
            Individual? individualDesc = xmlSerializer.Deserialize(stream) as Individual; 
        }
        else
        {
            Console.WriteLine("Пустая строка");
        }
    }
}
