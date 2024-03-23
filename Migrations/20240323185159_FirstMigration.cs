using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormQuestions",
                columns: table => new
                {
                    formQuestionID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question = table.Column<string>(type: "text", nullable: true),
                    multipleChoice = table.Column<string[]>(type: "text[]", nullable: false),
                    isHappy = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormQuestions", x => x.formQuestionID);
                });

            migrationBuilder.CreateTable(
                name: "PadRanges",
                columns: table => new
                {
                    moodID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mood = table.Column<string>(type: "text", nullable: false),
                    valuePleasure = table.Column<float>(type: "real", nullable: false),
                    valueArousal = table.Column<float>(type: "real", nullable: false),
                    valueDominance = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PadRanges", x => x.moodID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    soundEffects = table.Column<bool>(type: "boolean", nullable: false),
                    reducedMotion = table.Column<bool>(type: "boolean", nullable: false),
                    motivationalMessages = table.Column<bool>(type: "boolean", nullable: false),
                    practiceReminder = table.Column<bool>(type: "boolean", nullable: false),
                    smartScheduling = table.Column<bool>(type: "boolean", nullable: false),
                    reminderTime = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SlidersQuestions",
                columns: table => new
                {
                    silderQuestionID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question = table.Column<string>(type: "text", nullable: true),
                    sliderOptionOne = table.Column<string>(type: "text", nullable: true),
                    sliderOptionTwo = table.Column<string>(type: "text", nullable: true),
                    isHappy = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlidersQuestions", x => x.silderQuestionID);
                });

            migrationBuilder.CreateTable(
                name: "MoodEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userID = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    moodID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoodEntry_PadRanges_moodID",
                        column: x => x.moodID,
                        principalTable: "PadRanges",
                        principalColumn: "moodID");
                });

            migrationBuilder.CreateTable(
                name: "TarotCards",
                columns: table => new
                {
                    cardID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cardCreditsValue = table.Column<int>(type: "integer", nullable: false),
                    targetMoodId = table.Column<int>(type: "integer", nullable: false),
                    moodID = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarotCards", x => x.cardID);
                    table.ForeignKey(
                        name: "FK_TarotCards_PadRanges_moodID",
                        column: x => x.moodID,
                        principalTable: "PadRanges",
                        principalColumn: "moodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TarotCards_PadRanges_targetMoodId",
                        column: x => x.targetMoodId,
                        principalTable: "PadRanges",
                        principalColumn: "moodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    avatarPath = table.Column<string>(type: "text", nullable: true),
                    age = table.Column<int>(type: "integer", nullable: false),
                    gender = table.Column<string>(type: "text", nullable: true),
                    credits = table.Column<int>(type: "integer", nullable: false),
                    streak = table.Column<int>(type: "integer", nullable: false),
                    settingsID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userID);
                    table.ForeignKey(
                        name: "FK_User_Settings_settingsID",
                        column: x => x.settingsID,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoodEntry_moodID",
                table: "MoodEntry",
                column: "moodID");

            migrationBuilder.CreateIndex(
                name: "IX_TarotCards_moodID",
                table: "TarotCards",
                column: "moodID");

            migrationBuilder.CreateIndex(
                name: "IX_TarotCards_targetMoodId",
                table: "TarotCards",
                column: "targetMoodId");

            migrationBuilder.CreateIndex(
                name: "IX_User_settingsID",
                table: "User",
                column: "settingsID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormQuestions");

            migrationBuilder.DropTable(
                name: "MoodEntry");

            migrationBuilder.DropTable(
                name: "SlidersQuestions");

            migrationBuilder.DropTable(
                name: "TarotCards");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PadRanges");

            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
