using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    public class PropertyEntityTypeConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(x => x.Description)
                .HasMaxLength(250);
            builder.Property(x => x.AddrLine1)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.AddrLine2)
                .HasMaxLength(50);
            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(x => x.State)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(x => x.ZipCode)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(x => x.PropertyType)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(25);
            builder.HasIndex(x => x.IsActive);
            builder.HasOne(p => p.Company).WithMany(c => c.Properties);
        }
    }
}
