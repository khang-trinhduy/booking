using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingForm.Migrations
{
    public partial class addproductlistincludingsectionblockfloorapartmentdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_Details_DepartmentDetailsId",
                table: "Catalog");

            migrationBuilder.RenameColumn(
                name: "DepartmentType",
                table: "Details",
                newName: "ApartmentType");

            migrationBuilder.RenameColumn(
                name: "DepartmentDetailsId",
                table: "Catalog",
                newName: "ApartmentDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Catalog_DepartmentDetailsId",
                table: "Catalog",
                newName: "IX_Catalog_ApartmentDetailsId");

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CustomField1 = table.Column<string>(nullable: true),
                    CustomField2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CustomField1 = table.Column<string>(nullable: true),
                    CustomField2 = table.Column<string>(nullable: true),
                    SectionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Block_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CustomField1 = table.Column<string>(nullable: true),
                    CustomField2 = table.Column<string>(nullable: true),
                    BlockId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floor_Block_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    ApartmentDetailsId = table.Column<int>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    NOBedroom = table.Column<string>(nullable: true),
                    NOWC = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Block = table.Column<string>(nullable: true),
                    View = table.Column<string>(nullable: true),
                    LocalCode = table.Column<string>(nullable: true),
                    GlobalCode = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FloorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartment_Details_ApartmentDetailsId",
                        column: x => x.ApartmentDetailsId,
                        principalTable: "Details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apartment_Floor_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_ApartmentDetailsId",
                table: "Apartment",
                column: "ApartmentDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_FloorId",
                table: "Apartment",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Block_SectionId",
                table: "Block",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Floor_BlockId",
                table: "Floor",
                column: "BlockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_Details_ApartmentDetailsId",
                table: "Catalog",
                column: "ApartmentDetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_Details_ApartmentDetailsId",
                table: "Catalog");

            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.RenameColumn(
                name: "ApartmentType",
                table: "Details",
                newName: "DepartmentType");

            migrationBuilder.RenameColumn(
                name: "ApartmentDetailsId",
                table: "Catalog",
                newName: "DepartmentDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Catalog_ApartmentDetailsId",
                table: "Catalog",
                newName: "IX_Catalog_DepartmentDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_Details_DepartmentDetailsId",
                table: "Catalog",
                column: "DepartmentDetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
