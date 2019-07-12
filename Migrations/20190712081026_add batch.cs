using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addbatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "RCode",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "Apartment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatchNumber = table.Column<int>(nullable: false),
                    IsRunning = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RCode_BatchId",
                table: "RCode",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_BatchId",
                table: "Apartment",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Batch_BatchId",
                table: "Apartment",
                column: "BatchId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RCode_Batch_BatchId",
                table: "RCode",
                column: "BatchId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Batch_BatchId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_RCode_Batch_BatchId",
                table: "RCode");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropIndex(
                name: "IX_RCode_BatchId",
                table: "RCode");

            migrationBuilder.DropIndex(
                name: "IX_Apartment_BatchId",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "RCode");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Apartment");
        }
    }
}
