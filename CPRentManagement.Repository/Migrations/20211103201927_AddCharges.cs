using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRentManagement.Repository.Migrations
{
    public partial class AddCharges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Charge",
                columns: table => new
                {
                    ChargeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChargeStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unpaid"),
                    ChargeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountInCents = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BalanceInCents = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Memo = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    ParentChargeId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charge", x => x.ChargeId);
                    table.ForeignKey(
                        name: "FK_Charge_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Charge_Charge_ParentChargeId",
                        column: x => x.ParentChargeId,
                        principalTable: "Charge",
                        principalColumn: "ChargeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Charge_Tenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Description",
                table: "Account",
                column: "Description");

            migrationBuilder.CreateIndex(
                name: "IX_Charge_AccountId",
                table: "Charge",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Charge_BalanceInCents",
                table: "Charge",
                column: "BalanceInCents");

            migrationBuilder.CreateIndex(
                name: "IX_Charge_ChargeDate",
                table: "Charge",
                column: "ChargeDate");

            migrationBuilder.CreateIndex(
                name: "IX_Charge_ChargeStatus",
                table: "Charge",
                column: "ChargeStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Charge_ParentChargeId",
                table: "Charge",
                column: "ParentChargeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Charge_TenantId",
                table: "Charge",
                column: "TenantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Charge");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
