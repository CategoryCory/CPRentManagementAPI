using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);
            builder.Property(c => c.CompanyName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.AddrLine1)
                .HasMaxLength(50);
            builder.Property(c => c.AddrLine2)
                 .HasMaxLength(50);
            builder.Property(c => c.City)
                 .HasMaxLength(25);
            builder.Property(c => c.State)
                 .HasMaxLength(25);
            builder.Property(c => c.ZipCode)
                 .HasMaxLength(15);
            builder.Property(c => c.Phone)
                 .HasMaxLength(25);
            builder.Property(c => c.AlternatePhone)
                 .HasMaxLength(25);
            builder.Property(c => c.Fax)
                 .HasMaxLength(25);

            builder.HasQueryFilter(c => c.IsDeleted != true);
        }
    }
}
