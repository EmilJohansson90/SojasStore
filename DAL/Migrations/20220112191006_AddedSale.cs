using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddedSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "ForSaleId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_ForSaleId",
                table: "Products",
                column: "ForSaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_ForSaleId",
                table: "Products",
                column: "ForSaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_ForSaleId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Products_ForSaleId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ForSaleId",
                table: "Products");

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
    }
}
