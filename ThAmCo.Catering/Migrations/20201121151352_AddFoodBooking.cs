using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Catering.Migrations
{
    public partial class AddFoodBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodBookings",
                columns: table => new
                {
                    FoodBookingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientReferenceId = table.Column<int>(nullable: false),
                    NumberOfGuests = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBookings", x => x.FoodBookingId);
                });

            migrationBuilder.InsertData(
                table: "FoodBookings",
                columns: new[] { "FoodBookingId", "ClientReferenceId", "MenuId", "NumberOfGuests" },
                values: new object[,]
                {
                    { 1, 1, 2, 22 },
                    { 2, 1, 1, 17 },
                    { 3, 16, 3, 7 },
                    { 4, 5, 2, 19 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodBookings");
        }
    }
}
