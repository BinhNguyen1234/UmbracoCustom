using Core.BlogModel;
using Microsoft.EntityFrameworkCore;

namespace Core.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}
