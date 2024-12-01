using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTurn.Models.Migrations
{
    /// <inheritdoc />
    public partial class AddOfficeIdToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offices_AspNetUsers_AdminId",
                table: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Offices_AdminId",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Offices");

            migrationBuilder.AlterColumn<int>(
                name: "Address_ForeignId",
                table: "Offices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OfficeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OfficeId",
                table: "AspNetUsers",
                column: "OfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Offices_OfficeId",
                table: "AspNetUsers",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Offices_OfficeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_OfficeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Address_ForeignId",
                table: "Offices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminId",
                table: "Offices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offices_AdminId",
                table: "Offices",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offices_AspNetUsers_AdminId",
                table: "Offices",
                column: "AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
