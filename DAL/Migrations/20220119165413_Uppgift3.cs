using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Uppgift3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Ssn", "EmployeeId", "MentorSsn", "Name", "PhoneNumber" },
                values: new object[] { 1833, 1004, null, "Lars", "112-123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Ssn",
                keyValue: 1833);
        }
    }
}
