using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRentManagement.Repository.Migrations
{
    public partial class AddSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Units_IsDeleted",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_UnitStatus",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_IsDeleted",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_UnitId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Properties_IsDeleted",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyName",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_IsDeleted",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Charges_BalanceInCents",
                table: "Charges");

            migrationBuilder.DropIndex(
                name: "IX_Charges_ChargeDate",
                table: "Charges");

            migrationBuilder.DropIndex(
                name: "IX_Charges_ChargeStatus",
                table: "Charges");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_Description",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Charges");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_UnitId",
                table: "Tenants",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tenants_UnitId",
                table: "Tenants");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Charges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Units_IsDeleted",
                table: "Units",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitStatus",
                table: "Units",
                column: "UnitStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_IsDeleted",
                table: "Tenants",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_UnitId",
                table: "Tenants",
                column: "UnitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsDeleted",
                table: "Properties",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyName",
                table: "Companies",
                column: "CompanyName");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IsDeleted",
                table: "Companies",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_BalanceInCents",
                table: "Charges",
                column: "BalanceInCents");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_ChargeDate",
                table: "Charges",
                column: "ChargeDate");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_ChargeStatus",
                table: "Charges",
                column: "ChargeStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Description",
                table: "Accounts",
                column: "Description");
        }
    }
}
