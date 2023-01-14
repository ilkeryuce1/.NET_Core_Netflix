using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAceesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_AccountKinds",
                columns: table => new
                {
                    AccounKindtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccounName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_AccountKinds", x => x.AccounKindtId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_MovieKinds",
                columns: table => new
                {
                    MovieKindId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieKindName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_MovieKinds", x => x.MovieKindId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Packets",
                columns: table => new
                {
                    PacketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountOdUserCount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Packets", x => x.PacketId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Episodes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieKindId = table.Column<int>(type: "int", nullable: false),
                    CoverPhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Tbl_Movies_Tbl_MovieKinds_MovieKindId",
                        column: x => x.MovieKindId,
                        principalTable: "Tbl_MovieKinds",
                        principalColumn: "MovieKindId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    PacketId = table.Column<int>(type: "int", nullable: false),
                    AccountKindId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Tbl_Accounts_Tbl_AccountKinds_AccountKindId",
                        column: x => x.AccountKindId,
                        principalTable: "Tbl_AccountKinds",
                        principalColumn: "AccounKindtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Accounts_Tbl_Packets_PacketId",
                        column: x => x.PacketId,
                        principalTable: "Tbl_Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_CommentRateds",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rated = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CommentRateds", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Tbl_CommentRateds_Tbl_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Tbl_Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_CommentRateds_Tbl_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Tbl_Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Accounts_AccountKindId",
                table: "Tbl_Accounts",
                column: "AccountKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Accounts_PacketId",
                table: "Tbl_Accounts",
                column: "PacketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CommentRateds_AccountId",
                table: "Tbl_CommentRateds",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CommentRateds_MovieId",
                table: "Tbl_CommentRateds",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Movies_MovieKindId",
                table: "Tbl_Movies",
                column: "MovieKindId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_CommentRateds");

            migrationBuilder.DropTable(
                name: "Tbl_Accounts");

            migrationBuilder.DropTable(
                name: "Tbl_Movies");

            migrationBuilder.DropTable(
                name: "Tbl_AccountKinds");

            migrationBuilder.DropTable(
                name: "Tbl_Packets");

            migrationBuilder.DropTable(
                name: "Tbl_MovieKinds");
        }
    }
}
