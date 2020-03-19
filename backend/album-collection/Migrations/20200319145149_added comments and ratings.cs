using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class addedcommentsandratings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Albums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Albums",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comments", "Rating" },
                values: new object[] { "Here is a great comment", 5 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comments", "Rating" },
                values: new object[] { "Here is a great comment", 5 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comments", "Rating" },
                values: new object[] { "Here is a great comment", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Albums");
        }
    }
}
