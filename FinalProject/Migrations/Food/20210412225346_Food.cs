using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.Food
{
    public partial class Food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteFood = table.Column<string>(nullable: true),
                    SecondFavoriteFood = table.Column<string>(nullable: true),
                    FavoriteMealTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FavoriteFood", "FavoriteMealTime", "FullName", "SecondFavoriteFood" },
                values: new object[,]
                {
                    { 1, "Pizza", "Lunch", "Michael Ahlers", "Wings" },
                    { 2, "Burger", "Dinner", "Josh Anness", "Pizza" },
                    { 3, "Loaded Fries", "Dinner", "Jeffrey Wallace", "Salad" },
                    { 4, "Pizza", "Dinner", "Darrion Hoard", "Burger" },
                    { 5, "Pizza", "Dinner", "Bangyan Ju", "Hot pot" },
                    { 6, "Cane's Fingers", "Dinner", "Pranav Mahajan", "Wings" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
