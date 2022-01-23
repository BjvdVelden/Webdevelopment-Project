using Microsoft.EntityFrameworkCore.Migrations;

namespace WebdevelopmentProject.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_AspNetUsers_ApplicationUserID",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Messages_MessageId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Report_ApplicationUserID",
                table: "Report");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Report",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Report",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Messages_MessageId",
                table: "Report",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_Messages_MessageId",
                table: "Report");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Report",
                newName: "ApplicationUserID");

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Report",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Messages_MessageId",
                table: "Report",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
