using Core.Data;
using Core.Data.Infrastucture;
using Core.Models;

namespace Core.Repositories
{

    public class CmsContentNuRepository : GenericRepositoryBase<CmsContentNu>
    {
        private BlogContext _context;
        public CmsContentNuRepository(BlogContext context): base(context)
        {
            _context = context;
        }

        private bool _isDisposed = false;

        public IQueryable<CmsContentNu> GetCmsContentNus()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(CmsContentNu content)
        {
            throw new NotImplementedException();
        }
    }
}
