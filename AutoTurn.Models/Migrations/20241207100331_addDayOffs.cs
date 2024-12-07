using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class addDayOffs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DaysOff",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysOff",
                table: "Offices");
        }
    }
}
