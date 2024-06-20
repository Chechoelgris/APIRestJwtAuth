using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleEntityConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d32371a-8cbc-481f-afbd-d373091ffcf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2720b9d2-c006-4ab1-87a5-92cfe8041140");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4677b823-05b5-4e92-a199-d89772882993");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7130fe78-67af-4a48-9d41-0e171993df0c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0912d911-3e98-497b-aa96-1ed7bc922195", null, "Estudiante", "ESTUDIANTE" },
                    { "2b91e46f-64b2-4705-8414-57c72d01ea62", null, "Profesor", "PROFESOR" },
                    { "848c5383-f2cb-46ff-b474-f1fe083370d8", null, "Admin", "ADMIN" },
                    { "89a07350-a075-4d5a-9c21-4915e12e7e78", null, "GestorInstitucion", "GESTORINSTITUCION" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0912d911-3e98-497b-aa96-1ed7bc922195");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b91e46f-64b2-4705-8414-57c72d01ea62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "848c5383-f2cb-46ff-b474-f1fe083370d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89a07350-a075-4d5a-9c21-4915e12e7e78");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d32371a-8cbc-481f-afbd-d373091ffcf6", null, "Profesor", "PROFESOR" },
                    { "2720b9d2-c006-4ab1-87a5-92cfe8041140", null, "Estudiante", "ESTUDIANTE" },
                    { "4677b823-05b5-4e92-a199-d89772882993", null, "Admin", "ADMIN" },
                    { "7130fe78-67af-4a48-9d41-0e171993df0c", null, "GestorInstitucion", "GESTORINSTITUCION" }
                });
        }
    }
}
