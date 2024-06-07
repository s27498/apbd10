using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductsPK_product",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_ProductsPK_product",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "ProductsPK_product",
                table: "ShoppingCarts");

            migrationBuilder.RenameColumn(
                name: "FK_role",
                table: "ShoppingCarts",
                newName: "FK_Product");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_FK_Product",
                table: "ShoppingCarts",
                column: "FK_Product");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_FK_Product",
                table: "ShoppingCarts",
                column: "FK_Product",
                principalTable: "Products",
                principalColumn: "PK_product",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_FK_Product",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_FK_Product",
                table: "ShoppingCarts");

            migrationBuilder.RenameColumn(
                name: "FK_Product",
                table: "ShoppingCarts",
                newName: "FK_role");

            migrationBuilder.AddColumn<int>(
                name: "ProductsPK_product",
                table: "ShoppingCarts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductsPK_product",
                table: "ShoppingCarts",
                column: "ProductsPK_product");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductsPK_product",
                table: "ShoppingCarts",
                column: "ProductsPK_product",
                principalTable: "Products",
                principalColumn: "PK_product");
        }
    }
}
