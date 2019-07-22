using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addinvoicetobatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "Invoice",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_BatchId",
                table: "Invoice",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Batch_BatchId",
                table: "Invoice",
                column: "BatchId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Batch_BatchId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_BatchId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Invoice");
        }
    }
}
