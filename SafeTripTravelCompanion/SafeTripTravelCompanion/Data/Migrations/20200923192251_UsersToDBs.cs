using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeTripTravelCompanion.Data.Migrations
{
    public partial class UsersToDBs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BucketLists_AspNetUsers_UserId",
                table: "BucketLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionaire_AspNetUsers_UserId",
                table: "Questionaire");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Questionaire",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BucketLists",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_BucketLists_AspNetUsers_UserId",
                table: "BucketLists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionaire_AspNetUsers_UserId",
                table: "Questionaire",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BucketLists_AspNetUsers_UserId",
                table: "BucketLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionaire_AspNetUsers_UserId",
                table: "Questionaire");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Questionaire",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BucketLists",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BucketLists_AspNetUsers_UserId",
                table: "BucketLists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionaire_AspNetUsers_UserId",
                table: "Questionaire",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
