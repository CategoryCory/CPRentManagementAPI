using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    public class UnitEntityTypeConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.Property(u => u.AddrLine1)
                .IsRequired()
                .HasMaxLength(75);
            builder.Property(u => u.UnitStatus)
                .HasMaxLength(20)
                .HasConversion<string>()
                .HasDefaultValue(UnitStatus.Unoccupied);
            builder.Ignore(u => u.PercentageOccupied);

            builder.HasOne(u => u.Property)
                .WithMany(p => p.Units);
        }
    }
}
