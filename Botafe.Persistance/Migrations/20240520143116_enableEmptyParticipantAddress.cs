using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class enableEmptyParticipantAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_ParticipantsAddress_ParticipantAddressId",
                table: "Participants");

            migrationBuilder.AlterColumn<int>(
                name: "ParticipantAddressId",
                table: "Participants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 16, 31, 16, 218, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 16, 31, 16, 218, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_ParticipantsAddress_ParticipantAddressId",
                table: "Participants",
                column: "ParticipantAddressId",
                principalTable: "ParticipantsAddress",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_ParticipantsAddress_ParticipantAddressId",
                table: "Participants");

            migrationBuilder.AlterColumn<int>(
                name: "ParticipantAddressId",
                table: "Participants",
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
                value: new DateTime(2024, 5, 20, 16, 29, 17, 967, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 16, 29, 17, 967, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_ParticipantsAddress_ParticipantAddressId",
                table: "Participants",
                column: "ParticipantAddressId",
                principalTable: "ParticipantsAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
