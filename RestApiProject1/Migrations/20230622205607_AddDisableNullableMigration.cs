using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestApiProject1.Migrations
{
    /// <inheritdoc />
    public partial class AddDisableNullableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaValues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 6, 22, 22, 56, 7, 29, DateTimeKind.Local).AddTicks(8921) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(315), new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(325), new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 6, 17, 17, 36, 2, 846, DateTimeKind.Local).AddTicks(330) });
        }
    }
}
