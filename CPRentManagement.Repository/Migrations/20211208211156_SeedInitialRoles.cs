using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPRentManagement.Repository.Migrations
{
    public partial class SeedInitialRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1006cdb9-f468-4af3-9063-9805590b508c", "96e0f6ae-db38-46aa-829b-b98900aa18c0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dbdc58b-70fc-4aff-98d5-cc002274bfc8", "5b37941a-6bf3-4a18-af60-c8d64c827e19", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3604d9b2-85db-4b07-9ee4-2bbb63223519", "979a1e33-8e9f-4463-8966-cb2b0815adbd", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1006cdb9-f468-4af3-9063-9805590b508c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dbdc58b-70fc-4aff-98d5-cc002274bfc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3604d9b2-85db-4b07-9ee4-2bbb63223519");
        }
    }
}
