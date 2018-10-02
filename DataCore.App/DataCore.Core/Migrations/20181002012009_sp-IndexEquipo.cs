using Microsoft.EntityFrameworkCore.Migrations;

namespace DataCore.Core.Migrations
{
    public partial class spIndexEquipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var script = @" CREATE PROCEDURE EquipoIndex (@Nombre NVARCHAR = NULL)
                            AS
                            BEGIN
	                            SELECT [EquipoId], E.[Nombre], P.Nombre AS Pais, D.Descripcion AS Division, [FechaInaguracion]
	                            FROM Equipo E INNER JOIN Pais P ON (E.PaisId = P.PaisId)
				                              INNER JOIN Division D ON ( E.DivisionId = D.DivisionId )
	                            WHERE @Nombre IS NULL OR E.Nombre LIKE '%' + @Nombre + '%'
                            END";
            migrationBuilder.Sql(script);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
