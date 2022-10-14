using System.Net.Http.Headers;
using System.Net.Http.Json;
using ApiNewsVBlazor.Models;

namespace ApiNewsVBlazor
{
    public class NewsService : INewsService
    {
        private readonly HttpClient client;
        string apiKey;
        string url;

        public NewsService(HttpClient httpClient)
        {
            client = httpClient;
            apiKey = "oPW2AbNi4AyskfDEpDu2nhHHDweJqXiHxLiuhdIOnCU";
            url = "https://api.newscatcherapi.com/v2/search?";
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);
        }

        public async Task<APIResponse> ObtenerNoticias(string categoria, string pais)
        {
            string urlCompleta = url + "q=" + categoria + "&countries=" + pais;

            

            return await client.GetFromJsonAsync<APIResponse>(urlCompleta);

        }
    }
}
