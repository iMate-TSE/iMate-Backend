using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMoodEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoodEntry_PadRanges_moodID",
                table: "MoodEntry");

            migrationBuilder.DropIndex(
                name: "IX_MoodEntry_moodID",
                table: "MoodEntry");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MoodEntry_moodID",
                table: "MoodEntry",
                column: "moodID");

            migrationBuilder.AddForeignKey(
                name: "FK_MoodEntry_PadRanges_moodID",
                table: "MoodEntry",
                column: "moodID",
                principalTable: "PadRanges",
                principalColumn: "moodID");
        }
    }
}
