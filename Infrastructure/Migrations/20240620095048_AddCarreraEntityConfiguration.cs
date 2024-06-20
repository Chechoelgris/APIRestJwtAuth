using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCarreraEntityConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Carreras",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Carreras",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Carrera enfocada en el desarrollo de sistemas informáticos.", "Ingeniería de Sistemas" },
                    { 2, "Carrera enfocada en la construcción y mantenimiento de infraestructuras.", "Ingeniería Civil" },
                    { 3, "Carrera enfocada en el estudio y práctica de la medicina.", "Medicina" },
                    { 4, "Carrera enfocada en el estudio del ser humano y su mundo psiquico.", "Psicología" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Carreras",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Carreras",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

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
    }
}
