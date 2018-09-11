using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademy.Migrations
{
    public partial class LessonHourEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginTime",
                table: "LessonHours");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "LessonHours");

            migrationBuilder.AddColumn<byte>(
                name: "BeginHour",
                table: "LessonHours",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "BeginMinute",
                table: "LessonHours",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "EndHour",
                table: "LessonHours",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "EndMinute",
                table: "LessonHours",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginHour",
                table: "LessonHours");

            migrationBuilder.DropColumn(
                name: "BeginMinute",
                table: "LessonHours");

            migrationBuilder.DropColumn(
                name: "EndHour",
                table: "LessonHours");

            migrationBuilder.DropColumn(
                name: "EndMinute",
                table: "LessonHours");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginTime",
                table: "LessonHours",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "LessonHours",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
