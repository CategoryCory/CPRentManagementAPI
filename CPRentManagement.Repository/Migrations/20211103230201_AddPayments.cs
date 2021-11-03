using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRentManagement.Repository.Migrations
{
    public partial class AddPayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    PaymentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Payment"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Check"),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    AmountInCents = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BalanceInCents = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Memo = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Tenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TenantId",
                table: "Payment",
                column: "TenantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
