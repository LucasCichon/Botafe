using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class EventOwnerAddressTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOwners_EventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.AlterColumn<int>(
                name: "EventOwnerAddressId",
                table: "EventOwners",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 16, 29, 17, 967, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 16, 29, 17, 967, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.AddForeignKey(
                name: "FK_EventOwners_EventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners",
                column: "EventOwnerAddressId",
                principalTable: "EventOwnerAddresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOwners_EventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.AlterColumn<int>(
                name: "EventOwnerAddressId",
                table: "EventOwners",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
