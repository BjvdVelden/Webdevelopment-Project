using Microsoft.EntityFrameworkCore.Migrations;

namespace WebdevelopmentProject.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Report",
                newName: "ApplicationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ApplicationUserID",
                table: "Report",
                column: "ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_AspNetUsers_ApplicationUserID",
                table: "Report",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_AspNetUsers_ApplicationUserID",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Report_ApplicationUserID",
                table: "Report");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Report",
                newName: "Name");
        }
    }
}
