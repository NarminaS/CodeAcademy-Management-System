using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class ImageIdToGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ImageId",
                table: "Groups",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Images_ImageId",
                table: "Groups",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Images_ImageId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ImageId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Groups");
        }
    }
}
