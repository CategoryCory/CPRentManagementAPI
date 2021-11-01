using CPRentManagement.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRentManagement.Entities.EntityConfiguration
{
    class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(x => x.CompanyName)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.AddrLine1)
                .HasMaxLength(50);
            builder.Property(x => x.AddrLine2)
                .HasMaxLength(50);
            builder.Property(x => x.City)
                .HasMaxLength(30);
            builder.Property(x => x.State)
                .HasMaxLength(30);
            builder.Property(x => x.ZipCode)
                .HasMaxLength(15);
            builder.Property(x => x.Phone)
                .HasMaxLength(20);
            builder.Property(x => x.AlternatePhone)
                .HasMaxLength(20);
            builder.Property(x => x.Fax)
                .HasMaxLength(20);
            builder.HasIndex(x => x.IsActive);
            builder.HasIndex(x => x.CompanyName);
        }
    }
}
