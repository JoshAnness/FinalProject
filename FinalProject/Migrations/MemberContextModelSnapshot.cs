﻿// <auto-generated />
using System;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(MemberContext))]
    partial class MemberContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.info", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearInProgram")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Info");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Birthdate = new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "IT",
                            FullName = "Michael Ahlers",
                            YearInProgram = "Sophmore"
                        },
                        new
                        {
                            ID = 2,
                            Birthdate = new DateTime(2002, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "IT",
                            FullName = "Josh Anness",
                            YearInProgram = "Sophmore"
                        },
                        new
                        {
                            ID = 3,
                            Birthdate = new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "IT",
                            FullName = "Michael Ahlers",
                            YearInProgram = "Sophmore"
                        },
                        new
                        {
                            ID = 4,
                            Birthdate = new DateTime(1994, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "IT",
                            FullName = "Darrion Hoard",
                            YearInProgram = "Junior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
