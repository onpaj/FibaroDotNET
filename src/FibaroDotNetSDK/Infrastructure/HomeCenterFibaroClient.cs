using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.Infrastructure
{
    public class HomeCenterFibaroClient : IFibaroClient
    {
        private readonly HubSettings _settings;
        private readonly JsonSerializerSettings _customSerializerSettings;
        private static HttpClient _httpClient;

        public HomeCenterFibaroClient(HubSettings settings, JsonSerializerSettings customSerializerSettings = null)
        {
            _settings = settings;
            _customSerializerSettings = customSerializerSettings;
            if(_httpClient == null)
                _httpClient = new HttpClient();
        }

        public async Task<T> SendRequest<T>(RequestBase request)
        {
            var httpReq = new HttpRequestMessage(request.Method, new Uri(_settings.Address + request.Path));

            httpReq.Headers.Authorization = CreateAuthorizationHeader();
            httpReq.Content = CreateBody(request);

            var response = await _httpClient.SendAsync(httpReq);

            if(response.StatusCode != request.ExpectedStatus)
                throw new HomeCenterRequestException(response.StatusCode, await response.Content.ReadAsStringAsync(), httpReq);

            return await ParseResult<T>(response);
        }

        private AuthenticationHeaderValue CreateAuthorizationHeader()
        {
            var byteArray = Encoding.ASCII.GetBytes($"{_settings.UserName}:{_settings.Password}");
            return new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        private HttpContent CreateBody(RequestBase request)
        {
            var serialized = JsonConvert.SerializeObject(request.Body, _customSerializerSettings ?? Converter.Settings);

            return new StringContent(serialized);
        }

        private async Task<T> ParseResult<T>(HttpResponseMessage response)
        {
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), _customSerializerSettings ?? Converter.Settings);
        }
    }
}