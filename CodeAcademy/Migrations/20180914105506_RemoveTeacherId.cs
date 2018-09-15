using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class RemoveTeacherId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Groups");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Groups",
                nullable: true);
        }
    }
}
