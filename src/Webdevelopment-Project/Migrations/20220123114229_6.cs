using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebdevelopmentProject.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BehandelaarEmail",
                table: "ChatUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bericht",
                table: "ChatUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientEmail",
                table: "ChatUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "verzendTijd",
                table: "ChatUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BehandelaarEmail",
                table: "ChatUsers");

            migrationBuilder.DropColumn(
                name: "Bericht",
                table: "ChatUsers");

            migrationBuilder.DropColumn(
                name: "ClientEmail",
                table: "ChatUsers");

            migrationBuilder.DropColumn(
                name: "verzendTijd",
                table: "ChatUsers");
        }
    }
}
