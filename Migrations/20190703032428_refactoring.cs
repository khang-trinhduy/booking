using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NOfReserved",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "Reserved",
                table: "Apartment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NOfReserved",
                table: "Apartment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Reserved",
                table: "Apartment",
                nullable: false,
                defaultValue: false);
        }
    }
}
