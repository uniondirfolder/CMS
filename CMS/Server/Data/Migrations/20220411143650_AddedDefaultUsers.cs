using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59f8bfc3-7462-4014-8fa3-7a9a21618375",
                column: "ConcurrencyStamp",
                value: "69997a0b-9cd1-497a-98a5-b3f84d246380");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f65e480f-49a4-4100-90f5-34de00714496",
                column: "ConcurrencyStamp",
                value: "ea8190e3-7d3c-4d23-a132-b650ba1c5201");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "59f8bfc3-7462-4014-8fa3-8a9a21618379", 0, "62cb8450-21de-4084-89e1-e58ce9799116", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEHY6OkqqighYn4JwFkgugl1cqb+nnjtKK5OBr9TCY54GOa+UC5sljatV/wOvFdFHhw==", null, false, "462dbfe5-b604-41fc-a37c-de1598187d8a", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3494), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3532), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3695), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3701), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3764), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3769), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3776), new DateTime(2022, 4, 11, 17, 36, 50, 220, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f65e480f-49a4-4100-90f5-34de00714496", "59f8bfc3-7462-4014-8fa3-8a9a21618379" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f65e480f-49a4-4100-90f5-34de00714496", "59f8bfc3-7462-4014-8fa3-8a9a21618379" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f8bfc3-7462-4014-8fa3-8a9a21618379");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59f8bfc3-7462-4014-8fa3-7a9a21618375",
                column: "ConcurrencyStamp",
                value: "73c6590e-7ab4-4e9f-9ddf-e21a6753e655");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f65e480f-49a4-4100-90f5-34de00714496",
                column: "ConcurrencyStamp",
                value: "48fb2ec8-c02e-420e-9fc5-b4442d66849b");

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
    }
}
