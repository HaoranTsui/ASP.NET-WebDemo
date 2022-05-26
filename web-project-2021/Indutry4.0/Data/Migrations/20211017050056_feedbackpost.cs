using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Indutry4._0.Data.Migrations
{
    public partial class feedbackpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageContent",
                table: "DiscussionForum");

            migrationBuilder.DropColumn(
                name: "TopicTitle",
                table: "DiscussionForum");

            migrationBuilder.RenameColumn(
                name: "PostDate",
                table: "DiscussionForum",
                newName: "Date");

            migrationBuilder.CreateTable(
                name: "FeedbackPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarRating = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agree = table.Column<int>(type: "int", nullable: false),
                    Disagree = table.Column<int>(type: "int", nullable: false),
                    CompanyOrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    canIncreaseAgree = table.Column<bool>(type: "bit", nullable: false),
                    canIncreaseDisagree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackPost", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackPost");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "DiscussionForum",
                newName: "PostDate");

            migrationBuilder.AddColumn<string>(
                name: "MessageContent",
                table: "DiscussionForum",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TopicTitle",
                table: "DiscussionForum",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
