using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class SignUpTest_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "encryptedPassword",
                table: "User",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "encryptedPassword",
                table: "User");
        }
    }
}
