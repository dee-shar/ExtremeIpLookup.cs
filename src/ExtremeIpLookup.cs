using System.Net.Http;
using System.Net.Http.Headers;

namespace ExtremeIpLookupApi
{
    public class ExtremeIpLookup
    {
        private readonly HttpClient httpClient;
        private readonly string apiKey = "demo2";
        private readonly string apiUrl = "https://extreme-ip-lookup.com";
        public ExtremeIpLookup()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void SetApiKey(string apiKey)
        {
            apiKey = apiKey;
        }

        public async Task<string> GetIpInfo(string ip)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/json/{ip}?key={apiKey}");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMyIp()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/json/?key={apiKey}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
