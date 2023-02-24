using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8888.Migrations
{
    /// <inheritdoc />
    public partial class allfkdone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TagId",
                table: "Sessions",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_SessionId",
                table: "Notes",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Sessions_SessionId",
                table: "Notes",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Tags_TagId",
                table: "Sessions",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Sessions_SessionId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Tags_TagId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_TagId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Notes_SessionId",
                table: "Notes");
        }
    }
}
