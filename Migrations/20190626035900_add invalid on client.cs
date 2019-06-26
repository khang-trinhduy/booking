using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addinvalidonclient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "RCode",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "Client",
                nullable: false,
                defaultValue: true);

            migrationBuilder.CreateIndex(
                name: "IX_RCode_ClientId",
                table: "RCode",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_RCode_Client_ClientId",
                table: "RCode",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RCode_Client_ClientId",
                table: "RCode");

            migrationBuilder.DropIndex(
                name: "IX_RCode_ClientId",
                table: "RCode");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "RCode");

            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "Client");
        }
    }
}
