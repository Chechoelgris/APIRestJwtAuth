using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5691e445-752f-405c-a48b-16f83569ed6f", null, "Estudiante", "ESTUDIANTE" },
                    { "9197a4a6-b091-4dd6-907b-52d7369e397a", null, "Profesor", "PROFESOR" },
                    { "bf496145-1995-4b32-8a35-fe9a1f5ef1d9", null, "Admin", "ADMIN" },
                    { "d78719c3-48f3-4464-ae05-a7b8ff707c60", null, "GestorInstitucion", "GESTORINSTITUCION" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5691e445-752f-405c-a48b-16f83569ed6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9197a4a6-b091-4dd6-907b-52d7369e397a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf496145-1995-4b32-8a35-fe9a1f5ef1d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d78719c3-48f3-4464-ae05-a7b8ff707c60");
        }
    }
}
