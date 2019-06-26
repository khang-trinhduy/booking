using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addnofreserved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NOfReserved",
                table: "Apartment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NOfReserved",
                table: "Apartment");
        }
    }
}
