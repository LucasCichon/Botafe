using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class updatev5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParticipantAddress_Address_AddressId",
                table: "ParticipantAddress");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_ParticipantAddress_AddressId",
                table: "ParticipantAddress");

            migrationBuilder.AddColumn<string>(
                name: "Address_City",
                table: "ParticipantAddress",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_Country",
                table: "ParticipantAddress",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Address_Id",
                table: "ParticipantAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address_Postcode",
                table: "ParticipantAddress",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_StreetName",
                table: "ParticipantAddress",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_StreetNumber",
                table: "ParticipantAddress",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_Voivodeship",
                table: "ParticipantAddress",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_City",
                table: "ParticipantAddress");

            migrationBuilder.DropColumn(
                name: "Address_Country",
                table: "ParticipantAddress");

            migrationBuilder.DropColumn(
                name: "Address_Id",
                table: "ParticipantAddress");

            migrationBuilder.DropColumn(
                name: "Address_Postcode",
                table: "ParticipantAddress");

            migrationBuilder.DropColumn(
                name: "Address_StreetName",
                table: "ParticipantAddress");

            migrationBuilder.DropColumn(
                name: "Address_StreetNumber",
                table: "ParticipantAddress");

            migrationBuilder.DropColumn(
                name: "Address_Voivodeship",
                table: "ParticipantAddress");

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
                name: "IX_ParticipantAddress_AddressId",
                table: "ParticipantAddress",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParticipantAddress_Address_AddressId",
                table: "ParticipantAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
