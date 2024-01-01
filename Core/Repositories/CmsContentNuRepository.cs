using Core.Data;
using Core.Data.Infrastucture;


namespace Core.Repositories
{

    public class CmsContentNuRepository : GenericRepositoryBase<Route>
    {
        private TestContext _context;
        public CmsContentNuRepository(TestContext context): base(context)
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

        public override Route Update(Route content)
        {
            throw new NotImplementedException();
        }
    }
}
