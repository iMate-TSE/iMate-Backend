using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class AutoIncrementIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PadRanges",
                columns: new[] { "moodID", "mood", "valueArousal", "valueDominance", "valuePleasure" },
                values: new object[] { 1, "Excited", 1f, 1f, 1f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PadRanges",
                keyColumn: "moodID",
                keyValue: 1);
        }
    }
}
