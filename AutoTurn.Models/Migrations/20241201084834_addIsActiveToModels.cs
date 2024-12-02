using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class addIsActiveToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Turns",
                newName: "IsActive");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Plans",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Plans");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Turns",
                newName: "IsDeleted");
        }
    }
}
