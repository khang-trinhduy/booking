using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addstorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StorageId",
                table: "Batch",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StorageId",
                table: "Apartment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsOpen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batch_StorageId",
                table: "Batch",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_StorageId",
                table: "Apartment",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Storage_StorageId",
                table: "Apartment",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Batch_Storage_StorageId",
                table: "Batch",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Storage_StorageId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Batch_Storage_StorageId",
                table: "Batch");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropIndex(
                name: "IX_Batch_StorageId",
                table: "Batch");

            migrationBuilder.DropIndex(
                name: "IX_Apartment_StorageId",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Batch");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Apartment");
        }
    }
}
