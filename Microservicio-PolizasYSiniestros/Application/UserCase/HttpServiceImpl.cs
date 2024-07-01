using Application.Interfaces.Service;
using Newtonsoft.Json;

namespace Application.UserCase
{
    public class HttpServiceImpl : IHttpServer
    {
        private readonly HttpClient _httpClient;

        public HttpServiceImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            var response = await _httpClient.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al llamar al endpoint. Código de estado: {response.StatusCode}");
            }

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseBody);
        }
    }
}
