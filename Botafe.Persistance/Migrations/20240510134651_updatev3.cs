using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class updatev3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Address_ParticipantAddress_AddressId",
                table: "Participants");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Participants_ParticipantAddress_AddressId",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_AddressId",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_Created",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_CreatedBy",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_Id",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_Inactivated",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_InactivatedBy",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_Modified",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_ModifiedBy",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantAddress_StatusId",
                table: "Participants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParticipantAddress_AddressId",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ParticipantAddress_Created",
                table: "Participants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ParticipantAddress_CreatedBy",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ParticipantAddress_Id",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ParticipantAddress_Inactivated",
                table: "Participants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParticipantAddress_InactivatedBy",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ParticipantAddress_Modified",
                table: "Participants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParticipantAddress_ModifiedBy",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ParticipantAddress_StatusId",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voivodeship = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ParticipantAddress_AddressId",
                table: "Participants",
                column: "ParticipantAddress_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Address_ParticipantAddress_AddressId",
                table: "Participants",
                column: "ParticipantAddress_AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
