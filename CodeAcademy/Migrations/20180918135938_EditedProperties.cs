using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class EditedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment_Description",
                table: "Posts",
                newName: "Comment_Text");

            migrationBuilder.RenameColumn(
                name: "Book_Description",
                table: "Posts",
                newName: "Text");

            migrationBuilder.AddColumn<string>(
                name: "InnerText",
                table: "Posts",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InnerText",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Comment_Text",
                table: "Posts",
                newName: "Comment_Description");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Posts",
                newName: "Book_Description");
        }
    }
}
