using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeTripTravelCompanion.Data.Migrations
{
    public partial class BucketList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BucketLists",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_BucketLists_UserId",
                table: "BucketLists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BucketLists_AspNetUsers_UserId",
                table: "BucketLists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BucketLists_AspNetUsers_UserId",
                table: "BucketLists");

            migrationBuilder.DropIndex(
                name: "IX_BucketLists_UserId",
                table: "BucketLists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BucketLists");
        }
    }
}
