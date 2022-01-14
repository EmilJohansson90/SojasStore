using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mailtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Emails", "EmployeeSsn" },
                values: new object[] { "erik@gmail.com", 1001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "Emails", "EmployeeSsn" },
                keyValues: new object[] { "erik@gmail.com", 1001 });
        }
    }
}
