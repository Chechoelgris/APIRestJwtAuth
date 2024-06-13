using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25c791fc-a86c-46b2-8a74-76387cf2e264", null, "Admin", "ADMIN" },
                    { "3fb8ebaa-fb27-464b-9a44-1535c52109d8", null, "Client", "CLIENT" },
                    { "9fa69d56-49d2-40b8-9840-ff5ab39074db", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25c791fc-a86c-46b2-8a74-76387cf2e264");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fb8ebaa-fb27-464b-9a44-1535c52109d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fa69d56-49d2-40b8-9840-ff5ab39074db");
        }
    }
}
