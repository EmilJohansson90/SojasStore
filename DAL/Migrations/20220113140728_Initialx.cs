using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Initialx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Ssn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MentorSsn = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InChargeSsn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_InChargeSsn",
                        column: x => x.InChargeSsn,
                        principalTable: "Employees",
                        principalColumn: "Ssn",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Emails = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeSsn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => new { x.Emails, x.EmployeeSsn });
                    table.ForeignKey(
                        name: "FK_Emails_Employees_EmployeeSsn",
                        column: x => x.EmployeeSsn,
                        principalTable: "Employees",
                        principalColumn: "Ssn",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarCode = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BestBefore = table.Column<DateTime>(type: "Date", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CheckedBySsn = table.Column<int>(type: "int", nullable: true),
                    CheckedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Employees_CheckedBySsn",
                        column: x => x.CheckedBySsn,
                        principalTable: "Employees",
                        principalColumn: "Ssn",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentProduct",
                columns: table => new
                {
                    DepartmentsDepartmentId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentProduct", x => new { x.DepartmentsDepartmentId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_DepartmentProduct_Departments_DepartmentsDepartmentId",
                        column: x => x.DepartmentsDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Ingredient = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => new { x.Ingredient, x.ProductProductId });
                    table.ForeignKey(
                        name: "FK_Ingredients_Products_ProductProductId",
                        column: x => x.ProductProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
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

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentProduct_ProductsProductId",
                table: "DepartmentProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InChargeSsn",
                table: "Departments",
                column: "InChargeSsn");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmployeeSsn",
                table: "Emails",
                column: "EmployeeSsn");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MentorSsn",
                table: "Employees",
                column: "MentorSsn");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ProductProductId",
                table: "Ingredients",
                column: "ProductProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CheckedBySsn",
                table: "Products",
                column: "CheckedBySsn");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SaleId",
                table: "Products",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentProduct");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
