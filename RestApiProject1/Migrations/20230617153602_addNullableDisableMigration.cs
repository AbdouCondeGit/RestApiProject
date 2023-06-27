using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestApiProject1.Migrations
{
    /// <inheritdoc />
    public partial class addNullableDisableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2606), new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 5, 24, 22, 39, 44, 915, DateTimeKind.Local).AddTicks(2616) });
        }
    }
}
