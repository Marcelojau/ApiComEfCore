using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalog.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prodcut_Category_CategoryId",
                table: "Prodcut");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prodcut",
                table: "Prodcut");

            migrationBuilder.RenameTable(
                name: "Prodcut",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Prodcut_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Prodcut");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Prodcut",
                newName: "IX_Prodcut_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prodcut",
                table: "Prodcut",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prodcut_Category_CategoryId",
                table: "Prodcut",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
