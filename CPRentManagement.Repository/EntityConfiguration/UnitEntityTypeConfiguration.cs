﻿using CPRentManagement.Domain.Models;
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
            builder.Ignore(u => u.PercentageOccupied);
            builder.HasIndex(u => u.IsActive);
            builder.HasIndex(u => u.UnitStatus);
            builder.HasOne(u => u.Property)
                .WithMany(p => p.Units);
            builder.HasOne(u => u.Tenant)
                .WithOne(t => t.Unit)
                .HasForeignKey<Tenant>(t => t.UnitId);
        }
    }
}
