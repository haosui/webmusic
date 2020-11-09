using Microsoft.EntityFrameworkCore.Migrations;

namespace Quizlet_Fake.Migrations
{
    public partial class suasong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgpaht",
                table: "AppSongbySingers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "songpath",
                table: "AppSongbySingers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgpaht",
                table: "AppSongbySingers");

            migrationBuilder.DropColumn(
                name: "songpath",
                table: "AppSongbySingers");
        }
    }
}
