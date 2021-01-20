using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConTableItemAndPurchaseBill_PurchaseBill_BillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseBill_Supplier_SupplierId",
                table: "PurchaseBill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseBill",
                table: "PurchaseBill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "PurchaseBill",
                newName: "PurchaseBills");

            migrationBuilder.RenameTable(
                name: "ItemCostHistory",
                newName: "ItemCostHistories");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseBill_SupplierId",
                table: "PurchaseBills",
                newName: "IX_PurchaseBills_SupplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "SupllierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseBills",
                table: "PurchaseBills",
                column: "BillNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCostHistories",
                table: "ItemCostHistories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemNo");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: false),
                    CustomerPhone = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerTotalPurchases = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "SalesBills",
                columns: table => new
                {
                    BillNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillType = table.Column<string>(nullable: false),
                    SalesBillTotalBeforeDiscount = table.Column<double>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    SalesmanName = table.Column<string>(nullable: false),
                    SalesBillTotalPriceAfterDiscount = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: true),
                    BillProfitBeforeDiscount = table.Column<double>(nullable: false),
                    BillProfitAfterDiscount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesBills", x => x.BillNo);
                });

            migrationBuilder.CreateTable(
                name: "ConTableCustomerAndBill",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillNo = table.Column<int>(nullable: false),
                    TotalBillBeforeDiscount = table.Column<double>(nullable: false),
                    TotalBillAfterDiscount = table.Column<double>(nullable: false),
                    SupplierId = table.Column<int>(nullable: true),
                    Discount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConTableCustomerAndBill", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_ConTableCustomerAndBill_Customers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConTableCustomerAndBill_SupplierId",
                table: "ConTableCustomerAndBill",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConTableItemAndPurchaseBill_PurchaseBills_BillNo",
                table: "ConTableItemAndPurchaseBill",
                column: "BillNo",
                principalTable: "PurchaseBills",
                principalColumn: "BillNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseBills_Suppliers_SupplierId",
                table: "PurchaseBills",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupllierId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConTableItemAndPurchaseBill_PurchaseBills_BillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseBills_Suppliers_SupplierId",
                table: "PurchaseBills");

            migrationBuilder.DropTable(
                name: "ConTableCustomerAndBill");

            migrationBuilder.DropTable(
                name: "SalesBills");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseBills",
                table: "PurchaseBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCostHistories",
                table: "ItemCostHistories");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "PurchaseBills",
                newName: "PurchaseBill");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "ItemCostHistories",
                newName: "ItemCostHistory");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseBills_SupplierId",
                table: "PurchaseBill",
                newName: "IX_PurchaseBill_SupplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "SupllierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseBill",
                table: "PurchaseBill",
                column: "BillNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConTableItemAndPurchaseBill_PurchaseBill_BillNo",
                table: "ConTableItemAndPurchaseBill",
                column: "BillNo",
                principalTable: "PurchaseBill",
                principalColumn: "BillNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseBill_Supplier_SupplierId",
                table: "PurchaseBill",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupllierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
