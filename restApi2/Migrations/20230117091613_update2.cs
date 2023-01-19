using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace restApi2.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderNo",
                table: "order",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "order",
                newName: "quantity");

            migrationBuilder.AddColumn<int>(
                name: "tableNumber",
                table: "items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tableNumber",
                table: "items");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "order",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "order",
                newName: "OrderNo");
        }
    }
}
