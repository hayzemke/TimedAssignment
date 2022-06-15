using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMedia.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Post_Post",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Post_PostID",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Comments_Comment",
                table: "Reply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reply",
                table: "Reply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.RenameTable(
                name: "Reply",
                newName: "Replies");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameIndex(
                name: "IX_Reply_Comment",
                table: "Replies",
                newName: "IX_Replies_Comment");

            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Replies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Replies",
                table: "Replies",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_Post",
                table: "Comments",
                column: "Post",
                principalTable: "Posts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Posts_PostID",
                table: "Like",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comments_Comment",
                table: "Replies",
                column: "Comment",
                principalTable: "Comments",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_Post",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Posts_PostID",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comments_Comment",
                table: "Replies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Replies",
                table: "Replies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Replies");

            migrationBuilder.RenameTable(
                name: "Replies",
                newName: "Reply");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_Comment",
                table: "Reply",
                newName: "IX_Reply_Comment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reply",
                table: "Reply",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Post_Post",
                table: "Comments",
                column: "Post",
                principalTable: "Post",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Post_PostID",
                table: "Like",
                column: "PostID",
                principalTable: "Post",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Comments_Comment",
                table: "Reply",
                column: "Comment",
                principalTable: "Comments",
                principalColumn: "ID");
        }
    }
}
