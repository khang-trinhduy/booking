using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class removestageonrcodeapartmentaddcustomeronreservedcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stage",
                table: "RCode");

            migrationBuilder.DropColumn(
                name: "Stage",
                table: "Apartment");

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Reserve",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RCC",
                table: "Reserve",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Reserve");

            migrationBuilder.DropColumn(
                name: "RCC",
                table: "Reserve");

            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "RCode",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "Apartment",
                nullable: false,
                defaultValue: 0);
        }
    }
}
