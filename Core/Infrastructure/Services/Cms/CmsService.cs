using AutoMapper;
using Core.DTO.Cms;
using Core.DTO.Cms.Properties;
using Core.Entities;
using Core.Infrastructure.Services.Cms.Constant;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Net.Http;

namespace Core.Infrastructure.Services.Cms
{
    public class CmsService : ICmsService
    {
        private HttpClient _httpClient;
        private IMapper _mapper;
        public CmsService(HttpClient httpClient, IMapper mapper)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }
        private async Task<string> GetContentByPath(string path)
        {
            var a = _httpClient.GetStringAsync("/umbraco/delivery/api/v2/content").Result;
            //_httpClient.BaseAddress.
            return a;
        }
        public async Task<ResponseModel<RouteConfig>?> GetRoutesConfig()
        {
            try
            {
                var response = await _httpClient.GetAsync(CmsApiUrl.Content + CmsUrlParams.GetRoute);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<ResponseModel<RouteConfig>>();
                    var ff = data.items.GetType().Name;
                    return data;
                }
                return null;
            } catch {
                throw;
            }
        }
    }
}
