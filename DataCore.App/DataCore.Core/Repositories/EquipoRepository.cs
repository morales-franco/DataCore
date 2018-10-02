using DataCore.Core.Dto.Index;
using DataCore.Core.Entities;
using DataCore.Core.IRepositories;
using DataCore.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

            var param = new SqlParameter("@Nombre", "Riv");
            var equipo2 = context.Equipo.FromSql("EquipoIndex @Nombre", param).ToList();
            return context.Equipo.ToList();
        }
    }
}
