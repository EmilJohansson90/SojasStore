using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddedSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BestBefore",
                table: "Products",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "BarCode",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Name", "PhoneNumber", "Ssn" },
                values: new object[,]
                {
                    { 1001, "Erik", "123-456", 1001 },
                    { 1002, "Johanna", "456-789", 2001 },
                    { 1003, "Eva", "789-123", 1850 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Amount", "BarCode", "BestBefore", "Name", "Price" },
                values: new object[,]
                {
                    { 10001, 2, 123456, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mjölk", 13.5 },
                    { 10002, 8, 222555, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaffe", 25.989999999999998 },
                    { 10003, 12, 558874, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grädde", 54.200000000000003 },
                    { 10004, 1, 654321, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ost", 108.5 },
                    { 10005, 90, 258369, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fisk", 81.900000000000006 },
                    { 10006, 15, 147258, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bröd", 25.899999999999999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10001);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10003);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10004);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10005);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10006);

            migrationBuilder.DropColumn(
                name: "BarCode",
                table: "Products");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BestBefore",
                table: "Products",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}
