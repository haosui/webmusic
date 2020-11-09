using Microsoft.EntityFrameworkCore.Migrations;

namespace Quizlet_Fake.Migrations
{
    public partial class suasong3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "namepath",
                table: "AppSongs");

            migrationBuilder.AddColumn<string>(
                name: "imagepath",
                table: "AppSongs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagepath",
                table: "AppSongs");

            migrationBuilder.AddColumn<string>(
                name: "namepath",
                table: "AppSongs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
