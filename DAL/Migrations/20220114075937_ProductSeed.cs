using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ProductSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Emails", "EmployeeSsn" },
                values: new object[,]
                {
                    { "eva@gmail.com", 1850 },
                    { "evalarsson@ghotmail.com", 1850 },
                    { "jjonsson@gmail.com", 2001 },
                    { "youngNfab@live.se", 2001 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Amount", "BarCode", "BestBefore", "CheckedBySsn", "CheckedDate", "Name", "Price", "SaleId" },
                values: new object[,]
                {
                    { 10001, 2, 123456, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mjölk", 13.5, null },
                    { 10002, 8, 222555, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaffe", 25.989999999999998, null },
                    { 10003, 12, 558874, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grädde", 54.200000000000003, null },
                    { 10004, 1, 654321, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ost", 108.5, null },
                    { 10005, 90, 258369, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fisk", 81.900000000000006, null },
                    { 10006, 15, 147258, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bröd", 25.899999999999999, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "Emails", "EmployeeSsn" },
                keyValues: new object[] { "eva@gmail.com", 1850 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "Emails", "EmployeeSsn" },
                keyValues: new object[] { "evalarsson@ghotmail.com", 1850 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "Emails", "EmployeeSsn" },
                keyValues: new object[] { "jjonsson@gmail.com", 2001 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "Emails", "EmployeeSsn" },
                keyValues: new object[] { "youngNfab@live.se", 2001 });

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
        }
    }
}
