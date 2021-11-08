using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    public class PropertyEntityTypeConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(p => p.DateBuilt)
                .HasColumnType("date");
            builder.Property(p => p.Description)
                .HasMaxLength(250);
            builder.Property(p => p.AddrLine1)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.AddrLine2)
                .HasMaxLength(50);
            builder.Property(p => p.City)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(p => p.State)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(p => p.ZipCode)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(p => p.PropertyType)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(25);

            builder.HasOne(p => p.Company).WithMany(c => c.Properties);
        }
    }
}
