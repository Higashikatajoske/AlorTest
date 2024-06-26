
using AlorTest.Service;

namespace AlorTest
{
    public class StartApp
    {
        private readonly IHttpService _httpService;

        public StartApp(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task Start()
        {
            string url = "https://scsanctions.un.org/resources/xml/en/consolidated.xml";
            await _httpService.GetFile(url);
        }
    }
}
