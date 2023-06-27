using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestApiProject1.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

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
    }
}
