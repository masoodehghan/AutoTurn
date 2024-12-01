using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class addPlanSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanCapacity",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "PlanStartTime",
                table: "Offices");

            migrationBuilder.CreateTable(
                name: "PlanSetting",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlanCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanSetting", x => new { x.OfficeId, x.Id });
                    table.ForeignKey(
                        name: "FK_PlanSetting_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanSetting");

            migrationBuilder.AddColumn<int>(
                name: "PlanCapacity",
                table: "Offices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlanStartTime",
                table: "Offices",
                type: "datetime2",
                nullable: true);
        }
    }
}
