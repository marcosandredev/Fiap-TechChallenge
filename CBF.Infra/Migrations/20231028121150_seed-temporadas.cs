using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBF.Infra.Migrations
{
    /// <inheritdoc />
    public partial class seedtemporadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Temporada(Nome, Inicio, Fim, Ativo, CriadoEm, AtualizadoEm)
                                      VALUES('Temporada 1990', '1990/01/01', '1990/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1991', '1991/01/01', '1991/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1992', '1992/01/01', '1992/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1993', '1993/01/01', '1993/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1994', '1994/01/01', '1994/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1995', '1995/01/01', '1995/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1996', '1996/01/01', '1996/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1997', '1997/01/01', '1997/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1998', '1998/01/01', '1998/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 1999', '1999/01/01', '1999/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2000', '2000/01/01', '2000/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2001', '2001/01/01', '2001/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2002', '2002/01/01', '2002/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2003', '2003/01/01', '2003/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2004', '2004/01/01', '2004/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2005', '2005/01/01', '2005/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2006', '2006/01/01', '2006/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2007', '2007/01/01', '2007/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2008', '2008/01/01', '2008/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2009', '2009/01/01', '2009/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2010', '2010/01/01', '2010/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2011', '2011/01/01', '2011/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2012', '2012/01/01', '2012/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2013', '2013/01/01', '2013/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2014', '2014/01/01', '2014/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2015', '2015/01/01', '2015/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2016', '2016/01/01', '2016/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2017', '2017/01/01', '2017/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2018', '2018/01/01', '2018/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2019', '2019/01/01', '2019/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2020', '2020/01/01', '2020/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2021', '2021/01/01', '2021/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2022', '2022/01/01', '2022/12/31', 1, GETDATE(), GETDATE()),
                                            ('Temporada 2023', '2023/01/01', '2023/12/31', 1, GETDATE(), GETDATE())
                                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
