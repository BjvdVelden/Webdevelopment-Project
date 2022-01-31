using Microsoft.EntityFrameworkCore.Migrations;

namespace WebdevelopmentProject.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_AspNetUsers_UserNameId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Report_UserNameId",
                table: "Report");

            migrationBuilder.DropColumn(
                name: "UserNameId",
                table: "Report");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserNameId",
                table: "Report",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Report_UserNameId",
                table: "Report",
                column: "UserNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_AspNetUsers_UserNameId",
                table: "Report",
                column: "UserNameId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
