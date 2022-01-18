using Microsoft.EntityFrameworkCore.Migrations;

namespace Webdevelopment_Project.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zelfhulpgroep",
                columns: table => new
                {
                    Naam = table.Column<string>(type: "TEXT", nullable: false),
                    Onderwerp = table.Column<string>(type: "TEXT", nullable: true),
                    MinimaleLeeftijd = table.Column<int>(type: "INTEGER", nullable: false),
                    MaximaleLeeftijd = table.Column<int>(type: "INTEGER", nullable: false),
                    Beheerder = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zelfhulpgroep", x => x.Naam);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zelfhulpgroep");
        }
    }
}
