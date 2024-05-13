using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voivodeship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventOwnerName_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventOwnerName_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantName_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantName_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantAddress_Id = table.Column<int>(type: "int", nullable: false),
                    ParticipantAddress_AddressId = table.Column<int>(type: "int", nullable: false),
                    ParticipantAddress_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantAddress_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipantAddress_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantAddress_Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParticipantAddress_StatusId = table.Column<int>(type: "int", nullable: false),
                    ParticipantAddress_InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantAddress_Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_Address_ParticipantAddress_AddressId",
                        column: x => x.ParticipantAddress_AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PlacesAvailable = table.Column<int>(type: "int", nullable: false),
                    EventOwnerId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventOwners_EventOwnerId",
                        column: x => x.EventOwnerId,
                        principalTable: "EventOwners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_EventId",
                table: "Enrollments",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ParticipantId",
                table: "Enrollments",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventOwnerId",
                table: "Events",
                column: "EventOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ParticipantAddress_AddressId",
                table: "Participants",
                column: "ParticipantAddress_AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "EventOwners");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
