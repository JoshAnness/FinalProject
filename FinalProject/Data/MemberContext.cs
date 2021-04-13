using System;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
  public class MemberContext : DbContext
  {

    public MemberContext(DbContextOptions<MemberContext> options) : base(options)
    {

    }

    public DbSet<info> Info {get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<info>().HasData(
          new info
          {
              ID = 1,
              FullName = "Michael Ahlers",
              CollegeProgram = "IT",
              YearInProgram = "Sophmore",
              Birthdate = new DateTime(1990, 05, 12)
          },
          new info
          {
              ID = 2,
              FullName = "Josh Anness",
              CollegeProgram = "IT",
              YearInProgram = "Sophmore",
              Birthdate = new DateTime(2002, 01, 02)
          },
          new info
          {
              ID = 3,
              FullName = "Jeffrey Wallace",
              CollegeProgram = "IT",
              YearInProgram = "Junior",
              Birthdate = new DateTime(2000, 08, 28)
          },
          new info
          {
              ID = 4,
              FullName = "Darrion Hoard",
              CollegeProgram = "IT",
              YearInProgram = "Junior",
              Birthdate = new DateTime(1994, 07, 13)
          },
          new info
          {
              ID = 5,
              FullName = "Bangyan Ju",
              CollegeProgram = "IT",
              YearInProgram = "Junior",
              Birthdate = new DateTime(2000, 02, 04)

          },
          new info
          {
              ID = 6,
              FullName = "Pranav Mahajan",
              CollegeProgram = "IT",
              YearInProgram = "Sophmore",
              Birthdate = new DateTime(2001, 05, 15)
          }
        );
    }
  }

  public class HobbyContext : DbContext
  {

    public HobbyContext(DbContextOptions<HobbyContext> options) : base(options)
    {

    }
    public DbSet<Hobby> Hobbies { get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Hobby>().HasData(
          new Hobby
          {
              Id = 1,
              FullName = "Michael Ahlers",
              FavoriteHobby = "Board Games",
              SecondFavoriteHobby = "Video Games",
              WhyYouLikeThem = "Great way to relax"
          },
          new Hobby
          {
              Id = 2,
              FullName = "Josh Anness",
              FavoriteHobby = "Fishing",
              SecondFavoriteHobby = "Basketball",
              WhyYouLikeThem = "I like being outside and staying active"
          },
          new Hobby
          {
              Id = 3,
              FullName = "Jeffrey Wallace",
              FavoriteHobby = "Cooking",
              SecondFavoriteHobby = "Photography",
              WhyYouLikeThem = "I like exploring"
          },
          new Hobby
          {
              Id = 4,
              FullName = "Darrion Hoard",
              FavoriteHobby = "Cooking",
              SecondFavoriteHobby = "Jiu Jitsu",
              WhyYouLikeThem = "I love to eat and learning new submission points"
          },
           new Hobby
          {
              Id = 5,
              FullName = "Bangyan Ju",
              FavoriteHobby = "Cooking",
              SecondFavoriteHobby = "Swimming",
              WhyYouLikeThem = "They make me feel happy"

          },
        new Hobby
          {
              Id = 6,
              FullName = "Pranav Mahajan",
              FavoriteHobby = "Playing Video Games",
              SecondFavoriteHobby = "Playing Guitar",
              WhyYouLikeThem = "Video games are a fun way to hang out with my friends, and guitar keeps my brain active."
          }
        );
    }
  }
   public class CourseContext : DbContext 
    { 

        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Course>().HasData(
            new Course
            {
              Id = 1,
              FullName = "Michael Ahlers",
              CourseName = "Contemporary Programming",
              CourseID = "IT3080",
              ProfessorName = "Dyllon Dekok"
            },
            new Course
            {
              Id = 2,
              FullName = "Josh Anness",
              CourseName = "Contemporary Programming",
              CourseID = "IT3080",
              ProfessorName = "Dyllon Dekok"
            },
            new Course
            {
              Id = 3,
              FullName = "Jeffrey Wallace",
              CourseName = "Database Management II",
              CourseID = "IT3045",
              ProfessorName = "Aditty Mutsuddi"
            },
            new Course
            {
                Id = 4,
                FullName = "Darrion Hoard",
                CourseName = "Database Management II",
                CourseID = "IT3045",
                ProfessorName = "Professor D"
            },
            new Course
            {
                Id = 5,
                FullName = "Bangyan Ju",
                CourseName = "Database Management II",
                CourseID = "IT3080",
                ProfessorName = "Dyllon Dekok"

            },
            new Course
            {
                Id = 6,
                FullName = "Pranav Mahajan",
                CourseName = "Network Security",
                CourseID = "IT3071",
                ProfessorName = "Professor Mark Stockman"
            }

          );

        }
    }

  public class FoodContext : DbContext
  {

    public FoodContext(DbContextOptions<FoodContext> options) : base(options)
    {

    }
    public DbSet<Food> Foods { get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Food>().HasData(
          new Food
          {
              Id = 1,
              FullName = "Michael Ahlers",
              FavoriteFood = "Sushi",
              SecondFavoriteFood = "Wings",
              FavoriteMealTime = "Dinner"
          },
          new Food
          {
              Id = 2,
              FullName = "Josh Anness",
              FavoriteFood = "Burger",
              SecondFavoriteFood = "Pizza",
              FavoriteMealTime = "Dinner"
          },
          new Food
          {
              Id = 3,
              FullName = "Jeffrey Wallace",
              FavoriteFood = "Loaded Fries",
              SecondFavoriteFood = "Salad",
              FavoriteMealTime = "Dinner"
          },
          new Food
          {
              Id = 4,
              FullName = "Darrion Hoard",
              FavoriteFood = "Pizza",
              SecondFavoriteFood = "Burger",
              FavoriteMealTime = "Dinner"
          },
          new Food
          {
              Id = 5,
              FullName = "Bangyan Ju",
              FavoriteFood = "Pizza",
              SecondFavoriteFood = "Hot pot",
              FavoriteMealTime = "Dinner"
          },
          new Food
          {
              Id = 6,
              FullName = "Pranav Mahajan",
              FavoriteFood = "Cane's Fingers",
              SecondFavoriteFood = "Wings",
              FavoriteMealTime = "Dinner"
          }

        );
    }
  }

  public class SportContext : DbContext 
    {

        public SportContext(DbContextOptions<SportContext> options ) :base(options)
        {
        }

        public DbSet<Sport> Sport { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Sport>().HasData(
              new Sport
              {
                  ID = 1,
                  FullName = "Michael Ahlers",
                  FavoriteSport = "Football",
                  When = new DateTime(2007, 05, 12)
              },
              new Sport

              {
                  ID = 2,
                  FullName = "Josh Anness",
                  FavoriteSport = "Baseball",
                  When = new DateTime(2009, 01, 02)
              },
              new Sport
              {
                  ID = 3,
                  FullName = "Jeffrey Wallace",
                  FavoriteSport = "Swimming",
                  When = new DateTime(2008, 08, 28)
              },
              new Sport
              {
                  ID = 4,
                  FullName = "Darrion Hoard",
                  FavoriteSport = "Skateboarding",
                  When = new DateTime(2005, 07, 13)
              },
               new Sport
               {
                   ID = 5,
                   FullName = "Bangyan Ju",
                   FavoriteSport = "Snowboarding",
                   When = new DateTime(2005, 07, 13)
               },
              new Sport
              {
                  ID = 6,
                  FullName = "Pranav Mahajan",
                  FavoriteSport = "Snooker",
                  When = new DateTime(2010, 05, 15)
              }
            );
        }

    }
}
