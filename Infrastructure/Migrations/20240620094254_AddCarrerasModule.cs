using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCarrerasModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "465f589b-f8ff-46e2-b7bd-de48562539c0", null, "Admin", "ADMIN" },
                    { "49022304-12aa-4f49-92f3-ce64594de0c5", null, "Profesor", "PROFESOR" },
                    { "6c22f01c-b759-4000-ae64-74571ee42990", null, "GestorInstitucion", "GESTORINSTITUCION" },
                    { "f430ce03-a4ea-4754-b6ce-fdb41c534c95", null, "Estudiante", "ESTUDIANTE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "465f589b-f8ff-46e2-b7bd-de48562539c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49022304-12aa-4f49-92f3-ce64594de0c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c22f01c-b759-4000-ae64-74571ee42990");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f430ce03-a4ea-4754-b6ce-fdb41c534c95");

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
    }
}
