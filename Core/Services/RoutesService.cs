using AutoMapper;
using Core.DTO;
using Core.DTO.Cms.Properties;
using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories.Interface;
using Core.Infrastructure.Services.Cms;
using Core.Services.Interface;

namespace Core.Services
{
    public class RoutesService : IRoutesService
    {
        private readonly IRouteRepository _routeRepository;
        private readonly ICmsService _cmsService;
        private readonly IMapper _mapper;
        public RoutesService(IRouteRepository routeRepository, ICmsService cmsService, IMapper mapper)
        {
            this._routeRepository = routeRepository;
            this._cmsService = cmsService;
            this._mapper = mapper;
        }
        public async Task AddRouteToDb(IList<Routes> routes)
        {
            await this._routeRepository.AddRoutes(routes);
            await this._routeRepository.SaveAsync();
        }

        public async Task<IList<Routes>> GetAllRoutesFromDb()
        {
            return await this._routeRepository.GetAll();
        }
        public async Task<IList<Routes>?> AddRoutesToDbIfNotExist()
        {
            var routes = await this.GetRoutesFromCmsAsync();
            if(routes is not null)
            {
                await this.AddRouteToDb(routes);
                return routes;
            }
            return null;
        }

        public async Task<IList<Routes>?> GetRoutesFromCmsAsync()
        {
            var data = await this._cmsService.GetRoutesConfig();
            if (data is null)
            {
                return null;
            }
            return data.items.Select(x => _mapper.Map<Routes>(x.properties)).ToList();
        }

        public void GetRoutesFromCached()
        {
            throw new NotImplementedException();
        }
    }
}
