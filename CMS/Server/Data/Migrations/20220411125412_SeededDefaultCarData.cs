using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8531), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8562), "Black", "System" },
                    { 2, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8567), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8723), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8726), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8730), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8845), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8848), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8851), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8853), "Vitz", "System" },
                    { 3, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8855), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8856), "3 Series", "System" },
                    { 4, "System", new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8858), new DateTime(2022, 4, 11, 15, 54, 12, 203, DateTimeKind.Local).AddTicks(8860), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
