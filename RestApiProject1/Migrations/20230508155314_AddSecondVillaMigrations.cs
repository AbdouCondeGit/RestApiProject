using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestApiProject1.Migrations
{
    /// <inheritdoc />
    public partial class AddSecondVillaMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
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
                values: new object[] { new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9763), new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 5, 8, 17, 53, 14, 741, DateTimeKind.Local).AddTicks(9788) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
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
                values: new object[] { new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 5, 8, 13, 37, 18, 886, DateTimeKind.Local).AddTicks(3511) });
        }
    }
}
