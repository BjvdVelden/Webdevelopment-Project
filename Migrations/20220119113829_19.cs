using Microsoft.EntityFrameworkCore.Migrations;

namespace Webdevelopment_Project.Migrations
{
    public partial class _19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "Intake",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Intake_ApplicationUserID",
                table: "Intake",
                column: "ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Intake_AspNetUsers_ApplicationUserID",
                table: "Intake",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intake_AspNetUsers_ApplicationUserID",
                table: "Intake");

            migrationBuilder.DropIndex(
                name: "IX_Intake_ApplicationUserID",
                table: "Intake");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "Intake");
        }
    }
}
