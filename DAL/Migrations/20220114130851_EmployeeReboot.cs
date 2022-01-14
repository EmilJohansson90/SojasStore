using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class EmployeeReboot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProduct_Departments_DepartmentsDepartmentId",
                table: "DepartmentProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProduct_Products_ProductsProductId",
                table: "DepartmentProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_InChargeSsn",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Employees_EmployeeSsn",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Products_ProductProductId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_CheckedBySsn",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Products_CheckedBySsn",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Emails_EmployeeSsn",
                table: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InChargeSsn",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "Emails", "EmployeeSsn" },
                keyValues: new object[] { "erik@gmail.com", 1001 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProduct_Departments_DepartmentsDepartmentId",
                table: "DepartmentProduct",
                column: "DepartmentsDepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProduct_Products_ProductsProductId",
                table: "DepartmentProduct",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Products_ProductProductId",
                table: "Ingredients",
                column: "ProductProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProduct_Departments_DepartmentsDepartmentId",
                table: "DepartmentProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProduct_Products_ProductsProductId",
                table: "DepartmentProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Products_ProductProductId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Ssn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentorSsn = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Ssn);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_MentorSsn",
                        column: x => x.MentorSsn,
                        principalTable: "Employees",
                        principalColumn: "Ssn",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Ssn", "EmployeeId", "MentorSsn", "Name", "PhoneNumber" },
                values: new object[] { 1001, 1001, null, "Erik", "123-456" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Ssn", "EmployeeId", "MentorSsn", "Name", "PhoneNumber" },
                values: new object[] { 1850, 1003, null, "Eva", "789-123" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Ssn", "EmployeeId", "MentorSsn", "Name", "PhoneNumber" },
                values: new object[] { 2001, 1002, null, "Johanna", "456-789" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "InChargeSsn", "Name" },
                values: new object[,]
                {
                    { 10, 1001, "Mejeri" },
                    { 11, 2001, "Kött" },
                    { 12, 2001, "Bröd" },
                    { 13, 1850, "Skafferi" },
                    { 14, 1001, "Grönsaker" },
                    { 15, 1001, "Grönsaker" }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Emails", "EmployeeSsn" },
                values: new object[,]
                {
                    { "erik@gmail.com", 1001 },
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
                    { 10001, 2, 123456, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2001, new DateTime(2021, 12, 30, 12, 30, 0, 0, DateTimeKind.Unspecified), "Mjölk", 13.5, null },
                    { 10002, 8, 222555, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, new DateTime(2021, 12, 25, 11, 45, 0, 0, DateTimeKind.Unspecified), "Kaffe", 25.989999999999998, null },
                    { 10003, 12, 558874, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, new DateTime(2022, 1, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Grädde", 54.200000000000003, null },
                    { 10004, 1, 654321, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, new DateTime(2022, 1, 2, 16, 59, 0, 0, DateTimeKind.Unspecified), "Ost", 108.5, null },
                    { 10005, 90, 258369, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1850, new DateTime(2022, 1, 2, 8, 25, 0, 0, DateTimeKind.Unspecified), "Fisk", 81.900000000000006, null },
                    { 10006, 15, 147258, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1850, new DateTime(2022, 1, 6, 11, 35, 0, 0, DateTimeKind.Unspecified), "Bröd", 25.899999999999999, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CheckedBySsn",
                table: "Products",
                column: "CheckedBySsn");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmployeeSsn",
                table: "Emails",
                column: "EmployeeSsn");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InChargeSsn",
                table: "Departments",
                column: "InChargeSsn");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MentorSsn",
                table: "Employees",
                column: "MentorSsn");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProduct_Departments_DepartmentsDepartmentId",
                table: "DepartmentProduct",
                column: "DepartmentsDepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProduct_Products_ProductsProductId",
                table: "DepartmentProduct",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_InChargeSsn",
                table: "Departments",
                column: "InChargeSsn",
                principalTable: "Employees",
                principalColumn: "Ssn",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Employees_EmployeeSsn",
                table: "Emails",
                column: "EmployeeSsn",
                principalTable: "Employees",
                principalColumn: "Ssn",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Products_ProductProductId",
                table: "Ingredients",
                column: "ProductProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_CheckedBySsn",
                table: "Products",
                column: "CheckedBySsn",
                principalTable: "Employees",
                principalColumn: "Ssn",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
