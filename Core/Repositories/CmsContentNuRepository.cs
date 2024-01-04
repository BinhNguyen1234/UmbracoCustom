using Core.Data;
using Core.Data.Infrastucture;
using Core.Data.Model;


namespace Core.Repositories
{

    public class CmsContentNuRepository : GenericRepositoryBase<RouteModel>
    {
        private CoreContext _context;
        public CmsContentNuRepository(CoreContext context): base(context)
        {
            _context = context;
        }

        private bool _isDisposed = false;

        public IQueryable<Route> GetCmsContentNus()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public RouteModel Update(Route content)
        {
            throw new NotImplementedException();
        }
    }
}
