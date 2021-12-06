﻿// <auto-generated />
using System;
using CPRentManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CPRentManagement.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211105010948_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CPRentManagement.Domain.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("AccountId");

                    b.HasIndex("Description");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Charge", b =>
                {
                    b.Property<int>("ChargeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("AmountInCents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("BalanceInCents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("ChargeDate")
                        .HasColumnType("date");

                    b.Property<string>("ChargeStatus")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("Unpaid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Memo")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("ParentChargeId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("ChargeId");

                    b.HasIndex("AccountId");

                    b.HasIndex("BalanceInCents");

                    b.HasIndex("ChargeDate");

                    b.HasIndex("ChargeStatus");

                    b.HasIndex("ParentChargeId")
                        .IsUnique();

                    b.HasIndex("TenantId");

                    b.ToTable("Charges");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddrLine1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AddrLine2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AlternatePhone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("City")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fax")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("State")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CompanyId");

                    b.HasIndex("CompanyName");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountInCents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("BalanceInCents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Memo")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("Check");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("Payment");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("TenantId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddrLine1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AddrLine2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateBuilt")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Insurance")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KeyNumber")
                        .HasColumnType("int");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<double>("SquareFeet")
                        .HasColumnType("float");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Taxes")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("PropertyId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Tenant", b =>
                {
                    b.Property<int>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddrLine1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AddrLine2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AlternateCompany1")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("AlternateCompany2")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("City")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Fax")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LeaseBeginDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("LeaseEndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("MoveInDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("MoveOutDate")
                        .HasColumnType("date");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("SSN")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("State")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<string>("WorkPhone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("TenantId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("UnitId")
                        .IsUnique();

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddrLine1")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("AddrLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("RentInCents")
                        .HasColumnType("int");

                    b.Property<double>("SquareFeet")
                        .HasColumnType("float");

                    b.Property<string>("UnitStatus")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("Unoccupied");

                    b.HasKey("UnitId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UnitStatus");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Charge", b =>
                {
                    b.HasOne("CPRentManagement.Domain.Models.Account", "Account")
                        .WithMany("Charges")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CPRentManagement.Domain.Models.Charge", "ParentCharge")
                        .WithOne("LateCharge")
                        .HasForeignKey("CPRentManagement.Domain.Models.Charge", "ParentChargeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CPRentManagement.Domain.Models.Tenant", "Tenant")
                        .WithMany("Charges")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("ParentCharge");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Payment", b =>
                {
                    b.HasOne("CPRentManagement.Domain.Models.Tenant", "Tenant")
                        .WithMany("Payments")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Property", b =>
                {
                    b.HasOne("CPRentManagement.Domain.Models.Company", "Company")
                        .WithMany("Properties")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Tenant", b =>
                {
                    b.HasOne("CPRentManagement.Domain.Models.Unit", "Unit")
                        .WithOne("Tenant")
                        .HasForeignKey("CPRentManagement.Domain.Models.Tenant", "UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Unit", b =>
                {
                    b.HasOne("CPRentManagement.Domain.Models.Property", "Property")
                        .WithMany("Units")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Account", b =>
                {
                    b.Navigation("Charges");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Charge", b =>
                {
                    b.Navigation("LateCharge");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Company", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Property", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Tenant", b =>
                {
                    b.Navigation("Charges");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("CPRentManagement.Domain.Models.Unit", b =>
                {
                    b.Navigation("Tenant");
                });
#pragma warning restore 612, 618
        }
    }
}