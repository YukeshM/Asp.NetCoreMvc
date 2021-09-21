using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelMenuApplicationRepository.DataAccess.Migrations
{
    public partial class newbd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "MenuTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "MenuTable");
        }
    }
}
