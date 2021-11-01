using CPRentManagement.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.API.DataAccess.EntityConfiguration
{
    public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(x => x.CompanyName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.AddrLine1)
                .HasMaxLength(50); 
            builder.Property(x => x.AddrLine2)
                 .HasMaxLength(50);
            builder.Property(x => x.City)
                 .HasMaxLength(25);
            builder.Property(x => x.State)
                 .HasMaxLength(25);
            builder.Property(x => x.ZipCode)
                 .HasMaxLength(15);
            builder.Property(x => x.Phone)
                 .HasMaxLength(25);
            builder.Property(x => x.AlternatePhone)
                 .HasMaxLength(25);
            builder.Property(x => x.Fax)
                 .HasMaxLength(25);
            builder.HasIndex(x => x.IsActive);
            builder.HasIndex(x => x.CompanyName);
        }
    }
}
