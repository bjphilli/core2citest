using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCITest.Data
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(o => o.Id);
            // builder.Property(o => o.Name).IsRequired();
            // builder.OwnsOne(o => o.BillingAddress, b =>
            // {
            //     b.Property(o => o.Street1).HasColumnName("BillingStreet1");
            //     b.Property(o => o.Street2).HasColumnName("BillingStreet2");
            //     b.Property(o => o.City).HasColumnName("BillingCity");
            //     b.Property(o => o.State).HasColumnName("BillingState");
            //     b.Property(o => o.PostalCode).HasColumnName("BillingPostalCode");
            //     b.Property(o => o.Country).HasColumnName("BillingCountry");
            // });
            builder.ToTable("AspNetUsers");
        }
    }
}
