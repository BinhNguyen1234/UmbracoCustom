using AutoMapper;
using Core.DTO.Cms;
using Core.DTO.Cms.Properties;
using Core.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Net.Http;

namespace Core.Service.Cms
{
    public class CmsService : ICmsService
    {
        private HttpClient _httpClient;
        private IMapper _mapper;
        public CmsService(HttpClient httpClient, IMapper mapper) {
            this._httpClient = httpClient;
            this._mapper = mapper;
        }
        private async Task<string> GetContentByPath(string path)
        {
            var a = _httpClient.GetStringAsync("/umbraco/delivery/api/v2/content").Result;
            //_httpClient.BaseAddress.
            return a;
        }
        public async Task<ResponseModel<RouteConfig>> GetRoutesConfig()
        {
            
            var rs =  await _httpClient.GetAsync(CmsApiUrl.ContentApi + "?fetch=children%3Aroute");
            var content = await rs.Content.ReadFromJsonAsync<ResponseModel<RouteConfig>>();
            //var r = content.items.Select(x => _mapper.Map<RouteEntites>(x.properties)).ToList();
            return content;
        }
    }
}
