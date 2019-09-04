using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bookingform.Migrations
{
    public partial class addfilescodeclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Code",
                table: "Print",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Download",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QRCode = table.Column<string>(nullable: true),
                    File = table.Column<string>(nullable: true),
                    PrintId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Download", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Download_Print_PrintId",
                        column: x => x.PrintId,
                        principalTable: "Print",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Download_PrintId",
                table: "Download",
                column: "PrintId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Download");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Print");
        }
    }
}
