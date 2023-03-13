using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8888.Migrations
{
    /// <inheritdoc />
    public partial class makingsomethngoptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Sessions_SessionId",
                table: "Notes");

            migrationBuilder.AlterColumn<long>(
                name: "SessionId",
                table: "Notes",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Sessions_SessionId",
                table: "Notes",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Sessions_SessionId",
                table: "Notes");

            migrationBuilder.AlterColumn<long>(
                name: "SessionId",
                table: "Notes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Sessions_SessionId",
                table: "Notes",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
