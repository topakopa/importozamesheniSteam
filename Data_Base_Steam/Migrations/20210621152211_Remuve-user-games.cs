using Microsoft.EntityFrameworkCore.Migrations;

namespace Steam.DataBase.Migrations
{
    public partial class Remuveusergames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserGames_UserId",
                table: "UserGames",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGames_Users_UserId",
                table: "UserGames",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserGames_Users_UserId",
                table: "UserGames");

            migrationBuilder.DropIndex(
                name: "IX_UserGames_UserId",
                table: "UserGames");
        }
    }
}
