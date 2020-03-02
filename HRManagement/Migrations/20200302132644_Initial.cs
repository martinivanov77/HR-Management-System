using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    VacationDays = table.Column<int>(nullable: false),
                    ExperienceLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false),
                    IsHQ = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offices_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ExperienceLevel", "FirstName", "LastName", "Salary", "StartingDate", "VacationDays" },
                values: new object[] { 1, 1, "Petar", "Petrov", 550.5m, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "City", "Country", "EmployeeId", "IsHQ", "Street", "StreetNumber" },
                values: new object[] { 1, "NYC", "USA", 1, true, "Wall st", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Offices_EmployeeId",
                table: "Offices",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
