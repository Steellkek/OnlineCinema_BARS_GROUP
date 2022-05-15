using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCinema_BARS_GROUP.Migrations
{
    public partial class newIntial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteLists_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteListMovie",
                columns: table => new
                {
                    FavoriteListsId = table.Column<Guid>(type: "uuid", nullable: false),
                    MoviesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteListMovie", x => new { x.FavoriteListsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_FavoriteListMovie_FavoriteLists_FavoriteListsId",
                        column: x => x.FavoriteListsId,
                        principalTable: "FavoriteLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteListMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteListMovie_MoviesId",
                table: "FavoriteListMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteLists_AuthorId",
                table: "FavoriteLists",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteListMovie");

            migrationBuilder.DropTable(
                name: "FavoriteLists");
        }
    }
}
