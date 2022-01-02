using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedSeedCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4596), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4612), "Black", "System" },
                    { 2, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4615), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4616), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4881), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4883), "Nissan", "System" },
                    { 2, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4885), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4885), "Toyota", "System" },
                    { 3, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4887), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4887), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4997), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(4999), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(5000), "3 Series", "System" },
                    { 3, "System", new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(5001), new DateTime(2022, 1, 1, 13, 43, 30, 831, DateTimeKind.Local).AddTicks(5002), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
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
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

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
        }
    }
}
