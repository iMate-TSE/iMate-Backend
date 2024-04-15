using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingQuestionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isHappy",
                table: "FormQuestions");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "FormQuestions",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "FormQuestions");

            migrationBuilder.AddColumn<bool>(
                name: "isHappy",
                table: "FormQuestions",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
