using DataCore.Core.Dto.Index;
using DataCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore.Core.Persistence
{
    public class FutbolContext : DbContext
    {
        public FutbolContext(DbContextOptions<FutbolContext> options) : base(options)
        {
        }

        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Pais> Pais { get; set; }

        #region Views
        public DbQuery<EquipoViewIndex> EquipoViewIndex { get; set; }
        #endregion

        #region Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Query<EquipoViewIndex>().ToView("EquipoViewIndex");
        }
        #endregion
    }
}
