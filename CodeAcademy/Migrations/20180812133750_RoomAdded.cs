using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class RoomAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Faculties_FacultyId1",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_FacultyId1",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "FacultyId1",
                table: "Groups");

            migrationBuilder.AlterColumn<byte>(
                name: "FacultyId",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<byte>(
                name: "RoomId",
                table: "Groups",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FacultyId",
                table: "Groups",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_RoomId",
                table: "Groups",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Faculties_FacultyId",
                table: "Groups",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Room_RoomId",
                table: "Groups",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Faculties_FacultyId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Room_RoomId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Groups_FacultyId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_RoomId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<byte>(
                name: "FacultyId1",
                table: "Groups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FacultyId1",
                table: "Groups",
                column: "FacultyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Faculties_FacultyId1",
                table: "Groups",
                column: "FacultyId1",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
