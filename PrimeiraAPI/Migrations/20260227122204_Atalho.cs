using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class Atalho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AlunoCursoId",
                table: "Alunos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semestres = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: true),
                    Mensalidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AlunoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                    table.ForeignKey(
                        name: "FK_Cursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId");
                });

            migrationBuilder.CreateTable(
                name: "AlunoCursos",
                columns: table => new
                {
                    AlunoCursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlunoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoCursos", x => x.AlunoCursoId);
                    table.ForeignKey(
                        name: "FK_AlunoCursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_AlunoCursoId",
                table: "Alunos",
                column: "AlunoCursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoCursos_AlunoId",
                table: "AlunoCursos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoCursos_CursoId",
                table: "AlunoCursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_AlunoId",
                table: "Cursos",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_AlunoCursos_AlunoCursoId",
                table: "Alunos",
                column: "AlunoCursoId",
                principalTable: "AlunoCursos",
                principalColumn: "AlunoCursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_AlunoCursos_AlunoCursoId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "AlunoCursos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_AlunoCursoId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "AlunoCursoId",
                table: "Alunos");
        }
    }
}
