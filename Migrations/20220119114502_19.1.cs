using Microsoft.EntityFrameworkCore.Migrations;

namespace Webdevelopment_Project.Migrations
{
    public partial class _191 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intake_AspNetUsers_ApplicationUserID",
                table: "Intake");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Intake",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Intake_ApplicationUserID",
                table: "Intake",
                newName: "IX_Intake_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intake_AspNetUsers_ApplicationUserId",
                table: "Intake",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intake_AspNetUsers_ApplicationUserId",
                table: "Intake");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Intake",
                newName: "ApplicationUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Intake_ApplicationUserId",
                table: "Intake",
                newName: "IX_Intake_ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Intake_AspNetUsers_ApplicationUserID",
                table: "Intake",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
