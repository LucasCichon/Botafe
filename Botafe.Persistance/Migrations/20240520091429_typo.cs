using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class typo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOwners_eventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eventOwnerAddresses",
                table: "eventOwnerAddresses");

            migrationBuilder.RenameTable(
                name: "eventOwnerAddresses",
                newName: "EventOwnerAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventOwnerAddresses",
                table: "EventOwnerAddresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 11, 14, 28, 669, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 11, 14, 28, 669, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.AddForeignKey(
                name: "FK_EventOwners_EventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners",
                column: "EventOwnerAddressId",
                principalTable: "EventOwnerAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOwners_EventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventOwnerAddresses",
                table: "EventOwnerAddresses");

            migrationBuilder.RenameTable(
                name: "EventOwnerAddresses",
                newName: "eventOwnerAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_eventOwnerAddresses",
                table: "eventOwnerAddresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 11, 10, 16, 938, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 11, 10, 16, 938, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.AddForeignKey(
                name: "FK_EventOwners_eventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners",
                column: "EventOwnerAddressId",
                principalTable: "eventOwnerAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
