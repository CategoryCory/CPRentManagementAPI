using CPRentManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRentManagement.Repository.EntityConfiguration
{
    public class TenantEntityTypeConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.Property(t => t.ContactPerson)
                .HasMaxLength(75);
            builder.Property(t => t.Phone)
                .HasMaxLength(25);
            builder.Property(t => t.WorkPhone)
                .HasMaxLength(25);
            builder.Property(t => t.CellPhone)
                .HasMaxLength(25);
            builder.Property(t => t.Fax)
                .HasMaxLength(25);
            builder.Property(t => t.Email)
                .HasMaxLength(75);
            builder.Property(t => t.SSN)
                .HasMaxLength(25);
            builder.Property(t => t.CompanyName)
                .HasMaxLength(75);
            builder.Property(t => t.AlternateCompany1)
                .HasMaxLength(75);
            builder.Property(t => t.AlternateCompany2)
                .HasMaxLength(75);
            builder.Property(t => t.AddrLine1)
                .HasMaxLength(50);
            builder.Property(t => t.AddrLine2)
                .HasMaxLength(50);
            builder.Property(t => t.City)
                .HasMaxLength(25);
            builder.Property(t => t.State)
                .HasMaxLength(25);
            builder.Property(t => t.ZipCode)
                .HasMaxLength(25);
            builder.Property(t => t.TenantStatus)
                .HasMaxLength(20)
                .HasConversion<string>()
                .HasDefaultValue(TenantStatus.Active);
            builder.Property(t => t.MoveInDate).HasColumnType("date");
            builder.Property(t => t.MoveOutDate).HasColumnType("date");
            builder.Property(t => t.LeaseBeginDate).HasColumnType("date");
            builder.Property(t => t.LeaseEndDate).HasColumnType("date");
            builder.Property(t => t.MoveInDate).HasColumnType("date");
            builder.HasIndex(t => t.TenantStatus);
        }
    }
}
