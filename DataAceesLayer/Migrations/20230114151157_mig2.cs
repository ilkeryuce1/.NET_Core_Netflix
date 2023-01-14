using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAceesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_MovieKinds_Tbl_Movies_MovieId",
                table: "Tbl_MovieKinds");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_MovieKinds_MovieId",
                table: "Tbl_MovieKinds");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Tbl_MovieKinds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Tbl_MovieKinds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_MovieKinds_MovieId",
                table: "Tbl_MovieKinds",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_MovieKinds_Tbl_Movies_MovieId",
                table: "Tbl_MovieKinds",
                column: "MovieId",
                principalTable: "Tbl_Movies",
                principalColumn: "MovieId");
        }
    }
}
