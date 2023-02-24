using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8888.Migrations
{
    /// <inheritdoc />
    public partial class namechangetodaydate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Today",
                table: "Sessions",
                newName: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Sessions",
                newName: "Today");
        }
    }
}
