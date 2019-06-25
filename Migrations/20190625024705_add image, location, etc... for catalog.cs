using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addimagelocationetcforcatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Section",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Section",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Floor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Block",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Block",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Apartment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Floor");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Block");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Block");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Apartment");
        }
    }
}
