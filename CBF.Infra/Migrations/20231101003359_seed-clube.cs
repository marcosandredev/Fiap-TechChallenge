using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBF.Infra.Migrations
{
    /// <inheritdoc />
    public partial class seedclube : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Clube (Nome,DtFundacao,Cidade,Estado,Pais,Ativo,CriadoEm,AtualizadoEm)
                                      VALUES('Sem Clube', '1900/01/01', '', '', '', 1, GETDATE(), GETDATE()),
                                            ('Aposentado', '1991/01/01', '', '', '', 1, GETDATE(), GETDATE())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
