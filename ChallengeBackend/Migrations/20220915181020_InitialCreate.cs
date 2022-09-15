using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeBackend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Género",
                columns: table => new
                {
                    GéneroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Género", x => x.GéneroId);
                });

            migrationBuilder.CreateTable(
                name: "Personaje",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Historia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaje", x => x.PersonajeId);
                });

            migrationBuilder.CreateTable(
                name: "PelículaOSerie",
                columns: table => new
                {
                    PelículaOSerieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Título = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeCreación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calificación = table.Column<int>(type: "int", nullable: false),
                    GéneroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PelículaOSerie", x => x.PelículaOSerieId);
                    table.ForeignKey(
                        name: "FK_PelículaOSerie_Género_GéneroId",
                        column: x => x.GéneroId,
                        principalTable: "Género",
                        principalColumn: "GéneroId");
                });

            migrationBuilder.CreateTable(
                name: "PelículaOSeriePersonaje",
                columns: table => new
                {
                    PelículaOSerieId = table.Column<int>(type: "int", nullable: false),
                    PersonajeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PelículaOSeriePersonaje", x => new { x.PelículaOSerieId, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_PelículaOSeriePersonaje_PelículaOSerie_PelículaOSerieId",
                        column: x => x.PelículaOSerieId,
                        principalTable: "PelículaOSerie",
                        principalColumn: "PelículaOSerieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PelículaOSeriePersonaje_Personaje_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PelículaOSerie_GéneroId",
                table: "PelículaOSerie",
                column: "GéneroId");

            migrationBuilder.CreateIndex(
                name: "IX_PelículaOSeriePersonaje_PersonajeId",
                table: "PelículaOSeriePersonaje",
                column: "PersonajeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PelículaOSeriePersonaje");

            migrationBuilder.DropTable(
                name: "PelículaOSerie");

            migrationBuilder.DropTable(
                name: "Personaje");

            migrationBuilder.DropTable(
                name: "Género");
        }
    }
}
