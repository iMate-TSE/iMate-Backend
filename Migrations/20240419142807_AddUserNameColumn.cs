using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fullName",
                table: "User",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "MoodEntry",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fullName",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "MoodEntry",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
