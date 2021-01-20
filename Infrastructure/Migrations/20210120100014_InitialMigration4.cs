using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseBill",
                columns: table => new
                {
                    BillNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateTime = table.Column<DateTime>(nullable: false),
                    BillType = table.Column<string>(nullable: true),
                    SupplierName = table.Column<string>(nullable: true),
                    OriginalPurchaseBillNumber = table.Column<string>(nullable: true),
                    BillTotalPriceBeforeDiscount = table.Column<double>(nullable: false),
                    BillTotalPriceAfterDiscount = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    SupplierSupllierId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseBill", x => x.BillNo);
                    table.ForeignKey(
                        name: "FK_PurchaseBill_Supplier_SupplierSupllierId",
                        column: x => x.SupplierSupllierId,
                        principalTable: "Supplier",
                        principalColumn: "SupllierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConTableItemAndPurchaseBill",
                columns: table => new
                {
                    ItemNo = table.Column<string>(nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false),
                    ItemQuantityInTheBill = table.Column<int>(nullable: false),
                    ItemPriceInTheBill = table.Column<double>(nullable: false),
                    ItemTotalPriceInTheBill = table.Column<double>(nullable: false),
                    purchaseBillBillNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConTableItemAndPurchaseBill", x => x.ItemNo);
                    table.ForeignKey(
                        name: "FK_ConTableItemAndPurchaseBill_PurchaseBill_purchaseBillBillNo",
                        column: x => x.purchaseBillBillNo,
                        principalTable: "PurchaseBill",
                        principalColumn: "BillNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConTableItemAndPurchaseBill_purchaseBillBillNo",
                table: "ConTableItemAndPurchaseBill",
                column: "purchaseBillBillNo");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseBill_SupplierSupllierId",
                table: "PurchaseBill",
                column: "SupplierSupllierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConTableItemAndPurchaseBill");

            migrationBuilder.DropTable(
                name: "PurchaseBill");
        }
    }
}
