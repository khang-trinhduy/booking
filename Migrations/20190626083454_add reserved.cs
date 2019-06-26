using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addreserved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Reserved",
                table: "Apartment",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Reserve",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cmnd = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ApartmentCode = table.Column<string>(nullable: true),
                    RCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserve", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserve");

            migrationBuilder.DropColumn(
                name: "Reserved",
                table: "Apartment");
        }
    }
}
