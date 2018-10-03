using Dapper;
using DataCore.Core.Dto.Index;
using DataCore.Core.Entities;
using DataCore.Core.Extensions;
using DataCore.Core.IRepositories;
using DataCore.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataCore.Core.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        protected readonly FutbolContext context;

        public EquipoRepository(FutbolContext dbContext)
        {
            context = dbContext;
        }

        public Equipo Get(long id)
        {
            return context.Equipo.FirstOrDefault(e => e.EquipoId == id);
        }

        public IList<Equipo> GetList()
        {
            var equipo1 = context.Equipo
                                 .FromSql("Select * from Equipo where PaisId = 1")
                                 .ToList();

            //View way
            var equipoIndexViews = context.EquipoViewIndex.Where(e => e.Pais.StartsWith("Arg")).ToList();

            //Reader ADO way
            List<EquipoViewIndex> indexList = new List<EquipoViewIndex>();
            var cmd = context.LoadStoredProc("EquipoIndex").WithSqlParam("Nombre", "R").ExecuteStoredProc<EquipoViewIndex>();

            //Dapper Way
            var adoConnection = context.Database.GetDbConnection().ConnectionString;
            var sqlConnection = new SqlConnection(adoConnection);
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Nombre", "R");

            var equipos = SqlMapper.Query<EquipoViewIndex>(sqlConnection, "EquipoIndex", parameters, null, true, null, CommandType.StoredProcedure).ToList();

            //context way
            return context.Equipo.ToList();
        }
    }
}
