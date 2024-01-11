using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Department = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Address = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DoB = table.Column<DateTime>(type: "TEXT", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Salary = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Department", "DoB", "FirstName", "HireDate", "JoiningDate", "LastName", "Salary" },
                values: new object[,]
                {
                    { 1, "", "X", null, "Aslam", null, null, "Shaikh", 100.9f },
                    { 2, "", "B", null, "Abhijit", null, null, "Idekar", 300.9f },
                    { 3, "", "P", null, "Maksud", null, null, "Aditya", 200.9f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
