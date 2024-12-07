using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class addIsTransfered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TranferedOfficeId",
                table: "Turns");

            migrationBuilder.AddColumn<bool>(
                name: "IsTransfered",
                table: "Turns",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTransfered",
                table: "Turns");

            migrationBuilder.AddColumn<int>(
                name: "TranferedOfficeId",
                table: "Turns",
                type: "int",
                nullable: true);
        }
    }
}
