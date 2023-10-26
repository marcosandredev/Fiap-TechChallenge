using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBF.Infra.Migrations
{
    /// <inheritdoc />
    public partial class initialdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clube",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DtFundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clube", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DtNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Posicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PePreferido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<double>(type: "float(5)", precision: 5, scale: 2, nullable: false),
                    Altura = table.Column<double>(type: "float(3)", precision: 3, scale: 2, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temporada",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temporada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NomeUsuario = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    SenhaCriptografa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Permissao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClubeJogador",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJogador = table.Column<long>(type: "bigint", nullable: false),
                    IdClube = table.Column<long>(type: "bigint", nullable: false),
                    DtInicioContrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtFimContrato = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salario = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubeJogador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClubeJogador_Clube_IdClube",
                        column: x => x.IdClube,
                        principalTable: "Clube",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubeJogador_Jogador_IdJogador",
                        column: x => x.IdJogador,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstatisticaJogador",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJogador = table.Column<long>(type: "bigint", nullable: false),
                    IdTemporada = table.Column<long>(type: "bigint", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Partidas = table.Column<int>(type: "int", nullable: false),
                    Gols = table.Column<int>(type: "int", nullable: false),
                    Assistencias = table.Column<int>(type: "int", nullable: false),
                    Amarelos = table.Column<int>(type: "int", nullable: false),
                    Vermelhos = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstatisticaJogador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstatisticaJogador_Jogador_IdJogador",
                        column: x => x.IdJogador,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstatisticaJogador_Temporada_IdTemporada",
                        column: x => x.IdTemporada,
                        principalTable: "Temporada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstatisticaJogadorClube",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJogador = table.Column<long>(type: "bigint", nullable: false),
                    IdClube = table.Column<long>(type: "bigint", nullable: false),
                    IdTemporada = table.Column<long>(type: "bigint", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Partidas = table.Column<int>(type: "int", nullable: false),
                    Gols = table.Column<int>(type: "int", nullable: false),
                    Assistencias = table.Column<int>(type: "int", nullable: false),
                    Amarelos = table.Column<int>(type: "int", nullable: false),
                    Vermelhos = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstatisticaJogadorClube", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstatisticaJogadorClube_Clube_IdClube",
                        column: x => x.IdClube,
                        principalTable: "Clube",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstatisticaJogadorClube_Jogador_IdJogador",
                        column: x => x.IdJogador,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstatisticaJogadorClube_Temporada_IdTemporada",
                        column: x => x.IdTemporada,
                        principalTable: "Temporada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transferencias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJogador = table.Column<long>(type: "bigint", nullable: false),
                    IdClubeAnterior = table.Column<long>(type: "bigint", nullable: false),
                    IdClubeNovo = table.Column<long>(type: "bigint", nullable: false),
                    IdTemporada = table.Column<long>(type: "bigint", nullable: false),
                    TipoTransferencia = table.Column<int>(type: "int", nullable: false),
                    DtTransferencia = table.Column<string>(type: "nvarchar(48)", nullable: false),
                    DtInicioContrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtPrevisaoFimContrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VlTransferencia = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transferencias_Clube_IdClubeAnterior",
                        column: x => x.IdClubeAnterior,
                        principalTable: "Clube",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transferencias_Clube_IdClubeNovo",
                        column: x => x.IdClubeNovo,
                        principalTable: "Clube",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transferencias_Jogador_IdJogador",
                        column: x => x.IdJogador,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transferencias_Temporada_IdTemporada",
                        column: x => x.IdTemporada,
                        principalTable: "Temporada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubeJogador_IdClube",
                table: "ClubeJogador",
                column: "IdClube");

            migrationBuilder.CreateIndex(
                name: "IX_ClubeJogador_IdJogador",
                table: "ClubeJogador",
                column: "IdJogador");

            migrationBuilder.CreateIndex(
                name: "IX_EstatisticaJogador_IdJogador",
                table: "EstatisticaJogador",
                column: "IdJogador");

            migrationBuilder.CreateIndex(
                name: "IX_EstatisticaJogador_IdTemporada",
                table: "EstatisticaJogador",
                column: "IdTemporada");

            migrationBuilder.CreateIndex(
                name: "IX_EstatisticaJogadorClube_IdClube",
                table: "EstatisticaJogadorClube",
                column: "IdClube");

            migrationBuilder.CreateIndex(
                name: "IX_EstatisticaJogadorClube_IdJogador",
                table: "EstatisticaJogadorClube",
                column: "IdJogador");

            migrationBuilder.CreateIndex(
                name: "IX_EstatisticaJogadorClube_IdTemporada",
                table: "EstatisticaJogadorClube",
                column: "IdTemporada");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_IdClubeAnterior",
                table: "Transferencias",
                column: "IdClubeAnterior");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_IdClubeNovo",
                table: "Transferencias",
                column: "IdClubeNovo");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_IdJogador",
                table: "Transferencias",
                column: "IdJogador");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_IdTemporada",
                table: "Transferencias",
                column: "IdTemporada");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_NomeUsuario",
                table: "Usuarios",
                column: "NomeUsuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubeJogador");

            migrationBuilder.DropTable(
                name: "EstatisticaJogador");

            migrationBuilder.DropTable(
                name: "EstatisticaJogadorClube");

            migrationBuilder.DropTable(
                name: "Transferencias");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Clube");

            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "Temporada");
        }
    }
}
