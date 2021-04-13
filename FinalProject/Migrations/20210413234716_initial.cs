using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true),
                    CourseID = table.Column<string>(nullable: true),
                    ProfessorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteHobby = table.Column<string>(nullable: true),
                    SecondFavoriteHobby = table.Column<string>(nullable: true),
                    WhyYouLikeThem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    CollegeProgram = table.Column<string>(nullable: true),
                    YearInProgram = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.ID);
                });

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
                table: "Courses",
                columns: new[] { "Id", "CourseID", "CourseName", "FullName", "ProfessorName" },
                values: new object[,]
                {
                    { 1, "IT3080", "Contemporary Programming", "Michael Ahlers", "Dyllon Dekok" },
                    { 2, "IT3080", "Contemporary Programming", "Josh Anness", "Dyllon Dekok" },
                    { 3, "IT3045", "Database Management II", "Jeffrey Wallace", "Aditty Mutsuddi" },
                    { 4, "IT3045", "Database Management II", "Darrion Hoard", "Professor D" },
                    { 5, "IT3080", "Database Management II", "Bangyan Ju", "Dyllon Dekok" },
                    { 6, "IT3071", "Network Security", "Pranav Mahajan", "Professor Mark Stockman" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FavoriteFood", "FavoriteMealTime", "FullName", "SecondFavoriteFood" },
                values: new object[,]
                {
                    { 1, "Sushi", "Dinner", "Michael Ahlers", "Wings" },
                    { 2, "Burger", "Dinner", "Josh Anness", "Pizza" },
                    { 3, "Loaded Fries", "Dinner", "Jeffrey Wallace", "Salad" },
                    { 4, "Pizza", "Dinner", "Darrion Hoard", "Burger" },
                    { 5, "Pizza", "Dinner", "Bangyan Ju", "Hot pot" },
                    { 6, "Cane's Fingers", "Dinner", "Pranav Mahajan", "Wings" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "FavoriteHobby", "FullName", "SecondFavoriteHobby", "WhyYouLikeThem" },
                values: new object[,]
                {
                    { 6, "Playing Video Games", "Pranav Mahajan", "Playing Guitar", "Video games are a fun way to hang out with my friends, and guitar keeps my brain active." },
                    { 5, "Cooking", "Bangyan Ju", "Swimming", "They make me feel happy" },
                    { 4, "Cooking", "Darrion Hoard", "Jiu Jitsu", "I love to eat and learning new submission points" },
                    { 3, "Cooking", "Jeffrey Wallace", "Photography", "I like exploring" },
                    { 2, "Fishing", "Josh Anness", "Basketball", "I like being outside and staying active" },
                    { 1, "Board Games", "Michael Ahlers", "Video Games", "Great way to relax" }
                });

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Michael Ahlers", "Sophmore" },
                    { 2, new DateTime(2002, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Josh Anness", "Sophmore" },
                    { 3, new DateTime(2000, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Jeffrey Wallace", "Junior" },
                    { 4, new DateTime(1994, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Darrion Hoard", "Junior" },
                    { 5, new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Bangyan Ju", "Junior" },
                    { 6, new DateTime(2001, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Pranav Mahajan", "Sophmore" }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "ID", "FavoriteSport", "FullName", "When" },
                values: new object[,]
                {
                    { 1, "Football", "Michael Ahlers", new DateTime(2007, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Baseball", "Josh Anness", new DateTime(2009, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Swimming", "Jeffrey Wallace", new DateTime(2008, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Skateboarding", "Darrion Hoard", new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Snowboarding", "Bangyan Ju", new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Snooker", "Pranav Mahajan", new DateTime(2010, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "Sport");
        }
    }
}
