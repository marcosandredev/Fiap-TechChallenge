using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBF.Infra.Migrations
{
    /// <inheritdoc />
    public partial class removeyearestatistica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "EstatisticaJogadorClube");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "EstatisticaJogador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "EstatisticaJogadorClube",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "EstatisticaJogador",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
