using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBS.Data.Migrations
{
    public partial class BurgerItemsWithNoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BurgerItems",
                table: "BurgerItems");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "BurgerItems");

            migrationBuilder.DropColumn(
                name: "Beef",
                table: "BurgerItems");

            migrationBuilder.RenameColumn(
                name: "Tomato",
                table: "BurgerItems",
                newName: "Vegetables");

            migrationBuilder.RenameColumn(
                name: "Lettuce",
                table: "BurgerItems",
                newName: "Sauce");

            migrationBuilder.RenameColumn(
                name: "Ketchup",
                table: "BurgerItems",
                newName: "Protein");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vegetables",
                table: "BurgerItems",
                newName: "Tomato");

            migrationBuilder.RenameColumn(
                name: "Sauce",
                table: "BurgerItems",
                newName: "Lettuce");

            migrationBuilder.RenameColumn(
                name: "Protein",
                table: "BurgerItems",
                newName: "Ketchup");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "BurgerItems",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Beef",
                table: "BurgerItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BurgerItems",
                table: "BurgerItems",
                column: "ID");
        }
    }
}
