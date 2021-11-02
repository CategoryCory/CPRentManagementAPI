using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRentManagement.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddrLine1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddrLine2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    State = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    AlternatePhone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateBuilt = table.Column<DateTime>(type: "date", nullable: false),
                    KeyNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AddrLine1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddrLine2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    State = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SquareFeet = table.Column<double>(type: "float", nullable: false),
                    Taxes = table.Column<int>(type: "int", nullable: false),
                    Insurance = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddrLine1 = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AddrLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentInCents = table.Column<int>(type: "int", nullable: false),
                    SquareFeet = table.Column<double>(type: "float", nullable: false),
                    UnitStatus = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_Units_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tenant",
                columns: table => new
                {
                    TenantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantStatus = table.Column<int>(type: "int", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    AlternateCompany1 = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    AlternateCompany2 = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    AddrLine1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddrLine2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    State = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoveInDate = table.Column<DateTime>(type: "date", nullable: false),
                    MoveOutDate = table.Column<DateTime>(type: "date", nullable: false),
                    LeaseBeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    LeaseEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.TenantId);
                    table.ForeignKey(
                        name: "FK_Tenant_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyName",
                table: "Companies",
                column: "CompanyName");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IsActive",
                table: "Companies",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CompanyId",
                table: "Properties",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsActive",
                table: "Properties",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Tenant_TenantStatus",
                table: "Tenant",
                column: "TenantStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Tenant_UnitId",
                table: "Tenant",
                column: "UnitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Units_IsActive",
                table: "Units",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Units_PropertyId",
                table: "Units",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitStatus",
                table: "Units",
                column: "UnitStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tenant");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
