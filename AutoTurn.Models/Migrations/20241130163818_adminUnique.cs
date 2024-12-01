using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class adminUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Offices_AdminId",
                table: "Offices");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_AdminId",
                table: "Offices",
                column: "AdminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Offices_AdminId",
                table: "Offices");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_AdminId",
                table: "Offices",
                column: "AdminId",
                unique: true,
                filter: "[AdminId] IS NOT NULL");
        }
    }
}
