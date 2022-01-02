using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedUserRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9e6679-7425-40de-944b-e07fc1f90ae7",
                column: "ConcurrencyStamp",
                value: "c97e3bdf-657d-432f-a37d-cc23ead84728");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c9e6000-7425-40de-933b-e07ff1f90ae8",
                column: "ConcurrencyStamp",
                value: "f20838c6-f69e-4eda-a3f7-76189f8d5225");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5c9e7d05-7425-45de-933b-e07effe90ae5", 0, "d50ce327-6698-48f7-9fa3-8325b7d18fbf", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDnJTJUBxfgqUhRpy5KOW0EoVE0P5EbcyhAcmzIYp7KyT1SznwTNoPAFF5eHunGCxQ==", null, false, "7b7bda4c-c8a1-40a9-b418-af2f7edb362b", false, "user@localhost.com" },
                    { "9c9e7005-7425-41de-933b-e07ff1e90ae9", 0, "02e60597-e631-4989-95a2-e3b568e429bb", "Administrator@localhost.com", false, "System", "Admin", false, null, "ADMINISTRATOR@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEL7Q/oJd6rvNEn4wAJvjxVCq5D8+bH9VU4Z0xOqY0CcqK0jwuunK7D4JgRYxlEVwUw==", null, false, "8704fef6-e51a-4902-8759-b5a6dbd535e1", false, "Admin@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(6769), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(6796), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7243), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7250), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7253), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7485), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7488), new DateTime(2022, 1, 1, 14, 40, 57, 200, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7c9e6679-7425-40de-944b-e07fc1f90ae7", "5c9e7d05-7425-45de-933b-e07effe90ae5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8c9e6000-7425-40de-933b-e07ff1f90ae8", "9c9e7005-7425-41de-933b-e07ff1e90ae9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c9e6679-7425-40de-944b-e07fc1f90ae7", "5c9e7d05-7425-45de-933b-e07effe90ae5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c9e6000-7425-40de-933b-e07ff1f90ae8", "9c9e7005-7425-41de-933b-e07ff1e90ae9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9e7d05-7425-45de-933b-e07effe90ae5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c9e7005-7425-41de-933b-e07ff1e90ae9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9e6679-7425-40de-944b-e07fc1f90ae7",
                column: "ConcurrencyStamp",
                value: "d59f9fc4-78b6-440d-a8d1-4c3671838817");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c9e6000-7425-40de-933b-e07ff1f90ae8",
                column: "ConcurrencyStamp",
                value: "349759d5-b388-4bdb-9cdd-084e3524d600");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7399), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7972), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7982), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7985), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(8255), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(8261), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(8264), new DateTime(2022, 1, 1, 13, 59, 48, 150, DateTimeKind.Local).AddTicks(8265) });
        }
    }
}
