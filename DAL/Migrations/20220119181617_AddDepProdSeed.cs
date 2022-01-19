using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddDepProdSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DepartmentProduct",
                columns: new[] { "DepartmentsDepartmentId", "ProductsProductId" },
                values: new object[,]
                {
                    { 10, 10001 },
                    { 10, 10003 },
                    { 10, 10004 },
                    { 11, 10005 },
                    { 12, 10006 },
                    { 13, 10002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentProduct",
                keyColumns: new[] { "DepartmentsDepartmentId", "ProductsProductId" },
                keyValues: new object[] { 10, 10001 });

            migrationBuilder.DeleteData(
                table: "DepartmentProduct",
                keyColumns: new[] { "DepartmentsDepartmentId", "ProductsProductId" },
                keyValues: new object[] { 10, 10003 });

            migrationBuilder.DeleteData(
                table: "DepartmentProduct",
                keyColumns: new[] { "DepartmentsDepartmentId", "ProductsProductId" },
                keyValues: new object[] { 10, 10004 });

            migrationBuilder.DeleteData(
                table: "DepartmentProduct",
                keyColumns: new[] { "DepartmentsDepartmentId", "ProductsProductId" },
                keyValues: new object[] { 11, 10005 });

            migrationBuilder.DeleteData(
                table: "DepartmentProduct",
                keyColumns: new[] { "DepartmentsDepartmentId", "ProductsProductId" },
                keyValues: new object[] { 12, 10006 });

            migrationBuilder.DeleteData(
                table: "DepartmentProduct",
                keyColumns: new[] { "DepartmentsDepartmentId", "ProductsProductId" },
                keyValues: new object[] { 13, 10002 });
        }
    }
}
