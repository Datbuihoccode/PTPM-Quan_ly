using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameClass",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Studentcode",
                table: "Person",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameClass",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Studentcode",
                table: "Person");
        }
    }
}
