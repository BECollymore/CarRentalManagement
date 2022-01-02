using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedSeedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c9e6679-7425-40de-944b-e07fc1f90ae7", "d59f9fc4-78b6-440d-a8d1-4c3671838817", "User", "USER" },
                    { "8c9e6000-7425-40de-933b-e07ff1f90ae8", "349759d5-b388-4bdb-9cdd-084e3524d600", "Administrator", "ADMINISTRATOR" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9e6679-7425-40de-944b-e07fc1f90ae7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c9e6000-7425-40de-933b-e07ff1f90ae8");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4596), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4615), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4881), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4885), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4887), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4999), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(5001), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(5002) });
        }
    }
}
