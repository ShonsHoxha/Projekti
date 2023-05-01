using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetagogetdheDepartamenti.Migrations
{
    public partial class DdheP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmriD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Petagoget",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DEP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lenda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Petagoget", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Petagoget_Departamentet_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departamentet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Petagoget_DepartamentId",
                table: "Petagoget",
                column: "DepartamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Petagoget");

            migrationBuilder.DropTable(
                name: "Departamentet");
        }
    }
}
