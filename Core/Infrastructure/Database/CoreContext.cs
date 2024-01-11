using Core.BlogModel;
using Core.Infrastructure.Database.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Core.Infrastructure.Database
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasIndex(u => u.Email).IsUnique();
        }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<User> User { get; set; }
    }
}
