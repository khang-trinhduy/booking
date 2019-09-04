using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bookingform.Migrations
{
    public partial class addimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Download",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Download");
        }
    }
}
