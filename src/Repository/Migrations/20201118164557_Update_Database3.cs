using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Update_Database3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RickId",
                table: "Navigations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RickId",
                table: "Navigations");
        }
    }
}
