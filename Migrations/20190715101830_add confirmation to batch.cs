using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addconfirmationtobatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "Confirmation",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Confirmation_BatchId",
                table: "Confirmation",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Confirmation_Batch_BatchId",
                table: "Confirmation",
                column: "BatchId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Confirmation_Batch_BatchId",
                table: "Confirmation");

            migrationBuilder.DropIndex(
                name: "IX_Confirmation_BatchId",
                table: "Confirmation");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Confirmation");
        }
    }
}
