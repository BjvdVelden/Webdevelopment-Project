using Microsoft.EntityFrameworkCore.Migrations;

namespace Webdevelopment_Project.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Afspraak_AspNetUsers_ClientId",
                table: "Afspraak");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraak_AspNetUsers_HulpverlenerId",
                table: "Afspraak");

            migrationBuilder.DropIndex(
                name: "IX_Afspraak_ClientId",
                table: "Afspraak");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Afspraak");

            migrationBuilder.RenameColumn(
                name: "HulpverlenerId",
                table: "Afspraak",
                newName: "ApplicationUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Afspraak_HulpverlenerId",
                table: "Afspraak",
                newName: "IX_Afspraak_ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraak_AspNetUsers_ApplicationUserID",
                table: "Afspraak",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Afspraak_AspNetUsers_ApplicationUserID",
                table: "Afspraak");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Afspraak",
                newName: "HulpverlenerId");

            migrationBuilder.RenameIndex(
                name: "IX_Afspraak_ApplicationUserID",
                table: "Afspraak",
                newName: "IX_Afspraak_HulpverlenerId");

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Afspraak",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Afspraak_ClientId",
                table: "Afspraak",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraak_AspNetUsers_ClientId",
                table: "Afspraak",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraak_AspNetUsers_HulpverlenerId",
                table: "Afspraak",
                column: "HulpverlenerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
