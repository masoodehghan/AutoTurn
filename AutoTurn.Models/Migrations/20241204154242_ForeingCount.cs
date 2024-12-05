using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class ForeingCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanEndTime",
                table: "Offices");

            migrationBuilder.AddColumn<int>(
                name: "PlanForeignCount",
                table: "PlanSetting",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanForeignCount",
                table: "PlanSetting");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlanEndTime",
                table: "Offices",
                type: "datetime2",
                nullable: true);
        }
    }
}
