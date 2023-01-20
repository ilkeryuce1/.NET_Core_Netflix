using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAceesLayer.Migrations
{
    /// <inheritdoc />
    public partial class movieage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieAgeDanger",
                table: "Tbl_Movies",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieAgeDanger",
                table: "Tbl_Movies");
        }
    }
}
