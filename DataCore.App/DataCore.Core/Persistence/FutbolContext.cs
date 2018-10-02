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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<EquipoIndexDto>();
        }

        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Pais> Pais { get; set; }


    }
}
