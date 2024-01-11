using Core.BlogModel;
using Core.Infrastructure.Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Database
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<User> User { get; set; }
    }
}
