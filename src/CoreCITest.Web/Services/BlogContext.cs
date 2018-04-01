using CoreCITest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreCITest.Web.Services
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
          : base(options)
        {
        }

        public DbSet<Hello> Hellos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
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
