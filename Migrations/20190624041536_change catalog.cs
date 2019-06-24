using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class changecatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cmnd",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Catalog");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Catalog",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Acreage",
                table: "Catalog",
                newName: "Area");

            migrationBuilder.AddColumn<int>(
                name: "NOBedroom",
                table: "Catalog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NOWC",
                table: "Catalog",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NOBedroom",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "NOWC",
                table: "Catalog");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Catalog",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Catalog",
                newName: "Acreage");

            migrationBuilder.AddColumn<string>(
                name: "Cmnd",
                table: "Catalog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Catalog",
                nullable: true);
        }
    }
}
