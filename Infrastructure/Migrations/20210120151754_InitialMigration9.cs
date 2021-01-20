using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConTableItemAndBills",
                columns: table => new
                {
                    BillNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemNo = table.Column<string>(nullable: true),
                    ItemQuantityInTheBill = table.Column<int>(nullable: false),
                    ItemPriceInTheBill = table.Column<double>(nullable: false),
                    ItemTotalPriceInTheBill = table.Column<double>(nullable: false),
                    ItemProfitInTheBill = table.Column<double>(nullable: false),
                    ItemNo1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConTableItemAndBills", x => x.BillNo);
                    table.ForeignKey(
                        name: "FK_ConTableItemAndBills_Items_ItemNo1",
                        column: x => x.ItemNo1,
                        principalTable: "Items",
                        principalColumn: "ItemNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConTableItemAndBills_ItemNo1",
                table: "ConTableItemAndBills",
                column: "ItemNo1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConTableItemAndBills");
        }
    }
}
