using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addcatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog",
                columns: table => new
                {
                    Floor = table.Column<string>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    Acreage = table.Column<double>(nullable: false),
                    Cmnd = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    Block = table.Column<string>(nullable: true),
                    View = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog");
        }
    }
}
