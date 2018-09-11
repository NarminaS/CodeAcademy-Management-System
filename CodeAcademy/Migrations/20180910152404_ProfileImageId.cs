using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class ProfileImageId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "AspNetUsers",
                newName: "ProfileImageId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ProfileImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ProfileImageId",
                table: "AspNetUsers",
                column: "ProfileImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ProfileImageId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ProfileImageId",
                table: "AspNetUsers",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ProfileImageId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
