using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webdevelopment_Project.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Messages",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Messages",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                newName: "IX_Messages_UserID");

            migrationBuilder.CreateTable(
                name: "Intake",
                columns: table => new
                {
                    IntakeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Voornaam = table.Column<string>(type: "TEXT", nullable: false),
                    Achternaam = table.Column<string>(type: "TEXT", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BSN = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    GewensteHulpverlener = table.Column<string>(type: "TEXT", nullable: true),
                    GewensteMoment = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Onderwerp = table.Column<string>(type: "TEXT", nullable: true),
                    AanmaakDatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsAfgehandeld = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intake", x => x.IntakeId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserID",
                table: "Messages",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserID",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Intake");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Messages",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Messages",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_UserID",
                table: "Messages",
                newName: "IX_Messages_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
