using Core.Models;

namespace Core.Repositories
{
    public interface ICmsContentNuRepository : IDisposable
    {
        IEnumerable<CmsContentNu> GetCmsContentNus();
        void Update(CmsContentNu content);
        void Save();
    }
    public class CmsContentNuRepository : ICmsContentNuRepository
    {
        private CmsContext _context;
        public CmsContentNuRepository(CmsContext context)
        {
            _context = context;
        }

        private bool _isDisposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._isDisposed = true;
        }
        public void Dispose()
        {
            Dispose(true );
            GC.SuppressFinalize( this );
        }

        public IEnumerable<CmsContentNu> GetCmsContentNus()
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
