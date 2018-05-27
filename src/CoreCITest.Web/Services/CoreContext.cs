using CoreCITest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreCITest.Web.Services
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options)
          : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }
        }
    }
}
