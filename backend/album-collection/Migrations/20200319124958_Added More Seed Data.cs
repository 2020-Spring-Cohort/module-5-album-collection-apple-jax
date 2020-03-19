using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Age", "HomeTown", "Image", "Name", "RecordLabel" },
                values: new object[,]
                {
                    { 2, 25, "chicago", "img", "Artist A", "columbia records" },
                    { 3, 25, "cleveland", "img", "Artist B", "columbia records" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Duration", "Link", "Title" },
                values: new object[,]
                {
                    { 2, 1, "3:12", "song.com", "Confessions Part 2" },
                    { 3, 1, "3:12", "song.com", "Confessions Part 3" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "RecordLabel", "Title" },
                values: new object[] { 2, 2, "img", "columbia records", "Artist A Album" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "RecordLabel", "Title" },
                values: new object[] { 3, 3, "img", "columbia records", "Artist B Album" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Duration", "Link", "Title" },
                values: new object[,]
                {
                    { 4, 2, "3:12", "song.com", "Song A-1" },
                    { 5, 2, "3:12", "song.com", "Song A-2" },
                    { 6, 2, "3:12", "song.com", "Song A-3" },
                    { 7, 3, "3:12", "song.com", "Song B-1" },
                    { 8, 3, "3:12", "song.com", "Song B-2" },
                    { 9, 3, "3:12", "song.com", "Song B-3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
