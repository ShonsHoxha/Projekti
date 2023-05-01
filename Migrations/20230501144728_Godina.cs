using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetagogetdheDepartamenti.Migrations
{
    public partial class Godina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Godina",
                table: "Departamentet",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Godina",
                table: "Departamentet");
        }
    }
}
