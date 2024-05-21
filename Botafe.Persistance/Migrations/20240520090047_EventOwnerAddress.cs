using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class EventOwnerAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventOwnerAddressId",
                table: "EventOwners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EventOwnerAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Voivodeship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOwnerAddress", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EventOwnerAddress",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "Address_City", "Address_Country", "Address_Postcode", "Address_StreetName", "Address_StreetNumber", "Address_Voivodeship" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 0, "Opole", "Polska", "45-403", "Ozimska", "34/5a", "Opolskie" });

            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "EventOwnerAddressId" },
                values: new object[] { new DateTime(2024, 5, 20, 11, 0, 47, 324, DateTimeKind.Local).AddTicks(6979), 1 });

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 20, 11, 0, 47, 324, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.CreateIndex(
                name: "IX_EventOwners_EventOwnerAddressId",
                table: "EventOwners",
                column: "EventOwnerAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventOwners_EventOwnerAddress_EventOwnerAddressId",
                table: "EventOwners",
                column: "EventOwnerAddressId",
                principalTable: "EventOwnerAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOwners_EventOwnerAddress_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.DropTable(
                name: "EventOwnerAddress");

            migrationBuilder.DropIndex(
                name: "IX_EventOwners_EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.DropColumn(
                name: "EventOwnerAddressId",
                table: "EventOwners");

            migrationBuilder.UpdateData(
                table: "EventOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 13, 12, 20, 42, 599, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 13, 12, 20, 42, 599, DateTimeKind.Local).AddTicks(8977));
        }
    }
}
