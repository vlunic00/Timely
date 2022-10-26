using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Timely.Data.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectDateTime",
                table: "Project");

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectEndTime",
                table: "Project",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectStartTime",
                table: "Project",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectEndTime",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectStartTime",
                table: "Project");

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectDateTime",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
