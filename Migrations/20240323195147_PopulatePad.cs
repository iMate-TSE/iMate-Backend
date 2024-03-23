using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class PopulatePad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PadRanges",
                columns: new[] { "moodID", "mood", "valueArousal", "valueDominance", "valuePleasure" },
                values: new object[,]
                {
                    { 2, "Happy", 0.5f, 1f, 1f },
                    { 3, "Loved/ Grateful", 0.2f, 0.8f, 0.9f },
                    { 4, "Relaxed", 0.2f, 0.2f, 0.9f },
                    { 5, "Angry", 0.9f, 1f, 0.1f },
                    { 6, "Stressed", 0.9f, 0.7f, 0.2f },
                    { 7, "Anxious", 0.6f, 0.4f, 0.1f },
                    { 8, "Disgust", 0.7f, 0.45f, 0f },
                    { 9, "Sad", 0.1f, 0.1f, 0.1f },
                    { 10, "Bored", 0.1f, 0.3f, 0.2f },
                    { 11, "Sleepy", 0.4f, 0.4f, 0.4f },
                    { 12, "Lonely", 0.3f, 0f, 0.1f },
                    { 13, "Depressed", 0f, 0f, 0f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 13);
        }
    }
}
