using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addAddressesToContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOwners_EventOwnerAddress_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_ParticipantAddress_ParticipantAddressId",
                table: "Participants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParticipantAddress",
                table: "ParticipantAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventOwnerAddress",
                table: "EventOwnerAddress");

            migrationBuilder.RenameTable(
                name: "ParticipantAddress",
                newName: "ParticipantsAddress");

            migrationBuilder.RenameTable(
                name: "EventOwnerAddress",
                newName: "eventOwnerAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParticipantsAddress",
                table: "ParticipantsAddress",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_ParticipantsAddress_ParticipantAddressId",
                table: "Participants",
                column: "ParticipantAddressId",
                principalTable: "ParticipantsAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOwners_eventOwnerAddresses_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_ParticipantsAddress_ParticipantAddressId",
                table: "Participants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParticipantsAddress",
                table: "ParticipantsAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eventOwnerAddresses",
                table: "eventOwnerAddresses");

            migrationBuilder.RenameTable(
                name: "ParticipantsAddress",
                newName: "ParticipantAddress");

            migrationBuilder.RenameTable(
                name: "eventOwnerAddresses",
                newName: "EventOwnerAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParticipantAddress",
                table: "ParticipantAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventOwnerAddress",
                table: "EventOwnerAddress",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 11, 0, 47, 324, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 11, 0, 47, 324, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.AddForeignKey(
                name: "FK_EventOwners_EventOwnerAddress_EventOwnerAddressId",
                table: "EventOwners",
                column: "EventOwnerAddressId",
                principalTable: "EventOwnerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_ParticipantAddress_ParticipantAddressId",
                table: "Participants",
                column: "ParticipantAddressId",
                principalTable: "ParticipantAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
