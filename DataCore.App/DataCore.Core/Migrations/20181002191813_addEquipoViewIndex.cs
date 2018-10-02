using Microsoft.EntityFrameworkCore.Migrations;

namespace DataCore.Core.Migrations
{
    public partial class addEquipoViewIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var script = @" CREATE VIEW EquipoViewIndex 
                            AS
	                            SELECT [EquipoId], E.[Nombre], P.Nombre AS Pais, D.Descripcion AS Division, [FechaInaguracion]
	                            FROM Equipo E INNER JOIN Pais P ON (E.PaisId = P.PaisId)
				                              INNER JOIN Division D ON ( E.DivisionId = D.DivisionId )";
            migrationBuilder.Sql(script);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
