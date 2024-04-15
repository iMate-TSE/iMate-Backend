using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class PopulateQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormQuestions",
                columns: new[] { "formQuestionID", "Category", "Question" },
                values: new object[,]
                {
                    { 32, "Lonely/Sad/Depressed", "I have felt terrible alone and isolated" },
                    { 33, "Lonely/Sad/Depressed", "I have thought of hurting myself" },
                    { 34, "Lonely/Sad/Depressed", "Talking to people has felt too much for me" },
                    { 35, "Lonely/Sad/Depressed", "I have felt like crying" },
                    { 36, "Lonely/Sad/Depressed", "I have felt overwhelmed by my problems" },
                    { 37, "Lonely/Sad/Depressed", "I have thought it would be better if I were dead" },
                    { 38, "Lonely/Sad/Depressed", "I have thought I have no friends" },
                    { 39, "Lonely/Sad/Depressed", "I have felt unhappy" },
                    { 40, "Lonely/Sad/Depressed", "I have been irritable when with other people" },
                    { 41, "Lonely/Sad/Depressed", "I have felt humiliated or shamed by other people" },
                    { 42, "Anxious/Stressed", "I have felt tense, nervous, or anxious" },
                    { 43, "Anxious/Stressed", "I have been troubled by aches, pains, or other physical problems" },
                    { 44, "Anxious/Stressed", "Tension and anxiety have prevented me from doing important things" },
                    { 45, "Anxious/Stressed", "I have been disturbed by unwanted thoughts and feelings" },
                    { 46, "Anxious/Stressed", "I have felt panic or terror" },
                    { 47, "Anxious/Stressed", "I have had difficulty getting to sleep or staying asleep" },
                    { 48, "Anxious/Stressed", "Unwanted images or memories have been distressing me" },
                    { 49, "Anxious/Stressed", "I have felt criticised by other people" },
                    { 50, "Anxious/Stressed", "I have thought I am to blame for my problems and difficulties" },
                    { 51, "Loved/Grateful", "I have felt I have someone to turn to for support when needed" },
                    { 52, "Loved/Grateful", "I have felt warmth or affection for someone" },
                    { 53, "Happy/Excited", "I have been happy with the things I have done" },
                    { 54, "Happy/Excited", "I have felt optimistic about my future" },
                    { 55, "Happy/Excited", "I have achieved the things I wanted to do" },
                    { 56, "Angry/Disgusted", "I have been physically violent towards others" },
                    { 57, "Angry/Disgusted", "I have threatened or intimidated another person" },
                    { 58, "Angry/Disgusted", "I have hurt myself physically or taken dangerous risks with my health" },
                    { 59, "Relaxed/Bored/Sleepy", "I have felt ok about myself" },
                    { 60, "Relaxed/Bored/Sleepy", "I have felt totally lacking in energy and enthusiasm" },
                    { 61, "Relaxed/Bored/Sleepy", "My problems have been impossible to put to one side" },
                    { 62, "Relaxed/Bored/Sleepy", "I have felt able to cope when things go wrong" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "FormQuestions",
                keyColumn: "formQuestionID",
                keyValue: 62);
        }
    }
}
