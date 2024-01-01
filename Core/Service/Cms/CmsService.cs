using System.Net.Http;

namespace Core.Service.Cms
{
    public class CmsService : ICmsService
    {
        private HttpClient _httpClient;
        public CmsService(HttpClient httpClient) {
            this._httpClient = httpClient;
        }
        private async Task<string> GetContentByPath(string path)
        {
            var a = _httpClient.GetStringAsync("/umbraco/delivery/api/v2/content").Result;
            //_httpClient.BaseAddress.
            return a;
        }
        public async Task<ResponseModel> GetRoutesConfig()
        {
            
            var rs =  await _httpClient.GetAsync(CmsApiUrl.ContentApi + "?fetch=children%3Aroute");
            var content = await rs.Content.ReadFromJsonAsync<ResponseModel>();
            return content;
        }
    }
}
