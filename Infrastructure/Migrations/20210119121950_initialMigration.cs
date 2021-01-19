using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemNo = table.Column<string>(nullable: false),
                    NameArabic = table.Column<string>(nullable: true),
                    NameEnglish = table.Column<string>(nullable: true),
                    Price1 = table.Column<double>(nullable: false),
                    Price2 = table.Column<double>(nullable: false),
                    Price3 = table.Column<double>(nullable: false),
                    CurrentCost = table.Column<double>(nullable: false),
                    CurrentInventory = table.Column<int>(nullable: false),
                    StockForTheFirstTerm = table.Column<int>(nullable: false),
                    StockForTheLastTerm = table.Column<int>(nullable: false),
                    Purchases = table.Column<int>(nullable: false),
                    Sales = table.Column<int>(nullable: false),
                    OriginalItemNo = table.Column<string>(nullable: true),
                    Location1 = table.Column<string>(nullable: true),
                    Location2 = table.Column<string>(nullable: true),
                    Location3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemNo);
                });

            migrationBuilder.CreateTable(
                name: "ItemCostHistory",
                columns: table => new
                {
                    ItemNo = table.Column<string>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCostHistory", x => x.ItemNo);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupllierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(nullable: true),
                    SsupplierPhoneNumber = table.Column<string>(nullable: true),
                    SupplierAddress = table.Column<string>(nullable: true),
                    SupplierEmail = table.Column<string>(nullable: true),
                    SupplierTotalPurchases = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupllierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ItemCostHistory");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
