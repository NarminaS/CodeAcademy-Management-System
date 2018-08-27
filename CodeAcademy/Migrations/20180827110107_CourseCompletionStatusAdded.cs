using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class CourseCompletionStatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseCompletionStatusId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseCompletionStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCompletionStatuses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CourseCompletionStatusId",
                table: "AspNetUsers",
                column: "CourseCompletionStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CourseCompletionStatuses_CourseCompletionStatusId",
                table: "AspNetUsers",
                column: "CourseCompletionStatusId",
                principalTable: "CourseCompletionStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CourseCompletionStatuses_CourseCompletionStatusId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CourseCompletionStatuses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CourseCompletionStatusId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CourseCompletionStatusId",
                table: "AspNetUsers");
        }
    }
}
