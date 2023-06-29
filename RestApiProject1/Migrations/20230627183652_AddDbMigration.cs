using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestApiProject1.Migrations
{
    /// <inheritdoc />
    public partial class AddDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3522), new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3528), new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3543), new DateTime(2023, 6, 27, 20, 36, 51, 949, DateTimeKind.Local).AddTicks(3544) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 6, 25, 12, 30, 11, 560, DateTimeKind.Local).AddTicks(8888) });
        }
    }
}
