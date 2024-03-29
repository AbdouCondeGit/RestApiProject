﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RestApiProject1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230508155314_AddSecondVillaMigrations")]
    partial class AddSecondVillaMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9737),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9742)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9751),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9755)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9763),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            Sqft = 750,
                            UpdateDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9766)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9774),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            Sqft = 900,
                            UpdateDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9777)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9785),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqft = 1100,
                            UpdateDate = new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9788)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
