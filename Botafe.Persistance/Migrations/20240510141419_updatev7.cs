using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botafe.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class updatev7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticipantId",
                table: "ParticipantAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParticipantId",
                table: "ParticipantAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
