using Core.BlogModel;
using Core.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.Context
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<RouteModel> Routes { get; set; }
    }
}
