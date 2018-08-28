using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class LessonHour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LessonHourId",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LessonHours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonHours", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_LessonHourId",
                table: "Groups",
                column: "LessonHourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_LessonHours_LessonHourId",
                table: "Groups",
                column: "LessonHourId",
                principalTable: "LessonHours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_LessonHours_LessonHourId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "LessonHours");

            migrationBuilder.DropIndex(
                name: "IX_Groups_LessonHourId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "LessonHourId",
                table: "Groups");
        }
    }
}
