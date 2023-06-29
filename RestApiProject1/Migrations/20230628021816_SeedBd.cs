using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestApiProject1.Migrations
{
    /// <inheritdoc />
    public partial class SeedBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3649), "Villa Ephrussi de Rothschild is located in Saint-Jean-Cap-Ferrat on the French Riviera. It offers panoramic views of the Mediterranean Sea and magnificent gardens.", "~/js/paradisiaque6.jpg", "Villa Ephrussi de Rothschild", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3655), "Villa Kérylos is a faithful reconstruction of an ancient Greek residence located in Beaulieu-sur-Mer on the French Riviera. It offers a unique experience in a stunning setting.", "~/js/paradisiaque7.jpg", "Villa Kérylos", 200.0, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3659), "Villa La Roche, designed by architect Le Corbusier, is located in Paris. It houses a collection of modern art and provides an interesting perspective on 20th-century architecture.", "~/js/paradisiaque8.jpg", "Villa La Roche", 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3664), "Villa Savoye, another iconic creation by Le Corbusier, is considered a masterpiece of modern architecture. It is located in Poissy, France.", "~/js/paradisiaque9.jpg", "Villa Savoye", 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3668), "Villa Balbianello is located on the shores of Lake Como in Italy, accessible from France. It is surrounded by beautiful terraced gardens and offers spectacular views of the lake.", "~/js/paradisiaque10.jpg", "Villa Balbianello", 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedBy", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 6, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3672), "Villa Noailles is a modernist villa in Hyères. It houses an art and architecture center and hosts the International Festival of Fashion and Photography in Hyères.", "~/js/paradisiaque11.jpg", "Villa Noailles", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3674) },
                    { 7, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3677), "Villa Domergue is an Art Deco villa located on the hills of Cannes. It offers breathtaking views of the city and the sea.", "~/js/paradisiaque12.jpg", "Villa Domergue", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3678) },
                    { 8, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3681), "Villa Les Cèdres is the former residence of King Leopold II of Belgium. It is located in Saint-Jean-Cap-Ferrat and is surrounded by vast botanical gardens and an impressive art collection.", "~/js/paradisiaque13.jpg", "Villa Les Cèdres", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3682) },
                    { 9, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3685), "Villa Médicis is a Renaissance villa located in Rome, Italy. It serves as the French Academy in Rome and hosts various artists and scholars.", "~/js/paradisiaque14.jpg", "Villa Médicis", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3687) },
                    { 10, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3690), "The Malibu Beach Villa is a luxurious oceanfront retreat located in Malibu, California. It offers stunning views of the Pacific Ocean and direct access to the beach.", "~/js/paradisiaque15.jpg", "Malibu Beach Villa", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3691) },
                    { 11, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3694), "The Aspen Mountain Chalet is nestled in the scenic mountains of Aspen, Colorado. It features a cozy interior, breathtaking views, and convenient access to skiing and outdoor activities.", "~/js/paradisiaque16.jpg", "Aspen Mountain Chalet", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3695) },
                    { 12, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3698), "The Hawaiian Paradise Villa is a tropical oasis located on the island of Maui, Hawaii. It offers a private pool, lush gardens, and easy access to beautiful beaches.", "~/js/paradisiaque17.jpg", "Hawaiian Paradise Villa", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3699) },
                    { 13, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3702), "The Miami Beachfront Villa is a luxurious waterfront property located in Miami, Florida. It features modern design, panoramic ocean views, and a private dock for boating enthusiasts.", "~/js/paradisiaque18.jpg", "Miami Beachfront Villa", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3703) },
                    { 14, "", "Abdou", new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3706), "The Lake Tahoe Retreat is a serene getaway nestled in the breathtaking mountains of Lake Tahoe, California. It offers a tranquil setting, outdoor activities, and access to the stunning lake.", "~/js/paradisiaque19.jpg", "Lake Tahoe Retreat", 4, 200.0, 550, new DateTime(2023, 6, 28, 4, 18, 16, 438, DateTimeKind.Local).AddTicks(3707) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3522), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa3.jpg", "Royal Villa", new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3528), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa1.jpg", "Premium Pool Villa", 300.0, new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3533), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa4.jpg", "Luxury Pool Villa", 400.0, 750, new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3538), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa5.jpg", "Diamond Villa", 550.0, 900, new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3543), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa2.jpg", "Diamond Pool Villa", 600.0, 1100, new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3544) });
        }
    }
}
