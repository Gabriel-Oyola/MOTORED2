using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Motored.BD.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmarContraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "motocicletas",
                columns: table => new
                {
                    IdMotocicleta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Aseguradora = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motocicletas", x => x.IdMotocicleta);
                    table.ForeignKey(
                        name: "FK_motocicletas_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "talleres",
                columns: table => new
                {
                    Idtaller = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<double>(type: "float", nullable: false),
                    Horarios = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinksMaps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reseñas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talleres", x => x.Idtaller);
                    table.ForeignKey(
                        name: "FK_talleres_usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "opiniones",
                columns: table => new
                {
                    IdOpinion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTaller = table.Column<int>(type: "int", nullable: false),
                    tallerIdtaller = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estrellas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opiniones", x => x.IdOpinion);
                    table.ForeignKey(
                        name: "FK_opiniones_talleres_tallerIdtaller",
                        column: x => x.tallerIdtaller,
                        principalTable: "talleres",
                        principalColumn: "Idtaller",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_opiniones_usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "talleresTop",
                columns: table => new
                {
                    idRanking = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTaller = table.Column<int>(type: "int", nullable: false),
                    TallerIdtaller = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkTaller = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talleresTop", x => x.idRanking);
                    table.ForeignKey(
                        name: "FK_talleresTop_talleres_TallerIdtaller",
                        column: x => x.TallerIdtaller,
                        principalTable: "talleres",
                        principalColumn: "Idtaller",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reportes",
                columns: table => new
                {
                    IdReporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuarioRC = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    IdTaller = table.Column<int>(type: "int", nullable: false),
                    TallerIdtaller = table.Column<int>(type: "int", nullable: false),
                    IdOpinion = table.Column<int>(type: "int", nullable: false),
                    OpinionIdOpinion = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estrellas = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sancion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reportes", x => x.IdReporte);
                    table.ForeignKey(
                        name: "FK_reportes_opiniones_OpinionIdOpinion",
                        column: x => x.OpinionIdOpinion,
                        principalTable: "opiniones",
                        principalColumn: "IdOpinion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reportes_talleres_TallerIdtaller",
                        column: x => x.TallerIdtaller,
                        principalTable: "talleres",
                        principalColumn: "Idtaller",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reportes_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_motocicletas_UsuarioId",
                table: "motocicletas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_opiniones_tallerIdtaller",
                table: "opiniones",
                column: "tallerIdtaller");

            migrationBuilder.CreateIndex(
                name: "IX_opiniones_usuarioId",
                table: "opiniones",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_reportes_OpinionIdOpinion",
                table: "reportes",
                column: "OpinionIdOpinion");

            migrationBuilder.CreateIndex(
                name: "IX_reportes_TallerIdtaller",
                table: "reportes",
                column: "TallerIdtaller");

            migrationBuilder.CreateIndex(
                name: "IX_reportes_UsuarioId",
                table: "reportes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_talleres_usuarioId",
                table: "talleres",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_talleresTop_TallerIdtaller",
                table: "talleresTop",
                column: "TallerIdtaller");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motocicletas");

            migrationBuilder.DropTable(
                name: "reportes");

            migrationBuilder.DropTable(
                name: "talleresTop");

            migrationBuilder.DropTable(
                name: "opiniones");

            migrationBuilder.DropTable(
                name: "talleres");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
