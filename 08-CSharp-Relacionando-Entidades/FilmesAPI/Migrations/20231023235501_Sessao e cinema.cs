using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesAPI.Migrations
{
    public partial class Sessaoecinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_FilmeID",
                table: "Sessoes");

            migrationBuilder.RenameColumn(
                name: "FilmeID",
                table: "Sessoes",
                newName: "FilmeId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessoes_FilmeID",
                table: "Sessoes",
                newName: "IX_Sessoes_FilmeId");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Sessoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessoes_CinemaId",
                table: "Sessoes",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes");

            migrationBuilder.DropIndex(
                name: "IX_Sessoes_CinemaId",
                table: "Sessoes");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Sessoes");

            migrationBuilder.RenameColumn(
                name: "FilmeId",
                table: "Sessoes",
                newName: "FilmeID");

            migrationBuilder.RenameIndex(
                name: "IX_Sessoes_FilmeId",
                table: "Sessoes",
                newName: "IX_Sessoes_FilmeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_FilmeID",
                table: "Sessoes",
                column: "FilmeID",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
