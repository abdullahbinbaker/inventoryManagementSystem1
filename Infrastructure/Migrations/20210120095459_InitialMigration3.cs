using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory");

            migrationBuilder.DropColumn(
                name: "SsupplierPhoneNumber",
                table: "Supplier");

            migrationBuilder.AddColumn<string>(
                name: "SupplierPhoneNumber",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "ItemCostHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "ItemCostHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "ItemCostHistory",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "ItemCostHistory",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ItemNo",
                table: "ItemCostHistory",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "ItemCostHistory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "BillNo",
                table: "ItemCostHistory",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "ItemCostHistory",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory");

            migrationBuilder.DropColumn(
                name: "SupplierPhoneNumber",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "id",
                table: "ItemCostHistory");

            migrationBuilder.DropColumn(
                name: "BillNo",
                table: "ItemCostHistory");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "ItemCostHistory");

            migrationBuilder.AddColumn<string>(
                name: "SsupplierPhoneNumber",
                table: "Supplier",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "ItemCostHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "ItemCostHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "ItemCostHistory",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ItemNo",
                table: "ItemCostHistory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "ItemCostHistory",
                type: "float",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory",
                column: "ItemNo");
        }
    }
}
