using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B2C2AdvChallenge.Migrations
{
    public partial class AddCategoryToDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChallengeTime",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChallengeTime",
                table: "Categories");
        }
    }
}
