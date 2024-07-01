
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
    private readonly IXmlFileService _xmlFileService;
    public ConsoleService(IHttpService httpService, IFileService fileService,
        IFileRepository fileRepository, IXmlFileService xmlFileService)
    {
        _httpService = httpService;
        _fileService = fileService;
        _fileRepository = fileRepository;
        _xmlFileService = xmlFileService;
    }

    public async Task StartProgram()
    {
        bool isFinished = false;
        while (!isFinished)
        {
            CreateStartView();
            if (!int.TryParse(Console.ReadLine(), out int choiceNumber))
            {
                Console.WriteLine("Неправильная команда");
            }
            else
            {
                switch (choiceNumber)
                {
                    case 1:
                        await DownloadFileView();
                        break;
                    case 2:
                        await ShowFileList();
                        break;
                    case 3:
                        FindFile();
                        break;
                    case 0:
                        isFinished = true;
                        Console.WriteLine("Выход");
                        break;
                }
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
            UploadFileModel? uploadFileModel = await _httpService.GetFile(url!);
            if (uploadFileModel == null)
            {
                Console.WriteLine("Файл не смог загрузиться");
                return;
            }
            Console.WriteLine($"Файл с content-type {uploadFileModel.ContentType} загружен");
            DownloadedFile? downloadedFile = await _fileService.SaveFile(uploadFileModel);

            if (downloadedFile != null )
            {
                Console.WriteLine($"Файл с именем {downloadedFile.FileName} записан на компьютер");
                _fileRepository.SaveFile(downloadedFile);
                Console.WriteLine($"Информация о файле записана в БД");
            }
        }
        else
            Console.WriteLine("Строка пуста.\n");

    }

    private async Task ShowFileList()
    {
        Console.WriteLine("Список файлов");
        List<string> fileList = await _fileRepository.GetFileList();
        if (fileList.Count == 0)
        {
            Console.WriteLine("Файлов нет");
            return;
        }

        foreach (string file in fileList)
        {
            Console.WriteLine($"{file}");
        }
        Console.WriteLine();
    }

    private async Task FindFile()
    {
        Console.WriteLine("Напишите название файла");
        string? fileName = Console.ReadLine();
        if (!fileName.IsNullOrEmpty())
        {
            FileStream? stream = _fileService.GetFile(fileName!);
            if (stream == null)
            {
                Console.WriteLine("Произошла ошибка с поиском файла. Файл не найден.\n");
                return;
            }
            
            DownloadedFile? fileInfo = await _fileRepository.GetFile(fileName!);

            if (fileInfo == null)
            {
                Console.WriteLine("Информация о файле не найден. Приложение может привести к ошибке");
                return;
            }

            if (fileInfo.FileType != "xml")
            {
                Console.WriteLine("Файл не является xml файлом. Он не может парситься");
                return;
            }

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConsolidatedList));
                ConsolidatedList? consolidatedList = xmlSerializer.Deserialize(stream) as ConsolidatedList;
                if (consolidatedList == null)
                {
                    Console.WriteLine("Файл пуст");
                    return;
                }
                await _xmlFileService.SaveConsolidatedListToDB(consolidatedList);
            }
            catch
            {
                Console.WriteLine("Произошла ошибка парсинка. Этот xml-файл не подходит для этого парсинга");
            }
        }
        else
        {
            Console.WriteLine("Пустая строка.\n");
        }
    }
}
