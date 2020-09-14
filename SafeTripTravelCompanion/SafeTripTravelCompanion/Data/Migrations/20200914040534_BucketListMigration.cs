using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeTripTravelCompanion.Data.Migrations
{
    public partial class BucketListMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BucketLists",
                columns: table => new
                {
                    BucketListId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BucketLists", x => x.BucketListId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BucketLists");
        }
    }
}
