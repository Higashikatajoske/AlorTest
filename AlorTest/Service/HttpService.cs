using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlorTest.Service
{
    public class HttpService: IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task Get(string url)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            HttpResponseMessage? httpResponseMessage = await SendRequest(httpRequestMessage);
            if (httpResponseMessage == null)
            {
                return;
            }

            string data = await httpResponseMessage.Content.ReadAsStringAsync();
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
}
