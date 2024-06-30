
using AlorTest.Model;
using AlorTest.Repository;
using AlorTest.Repository.DBModels;
using AlorTest.Service;
using System.Xml.Serialization;

namespace AlorTest
{
    public class StartApp
    {
        private readonly IHttpService _httpService;
        private readonly IFileService _fileService;
        private readonly IFileRepository _fileRepository;

        public StartApp(
            IHttpService httpService, IFileService fileService, 
            IFileRepository fileRepository)
        {
            _httpService = httpService;
            _fileService = fileService;
            _fileRepository = fileRepository;
        }

        public async Task Start()
        {
            string url = "https://scsanctions.un.org/resources/xml/en/consolidated.xml";
            UploadFileModel model = await _httpService.GetFile(url);
            DownloadedFile? downloadedFile = await _fileService.SaveFile(model);
            if (downloadedFile != null)
            {
                _fileRepository.SaveFile(downloadedFile);
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConsolidatedList));

            ConsolidatedList consolidatedList = xmlSerializer.Deserialize(model.FileMemoryStream) as ConsolidatedList;

        }
    }
}
