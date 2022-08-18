﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkateRate.Models;

namespace SkateRate.Migrations
{
    [DbContext(typeof(SkateRateContext))]
    partial class SkateRateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SkateRate.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Location = "Woolly Mammoth",
                            Name = "Matilda",
                            Nickname = "Female",
                            Rating = 7
                        },
                        new
                        {
                            ParkId = 2,
                            Location = "Dinosaur",
                            Name = "Rexie",
                            Nickname = "Female",
                            Rating = 10
                        },
                        new
                        {
                            ParkId = 3,
                            Location = "Dinosaur",
                            Name = "Matilda",
                            Nickname = "Female",
                            Rating = 2
                        },
                        new
                        {
                            ParkId = 4,
                            Location = "Shark",
                            Name = "Pip",
                            Nickname = "Male",
                            Rating = 4
                        },
                        new
                        {
                            ParkId = 5,
                            Location = "Dinosaur",
                            Name = "Bartholomew",
                            Nickname = "Male",
                            Rating = 22
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
