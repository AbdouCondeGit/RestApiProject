using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestApiProject1.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaValueMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaValues",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaID = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaValues", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_VillaValues_Villas_VillaID",
                        column: x => x.VillaID,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_VillaValues_VillaID",
                table: "VillaValues",
                column: "VillaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaValues");

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
    }
}
