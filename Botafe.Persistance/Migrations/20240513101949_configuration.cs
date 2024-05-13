using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 13, 12, 19, 48, 562, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 13, 12, 19, 48, 562, DateTimeKind.Local).AddTicks(8933));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 13, 11, 12, 0, 984, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 13, 11, 12, 0, 985, DateTimeKind.Local).AddTicks(3910));
        }
    }
}
