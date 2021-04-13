using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.Sport
{
    public partial class Sport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteSport = table.Column<string>(nullable: true),
                    When = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "ID", "FavoriteSport", "FullName", "When" },
                values: new object[,]
                {
                    { 1, "Football", "Michael Ahlers", new DateTime(2007, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Soccer", "Josh Anness", new DateTime(2009, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Swimming", "Jeffrey Wallace", new DateTime(2008, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Hockey", "Darrion Hoard", new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Snooker", "Pranav Mahajan", new DateTime(2010, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sport");
        }
    }
}
