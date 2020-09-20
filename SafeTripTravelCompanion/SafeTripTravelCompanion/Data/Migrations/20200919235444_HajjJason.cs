using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeTripTravelCompanion.Data.Migrations
{
    public partial class HajjJason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AmusementPark",
                table: "Questionaire",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Concert",
                table: "Questionaire",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fishing",
                table: "Questionaire",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Hiking",
                table: "Questionaire",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Museum",
                table: "Questionaire",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Shopping",
                table: "Questionaire",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Questionaire",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Questionaire_UserId",
                table: "Questionaire",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questionaire_AspNetUsers_UserId",
                table: "Questionaire",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionaire_AspNetUsers_UserId",
                table: "Questionaire");

            migrationBuilder.DropIndex(
                name: "IX_Questionaire_UserId",
                table: "Questionaire");

            migrationBuilder.DropColumn(
                name: "AmusementPark",
                table: "Questionaire");

            migrationBuilder.DropColumn(
                name: "Concert",
                table: "Questionaire");

            migrationBuilder.DropColumn(
                name: "Fishing",
                table: "Questionaire");

            migrationBuilder.DropColumn(
                name: "Hiking",
                table: "Questionaire");

            migrationBuilder.DropColumn(
                name: "Museum",
                table: "Questionaire");

            migrationBuilder.DropColumn(
                name: "Shopping",
                table: "Questionaire");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Questionaire");
        }
    }
}
