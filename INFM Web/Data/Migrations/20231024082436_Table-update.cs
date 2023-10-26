using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INFM_Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Tableupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_SoppingCart_ShoppingCart_Id1",
                table: "CartDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_Category_Id1",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Suppliers_Supplier_Id1",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoppingCart",
                table: "SoppingCart");

            migrationBuilder.RenameTable(
                name: "SoppingCart",
                newName: "ShoppingCart");

            migrationBuilder.AlterColumn<int>(
                name: "Supplier_Id1",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Category_Id1",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "ShoppingCart_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_ShoppingCart_ShoppingCart_Id1",
                table: "CartDetail",
                column: "ShoppingCart_Id1",
                principalTable: "ShoppingCart",
                principalColumn: "ShoppingCart_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_Category_Id1",
                table: "Product",
                column: "Category_Id1",
                principalTable: "Category",
                principalColumn: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Suppliers_Supplier_Id1",
                table: "Product",
                column: "Supplier_Id1",
                principalTable: "Suppliers",
                principalColumn: "Supplier_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_ShoppingCart_ShoppingCart_Id1",
                table: "CartDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_Category_Id1",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Suppliers_Supplier_Id1",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "SoppingCart");

            migrationBuilder.AlterColumn<int>(
                name: "Supplier_Id1",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Category_Id1",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoppingCart",
                table: "SoppingCart",
                column: "ShoppingCart_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_SoppingCart_ShoppingCart_Id1",
                table: "CartDetail",
                column: "ShoppingCart_Id1",
                principalTable: "SoppingCart",
                principalColumn: "ShoppingCart_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_Category_Id1",
                table: "Product",
                column: "Category_Id1",
                principalTable: "Category",
                principalColumn: "Category_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Suppliers_Supplier_Id1",
                table: "Product",
                column: "Supplier_Id1",
                principalTable: "Suppliers",
                principalColumn: "Supplier_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
