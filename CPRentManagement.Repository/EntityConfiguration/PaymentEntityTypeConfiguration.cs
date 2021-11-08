using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    class PaymentEntityTypeConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(p => p.PaymentType)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(20)
                .HasDefaultValue(PaymentType.Payment);
            builder.Property(p => p.PaymentMethod)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(20)
                .HasDefaultValue(PaymentMethod.Check);
            builder.Property(p => p.PaymentDate)
                .HasColumnType("date");
            builder.Property(p => p.AmountInCents)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(p => p.BalanceInCents)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(p => p.Memo)
                .HasMaxLength(75);

            builder.HasOne(p => p.Tenant).WithMany(t => t.Payments);
        }
    }
}
