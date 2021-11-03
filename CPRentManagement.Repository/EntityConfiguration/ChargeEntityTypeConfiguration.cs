using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    class ChargeEntityTypeConfiguration : IEntityTypeConfiguration<Charge>
    {
        public void Configure(EntityTypeBuilder<Charge> builder)
        {
            builder.Property(c => c.ChargeStatus)
                .HasConversion<string>()
                .HasMaxLength(20)
                .HasDefaultValue(ChargeStatus.Unpaid);
            builder.Property(c => c.ChargeDate)
                .IsRequired()
                .HasColumnType("date");
            builder.Property(c => c.AmountInCents)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(c => c.BalanceInCents)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(c => c.Memo)
                .HasMaxLength(75);

            builder.HasIndex(c => c.ChargeStatus);
            builder.HasIndex(c => c.ChargeDate);
            builder.HasIndex(c => c.BalanceInCents);

            builder.HasOne(c => c.Account).WithMany(a => a.Charges);
            builder.HasOne(c => c.Tenant).WithMany(t => t.Charges);
            builder.HasOne(c => c.ParentCharge)
                .WithOne(c => c.LateCharge)
                .HasForeignKey(typeof(Charge), "ParentChargeId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
