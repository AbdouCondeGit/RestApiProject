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
    [Migration("20230628024025_SeedBdAgain")]
    partial class SeedBdAgain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
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
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7626),
                            Details = "Villa Ephrussi de Rothschild is located in Saint-Jean-Cap-Ferrat on the French Riviera. It offers panoramic views of the Mediterranean Sea and magnificent gardens.",
                            ImageUrl = "paradisiaque6.jpg",
                            Name = "Villa Ephrussi de Rothschild",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7628)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7635),
                            Details = "Villa Kérylos is a faithful reconstruction of an ancient Greek residence located in Beaulieu-sur-Mer on the French Riviera. It offers a unique experience in a stunning setting.",
                            ImageUrl = "paradisiaque7.jpg",
                            Name = "Villa Kérylos",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7638)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7643),
                            Details = "Villa La Roche, designed by architect Le Corbusier, is located in Paris. It houses a collection of modern art and provides an interesting perspective on 20th-century architecture.",
                            ImageUrl = "paradisiaque8.jpg",
                            Name = "Villa La Roche",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7645)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7649),
                            Details = "Villa Savoye, another iconic creation by Le Corbusier, is considered a masterpiece of modern architecture. It is located in Poissy, France.",
                            ImageUrl = "paradisiaque9.jpg",
                            Name = "Villa Savoye",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7651)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7656),
                            Details = "Villa Balbianello is located on the shores of Lake Como in Italy, accessible from France. It is surrounded by beautiful terraced gardens and offers spectacular views of the lake.",
                            ImageUrl = "paradisiaque10.jpg",
                            Name = "Villa Balbianello",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7657)
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7662),
                            Details = "Villa Noailles is a modernist villa in Hyères. It houses an art and architecture center and hosts the International Festival of Fashion and Photography in Hyères.",
                            ImageUrl = "paradisiaque11.jpg",
                            Name = "Villa Noailles",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7664)
                        },
                        new
                        {
                            Id = 7,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7669),
                            Details = "Villa Domergue is an Art Deco villa located on the hills of Cannes. It offers breathtaking views of the city and the sea.",
                            ImageUrl = "paradisiaque12.jpg",
                            Name = "Villa Domergue",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7670)
                        },
                        new
                        {
                            Id = 8,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7675),
                            Details = "Villa Les Cèdres is the former residence of King Leopold II of Belgium. It is located in Saint-Jean-Cap-Ferrat and is surrounded by vast botanical gardens and an impressive art collection.",
                            ImageUrl = "paradisiaque13.jpg",
                            Name = "Villa Les Cèdres",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7677)
                        },
                        new
                        {
                            Id = 9,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7681),
                            Details = "Villa Médicis is a Renaissance villa located in Rome, Italy. It serves as the French Academy in Rome and hosts various artists and scholars.",
                            ImageUrl = "paradisiaque14.jpg",
                            Name = "Villa Médicis",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7683)
                        },
                        new
                        {
                            Id = 10,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7688),
                            Details = "The Malibu Beach Villa is a luxurious oceanfront retreat located in Malibu, California. It offers stunning views of the Pacific Ocean and direct access to the beach.",
                            ImageUrl = "paradisiaque15.jpg",
                            Name = "Malibu Beach Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7690)
                        },
                        new
                        {
                            Id = 11,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7695),
                            Details = "The Aspen Mountain Chalet is nestled in the scenic mountains of Aspen, Colorado. It features a cozy interior, breathtaking views, and convenient access to skiing and outdoor activities.",
                            ImageUrl = "paradisiaque16.jpg",
                            Name = "Aspen Mountain Chalet",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7696)
                        },
                        new
                        {
                            Id = 12,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7701),
                            Details = "The Hawaiian Paradise Villa is a tropical oasis located on the island of Maui, Hawaii. It offers a private pool, lush gardens, and easy access to beautiful beaches.",
                            ImageUrl = "paradisiaque17.jpg",
                            Name = "Hawaiian Paradise Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7703)
                        },
                        new
                        {
                            Id = 13,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7708),
                            Details = "The Miami Beachfront Villa is a luxurious waterfront property located in Miami, Florida. It features modern design, panoramic ocean views, and a private dock for boating enthusiasts.",
                            ImageUrl = "paradisiaque18.jpg",
                            Name = "Miami Beachfront Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7709)
                        },
                        new
                        {
                            Id = 14,
                            Amenity = "",
                            CreatedBy = "Abdou",
                            CreatedDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7714),
                            Details = "The Lake Tahoe Retreat is a serene getaway nestled in the breathtaking mountains of Lake Tahoe, California. It offers a tranquil setting, outdoor activities, and access to the stunning lake.",
                            ImageUrl = "paradisiaque19.jpg",
                            Name = "Lake Tahoe Retreat",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 6, 28, 4, 40, 25, 194, DateTimeKind.Local).AddTicks(7716)
                        });
                });

            modelBuilder.Entity("Models.VillaValue", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaValues");
                });

            modelBuilder.Entity("Models.VillaValue", b =>
                {
                    b.HasOne("Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
