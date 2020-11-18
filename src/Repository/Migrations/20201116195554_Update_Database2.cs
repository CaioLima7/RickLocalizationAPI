using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Update_Database2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameFile",
                table: "RickandMorty");

            migrationBuilder.AddColumn<string>(
                name: "ImgFileMorty",
                table: "RickandMorty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgFileRick",
                table: "RickandMorty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgFileMorty",
                table: "RickandMorty");

            migrationBuilder.DropColumn(
                name: "ImgFileRick",
                table: "RickandMorty");

            migrationBuilder.AddColumn<string>(
                name: "NameFile",
                table: "RickandMorty",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
