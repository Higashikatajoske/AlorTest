using AlorTest.Model;

namespace AlorTest.Service;

public class HttpService: IHttpService
{
    private readonly HttpClient _httpClient;

    public HttpService(HttpClient httpClient) {
        _httpClient = httpClient;
    }

    public async Task<UploadFileModel?> GetFile(string url)
    {
        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        HttpResponseMessage? httpResponseMessage = await SendRequest(httpRequestMessage);
        if (httpResponseMessage == null)
        {
            return null;
        }

        UploadFileModel fileModel = new UploadFileModel()
        {
            FileMemoryStream = await httpResponseMessage.Content.ReadAsStreamAsync(),
            Extension = httpResponseMessage.Content.Headers.ContentType?.MediaType ?? string.Empty,
            FileName = httpResponseMessage.Content.Headers.ContentDisposition?.FileNameStar ?? string.Empty
        };

        return fileModel;
    }

    private async Task<HttpResponseMessage?> SendRequest(HttpRequestMessage httpRequestMessage)
    {
        HttpResponseMessage httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
        if (httpResponseMessage.IsSuccessStatusCode)
        {
            return httpResponseMessage;
        }
        
        return null;
    }
}
