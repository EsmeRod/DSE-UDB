using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Desafio1.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomDep = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    FecContr = table.Column<DateOnly>(type: "date", nullable: false),
                    IDDep = table.Column<int>(type: "int", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Departamentos_IDDep",
                        column: x => x.IDDep,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Descripcion", "NomDep" },
                values: new object[,]
                {
                    { 1, "", "Recursos Humanos" },
                    { 2, "", "Tecnologia" },
                    { 3, "", "Ventas" }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Descripcion", "FecContr", "IDDep", "Nacimiento", "Nombre", "Salario" },
                values: new object[,]
                {
                    { 1, "", new DateOnly(2010, 8, 15), 1, new DateOnly(1985, 5, 20), "John Doe", 50000m },
                    { 2, "", new DateOnly(2015, 1, 25), 2, new DateOnly(1990, 3, 10), "Jane Smith", 70000m },
                    { 3, "", new DateOnly(2012, 6, 18), 3, new DateOnly(1982, 11, 22), "Mark Johnson", 55000m },
                    { 4, "", new DateOnly(2005, 10, 12), 1, new DateOnly(1978, 7, 30), "Emily Davis", 75000m },
                    { 5, "", new DateOnly(2020, 4, 15), 2, new DateOnly(1995, 12, 5), "Michael Brown", 60000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IDDep",
                table: "Empleados",
                column: "IDDep");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
