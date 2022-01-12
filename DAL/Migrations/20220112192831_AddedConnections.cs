using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddedConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_ForSaleId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ForSaleId",
                table: "Products",
                newName: "CheckedByEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ForSaleId",
                table: "Products",
                newName: "IX_Products_CheckedByEmployeeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Products",
                type: "int",
                nullable: true);

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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SaleId",
                table: "Products",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentProduct_ProductsProductId",
                table: "DepartmentProduct",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_CheckedByEmployeeId",
                table: "Products",
                column: "CheckedByEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
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
                name: "FK_Products_Employees_CheckedByEmployeeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "DepartmentProduct");

            migrationBuilder.DropIndex(
                name: "IX_Products_SaleId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CheckedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CheckedByEmployeeId",
                table: "Products",
                newName: "ForSaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CheckedByEmployeeId",
                table: "Products",
                newName: "IX_Products_ForSaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_ForSaleId",
                table: "Products",
                column: "ForSaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
