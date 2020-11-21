using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Catering.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FoodBookings_MenuId",
                table: "FoodBookings",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodBookings_Menus_MenuId",
                table: "FoodBookings",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodBookings_Menus_MenuId",
                table: "FoodBookings");

            migrationBuilder.DropIndex(
                name: "IX_FoodBookings_MenuId",
                table: "FoodBookings");
        }
    }
}
