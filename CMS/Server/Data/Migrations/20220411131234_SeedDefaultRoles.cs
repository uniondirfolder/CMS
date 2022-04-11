using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59f8bfc3-7462-4014-8fa3-7a9a21618375", "73c6590e-7ab4-4e9f-9ddf-e21a6753e655", "User", "USER" },
                    { "f65e480f-49a4-4100-90f5-34de00714496", "48fb2ec8-c02e-420e-9fc5-b4442d66849b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2248), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2286), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2455), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2513), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2517), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2521), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2524), new DateTime(2022, 4, 11, 16, 12, 34, 108, DateTimeKind.Local).AddTicks(2526) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59f8bfc3-7462-4014-8fa3-7a9a21618375");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f65e480f-49a4-4100-90f5-34de00714496");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8531), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8723), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8845), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8851), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8855), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8858), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8860) });
        }
    }
}
