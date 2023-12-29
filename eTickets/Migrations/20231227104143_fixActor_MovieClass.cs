using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class fixActor_MovieClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MoveiId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "MoveiId",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MoveiId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actors_Movies",
                newName: "MoveiId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MoveiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MoveiId",
                table: "Actors_Movies",
                column: "MoveiId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
