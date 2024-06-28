
using AlorTest.Model;
using AlorTest.Service;

namespace AlorTest
{
    public class StartApp
    {
        private readonly IHttpService _httpService;
        private readonly IFileService _fileService;

        public StartApp(IHttpService httpService, IFileService fileService)
        {
            _httpService = httpService;
            _fileService = fileService;
        }

        public async Task Start()
        {
            string url = "https://scsanctions.un.org/resources/xml/en/consolidated.xml";
            UploadFileModel model = await _httpService.GetFile(url);
            await _fileService.SaveFile(model);

        }
    }
}
