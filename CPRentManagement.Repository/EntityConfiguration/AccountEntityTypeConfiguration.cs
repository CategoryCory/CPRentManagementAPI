using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    class AccountEntityTypeConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(a => a.IsActive)
                .HasDefaultValue(true);
            builder.Property(a => a.Description)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasIndex(a => a.Description);
        }
    }
}
