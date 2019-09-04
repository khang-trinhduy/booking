using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addreservedtobatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "Reserve",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserve_BatchId",
                table: "Reserve",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserve_Batch_BatchId",
                table: "Reserve",
                column: "BatchId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserve_Batch_BatchId",
                table: "Reserve");

            migrationBuilder.DropIndex(
                name: "IX_Reserve_BatchId",
                table: "Reserve");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Reserve");
        }
    }
}
