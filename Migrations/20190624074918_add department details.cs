using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class adddepartmentdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Catalog",
                newName: "LocalCode");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDetailsId",
                table: "Catalog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GlobalCode",
                table: "Catalog",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentType = table.Column<string>(nullable: true),
                    AreaIncludeWall = table.Column<string>(nullable: true),
                    AreaWithoutWall = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_DepartmentDetailsId",
                table: "Catalog",
                column: "DepartmentDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_Details_DepartmentDetailsId",
                table: "Catalog",
                column: "DepartmentDetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_Details_DepartmentDetailsId",
                table: "Catalog");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropIndex(
                name: "IX_Catalog_DepartmentDetailsId",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "DepartmentDetailsId",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "GlobalCode",
                table: "Catalog");

            migrationBuilder.RenameColumn(
                name: "LocalCode",
                table: "Catalog",
                newName: "Code");
        }
    }
}
