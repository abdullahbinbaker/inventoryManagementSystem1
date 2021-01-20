using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConTableItemAndPurchaseBill_PurchaseBill_purchaseBillBillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseBill_Supplier_SupplierSupllierId",
                table: "PurchaseBill");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseBill_SupplierSupllierId",
                table: "PurchaseBill");

            migrationBuilder.DropIndex(
                name: "IX_ConTableItemAndPurchaseBill_purchaseBillBillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.DropColumn(
                name: "SupplierSupllierId",
                table: "PurchaseBill");

            migrationBuilder.DropColumn(
                name: "purchaseBillBillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "PurchaseBill",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BillNo",
                table: "ConTableItemAndPurchaseBill",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseBill_SupplierId",
                table: "PurchaseBill",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ConTableItemAndPurchaseBill_BillNo",
                table: "ConTableItemAndPurchaseBill",
                column: "BillNo");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConTableItemAndPurchaseBill_PurchaseBill_BillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseBill_Supplier_SupplierId",
                table: "PurchaseBill");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseBill_SupplierId",
                table: "PurchaseBill");

            migrationBuilder.DropIndex(
                name: "IX_ConTableItemAndPurchaseBill_BillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "PurchaseBill");

            migrationBuilder.DropColumn(
                name: "BillNo",
                table: "ConTableItemAndPurchaseBill");

            migrationBuilder.AddColumn<int>(
                name: "SupplierSupllierId",
                table: "PurchaseBill",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "purchaseBillBillNo",
                table: "ConTableItemAndPurchaseBill",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseBill_SupplierSupllierId",
                table: "PurchaseBill",
                column: "SupplierSupllierId");

            migrationBuilder.CreateIndex(
                name: "IX_ConTableItemAndPurchaseBill_purchaseBillBillNo",
                table: "ConTableItemAndPurchaseBill",
                column: "purchaseBillBillNo");

            migrationBuilder.AddForeignKey(
                name: "FK_ConTableItemAndPurchaseBill_PurchaseBill_purchaseBillBillNo",
                table: "ConTableItemAndPurchaseBill",
                column: "purchaseBillBillNo",
                principalTable: "PurchaseBill",
                principalColumn: "BillNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseBill_Supplier_SupplierSupllierId",
                table: "PurchaseBill",
                column: "SupplierSupllierId",
                principalTable: "Supplier",
                principalColumn: "SupllierId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
